# Datasets

List and manage datasets for LLM evaluation in Langfuse.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// List all datasets in your project with pagination.
var response = await client.Datasets.DatasetsListAsync(
    limit: 10);
```