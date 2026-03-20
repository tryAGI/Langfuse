/*
order: 40
title: Ingestion
slug: ingestion

Ingest trace events into Langfuse using the batch ingestion API.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_IngestTrace()
    {
        using var client = GetAuthenticatedClient();

        //// Create a trace event and send it via batch ingestion.
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

        Assert.IsNotNull(response.Successes);
        Assert.AreEqual(0, response.Errors.Count);
    }
}
