/*
order: 90
title: Metrics
slug: metrics

Query aggregate observation metrics through Metrics API v2.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_QueryMetrics()
    {
        using var client = GetAuthenticatedClient();

        //// Query observations in a bounded UTC interval instead of legacy trace metrics.
        var end = DateTime.UtcNow;
        var query = $$"""
            {"view":"observations","metrics":[{"measure":"count","aggregation":"count"}],
             "dimensions":[],"filters":[],"fromTimestamp":"{{end.AddDays(-1):O}}","toTimestamp":"{{end:O}}"}
            """;
        var response = await client.Metrics.MetricsMetricsAsync(query: query);

        Assert.IsNotNull(response.Data);
    }
}
