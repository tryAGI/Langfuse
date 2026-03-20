# Prompts

List prompts managed in Langfuse.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// List all prompts in your project.
var response = await client.Prompts.PromptsListAsync(
    limit: 10);
```