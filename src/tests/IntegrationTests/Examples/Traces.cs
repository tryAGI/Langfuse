/*
order: 20
title: Observations
slug: observations

List observations from the current Langfuse API.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListObservations()
    {
        using var client = GetAuthenticatedClient();

        //// Bound observation reads to a time range; follow response.Meta.Cursor for more rows.
        var end = DateTime.UtcNow;
        var response = await client.Observations.ObservationsGetManyAsync(
            limit: 10,
            fromStartTime: end.AddDays(-1),
            toStartTime: end);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
