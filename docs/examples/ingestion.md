# OpenTelemetry ingestion

Ingest trace spans into Langfuse using the current OpenTelemetry endpoint.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Use the v4 ingestion header for real-time observation visibility.
var options = new AutoSDKRequestOptions
{
    Headers = { ["x-langfuse-ingestion-version"] = "4" },
};

// Create a span and send it via OTLP/HTTP JSON ingestion.
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
    ],
    requestOptions: options);
```