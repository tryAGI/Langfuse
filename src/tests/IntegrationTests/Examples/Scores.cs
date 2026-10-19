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

        //// Read Scores API v3. Use cursor pagination instead of the legacy page parameter.
        var response = await client.Scores.ScoresGetManyAsync(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
