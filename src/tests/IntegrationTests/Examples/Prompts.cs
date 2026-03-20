/*
order: 30
title: Prompts
slug: prompts

List prompts managed in Langfuse.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListPrompts()
    {
        using var client = GetAuthenticatedClient();

        //// List all prompts in your project.
        var response = await client.Prompts.PromptsListAsync(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
