# Prompts

List prompts managed in Langfuse.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// List all prompts in your project.
var response = await client.Prompts.PromptsListAsync(
    limit: 10);
```