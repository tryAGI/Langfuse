/*
order: 85
title: Experiment Items
slug: experiment-items

Read experiment items instead of deprecated dataset-run items.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListExperimentItems()
    {
        using var client = GetAuthenticatedClient();

        //// Use experimentId or experimentName to select a run; follow Meta.Cursor.
        var end = DateTime.UtcNow;
        var response = await client.Experiments.ExperimentsListItemsAsync(
            fromStartTime: end.AddDays(-1),
            toStartTime: end,
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
