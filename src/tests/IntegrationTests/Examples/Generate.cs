/*
order: 10
title: Health Check
slug: health-check

Basic example showing how to create a client and check API health.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_HealthCheck()
    {
        using var client = GetAuthenticatedClient();

        //// Check that the Langfuse API and database are healthy.
        var response = await client.Health.HealthHealthAsync();

        Assert.AreEqual("OK", response.Status);
    }
}
