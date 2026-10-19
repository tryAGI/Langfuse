using System.Net;
using System.Text;
using System.Text.Json;

namespace Langfuse.Contracts;

// Shared by MSTest and the reflection-disabled NativeAOT executable. No network or credentials.
internal static class ReplacementApiContract
{
    internal static async Task RunAsync()
    {
        using var handler = new ContractHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new LangfuseClient(username: "test-public", password: "test-secret",
            httpClient: httpClient, baseUri: new Uri("https://langfuse.invalid"));
        var from = new DateTime(2026, 10, 1, 0, 0, 0, DateTimeKind.Utc);
        var to = from.AddDays(1);
        const string filter = "[{\"column\":\"id\",\"operator\":\"=\",\"value\":\"observation/1\",\"type\":\"string\"}]";
        var observations = await client.Observations.ObservationsGetManyAsync(
            fromStartTime: from, toStartTime: to, traceId: "trace/1", sessionId: "session 1", filter: filter, limit: 10);
        Require(observations.Meta.Cursor == "next/page", "Observation cursor deserialization");
        await client.Observations.ObservationsGetManyAsync(fromStartTime: from, toStartTime: to,
            cursor: observations.Meta.Cursor, limit: 10);
        var scores = await client.Scores.ScoresGetManyAsync(id: "score/1", cursor: "score/page", limit: 10,
            fromTimestamp: from, toTimestamp: to);
        Require(scores.Meta.Limit == 10, "Scores v3 metadata");
        var metrics = await client.Metrics.MetricsMetricsAsync("{\"view\":\"observations\"}");
        Require(metrics.Data.Count == 1, "Metrics v2 response");
        var experiments = await client.Experiments.ExperimentsListAsync(fromStartTime: from, toStartTime: to,
            name: "run 1", limit: 10);
        Require(experiments.Meta.Cursor == "next/page", "Experiments cursor");
        var items = await client.Experiments.ExperimentsListItemsAsync(fromStartTime: from, toStartTime: to,
            experimentId: "experiment/1", cursor: "item/page", limit: 10);
        Require(items.Meta.Cursor == "next/page", "Experiment items cursor");
        await client.Opentelemetry.OpentelemetryExportTracesAsync(
            resourceSpans: [new OtelResourceSpan { ScopeSpans = [new OtelScopeSpan { Spans = [new OtelSpan
            {
                TraceId = "0123456789abcdef0123456789abcdef", SpanId = "0123456789abcdef",
                Name = "migration-contract", Kind = 1,
                StartTimeUnixNano = "1790812800000000000", EndTimeUnixNano = "1790812800000000001",
            }] }] }],
            requestOptions: new AutoSDKRequestOptions { Headers = { ["x-langfuse-ingestion-version"] = "4" } });
        var created = await client.Scores.ScoresCreateAsync(request:
            [new CreateScoreRequest { Id = "score/1", Name = "quality", Value = 0.9, TraceId = "trace/1" }]);
        Require(created.PickCreateScoreBatchResults().Accepted == 1, "Batched scores response");
        await client.Scores.ScoresDeleteAsync(scoreId: "score-1");
        Require(handler.Count == 9, "All replacement requests completed");
    }

    private static void Require(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }

    private sealed class ContractHandler : HttpMessageHandler
    {
        internal int Count { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Count++;
            Require(request.Headers.Authorization?.Scheme == "Basic", "HTTP Basic scheme");
            Require(request.Headers.Authorization?.Parameter == Convert.ToBase64String(Encoding.UTF8.GetBytes("test-public:test-secret")), "HTTP Basic credentials");
            var uri = request.RequestUri ?? throw new InvalidOperationException("Missing URI");
            var query = uri.Query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries)
                .Select(part => part.Split('=', 2))
                .ToDictionary(pair => Uri.UnescapeDataString(pair[0]), pair => Uri.UnescapeDataString(pair[1]));
            string response;
            switch (uri.AbsolutePath)
            {
                case "/api/public/v2/observations":
                    Require(request.Method == HttpMethod.Get, "Observation GET");
                    Require(query.ContainsKey("fromStartTime") && query.ContainsKey("toStartTime"), "Bounded observations");
                    if (Count == 1)
                    {
                        Require(query["traceId"] == "trace/1" && query["sessionId"] == "session 1", "Trace/session replacements");
                        using var filter = JsonDocument.Parse(query["filter"]);
                        Require(filter.RootElement[0].GetProperty("value").GetString() == "observation/1", "Observation ID filter");
                    }
                    else Require(query["cursor"] == "next/page", "Observation pagination");
                    response = "{\"data\":[],\"meta\":{\"cursor\":\"next/page\"}}";
                    break;
                case "/api/public/v3/scores":
                    Require(request.Method == HttpMethod.Get && query["id"] == "score/1" && query["cursor"] == "score/page", "Scores v3 ID/cursor");
                    Require(query.ContainsKey("fromTimestamp") && query.ContainsKey("toTimestamp"), "Bounded scores");
                    response = "{\"data\":[],\"meta\":{\"limit\":10}}";
                    break;
                case "/api/public/v2/metrics":
                    Require(request.Method == HttpMethod.Get, "Metrics GET");
                    using (var metric = JsonDocument.Parse(query["query"]))
                        Require(metric.RootElement.GetProperty("view").GetString() == "observations", "Metrics query encoding");
                    response = "{\"data\":[{\"count\":1}]}";
                    break;
                case "/api/public/experiments":
                case "/api/public/experiment-items":
                    Require(request.Method == HttpMethod.Get && query.ContainsKey("fromStartTime") && query.ContainsKey("toStartTime"), "Bounded experiment reads");
                    if (uri.AbsolutePath.EndsWith("experiment-items", StringComparison.Ordinal))
                        Require(query["experimentId"] == "experiment/1" && query["cursor"] == "item/page", "Experiment item selection");
                    else Require(query["name"] == "run 1", "Experiment name selection");
                    response = "{\"data\":[],\"meta\":{\"cursor\":\"next/page\"}}";
                    break;
                case "/api/public/otel/v1/traces":
                    Require(request.Method == HttpMethod.Post && request.Headers.GetValues("x-langfuse-ingestion-version").Single() == "4", "OTLP v4 ingestion");
                    Require(request.Content?.Headers.ContentType?.MediaType == "application/json", "OTLP JSON content type");
                    using (var payload = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken)))
                    {
                        var span = payload.RootElement.GetProperty("resourceSpans")[0].GetProperty("scopeSpans")[0].GetProperty("spans")[0];
                        Require(span.GetProperty("traceId").GetString() == "0123456789abcdef0123456789abcdef", "OTLP trace serialization");
                        Require(span.GetProperty("startTimeUnixNano").GetString() == "1790812800000000000", "OTLP timestamp serialization");
                    }
                    response = "{}";
                    break;
                case "/api/public/scores":
                    Require(request.Method == HttpMethod.Post, "Direct score ingestion");
                    using (var payload = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken)))
                        Require(payload.RootElement[0].GetProperty("value").GetDouble() == 0.9, "Batched score payload");
                    response = "{\"accepted\":1,\"rejected\":0,\"errors\":[]}";
                    break;
                case "/api/public/scores/score-1":
                    Require(request.Method == HttpMethod.Delete, "Direct score deletion");
                    response = "{}";
                    break;
                default: throw new InvalidOperationException($"Unexpected or legacy endpoint: {request.Method} {uri}");
            }
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(response, Encoding.UTF8, "application/json") };
        }
    }
}
