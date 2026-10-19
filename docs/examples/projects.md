# Projects

Get information about the project associated with the API key.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Retrieve the project associated with your API key.
var response = await client.Projects.ProjectsGetAsync();
```