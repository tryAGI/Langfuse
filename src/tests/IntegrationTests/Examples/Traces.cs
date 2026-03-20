/*
order: 20
title: Traces
slug: traces

List and retrieve traces from the Langfuse API.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListTraces()
    {
        using var client = GetAuthenticatedClient();

        //// List the most recent traces in your project.
        var response = await client.Trace.TraceListAsync(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
