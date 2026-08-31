/*
order: 40
title: OpenTelemetry ingestion
slug: ingestion

Ingest trace spans into Langfuse using the current OpenTelemetry endpoint.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_IngestTrace()
    {
        using var client = GetAuthenticatedClient();

        //// Create a span and send it via OTLP/HTTP JSON ingestion.
        var nowNanoseconds = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1_000_000).ToString();
        var response = await client.Opentelemetry.OpentelemetryExportTracesAsync(
            resourceSpans:
            [
                new OtelResourceSpan
                {
                    ScopeSpans =
                    [
                        new OtelScopeSpan
                        {
                            Spans =
                            [
                                new OtelSpan
                                {
                                    TraceId = Guid.NewGuid().ToString("N"),
                                    SpanId = Guid.NewGuid().ToString("N")[..16],
                                    Name = "sdk-integration-test",
                                    Kind = 1,
                                    StartTimeUnixNano = nowNanoseconds,
                                    EndTimeUnixNano = nowNanoseconds,
                                },
                            ],
                        },
                    ],
                },
            ]);

        Assert.IsNotNull(response);
    }
}
