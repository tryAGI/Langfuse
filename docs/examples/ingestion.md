# Ingestion

Ingest trace events into Langfuse using the batch ingestion API.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// Create a trace event and send it via batch ingestion.
var traceId = Guid.NewGuid().ToString();
var traceEvent = new TraceEvent(body: new TraceBody
{
    Id = traceId,
    Name = "sdk-integration-test",
    Input = "What is Langfuse?",
    Output = "Langfuse is an open-source LLM observability platform.",
});

var ingestionEvent = new IngestionEvent(
    new AllOf<IngestionEventVariant12, TraceEvent>(
        value1: new IngestionEventVariant12(
            type: IngestionEventVariant1Type.TraceCreate),
        value2: traceEvent));

var response = await client.Ingestion.IngestionBatchAsync(
    batch: [ingestionEvent]);
```