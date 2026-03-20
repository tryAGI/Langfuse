/*
order: 50
title: Projects
slug: projects

Get information about the project associated with the API key.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetProject()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve the project associated with your API key.
        var response = await client.Projects.ProjectsGetAsync();

        Assert.IsNotNull(response.Data);
    }
}
