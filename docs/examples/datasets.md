# Datasets

List and manage datasets for LLM evaluation in Langfuse.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// List all datasets in your project with pagination.
var response = await client.Datasets.DatasetsListAsync(
    limit: 10);
```