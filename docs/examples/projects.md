# Projects

Get information about the project associated with the API key.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// Retrieve the project associated with your API key.
var response = await client.Projects.ProjectsGetAsync();
```