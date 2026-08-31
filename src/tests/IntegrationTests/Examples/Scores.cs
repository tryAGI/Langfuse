/*
order: 60
title: Scores
slug: scores

List scores for evaluating LLM outputs in Langfuse.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListScores()
    {
        using var client = GetAuthenticatedClient();

        //// List all scores in your project with pagination.
        var response = await client.ScoresV3.ScoresV3GetManyV3Async(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
