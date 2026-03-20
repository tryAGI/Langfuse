/*
order: 70
title: Datasets
slug: datasets

List and manage datasets for LLM evaluation in Langfuse.
*/

namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListDatasets()
    {
        using var client = GetAuthenticatedClient();

        //// List all datasets in your project with pagination.
        var response = await client.Datasets.DatasetsListAsync(
            limit: 10);

        Assert.IsNotNull(response.Data);
        Assert.IsNotNull(response.Meta);
    }
}
