/*
order: 80
title: Experiments
slug: experiments

Read experiment runs and items instead of deprecated dataset-run endpoints.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListExperiments()
    {
        using var client = GetAuthenticatedClient();

        //// Experiment queries require a start time and use cursor pagination.
        var end = DateTime.UtcNow;
        var response = await client.Experiments.ExperimentsListAsync(
            fromStartTime: end.AddDays(-1),
            toStartTime: end,
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }

}
