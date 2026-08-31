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

        //// List the most recent observations in your project.
        var response = await client.Observations.ObservationsGetManyAsync(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
