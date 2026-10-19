# Scores

List scores for evaluating LLM outputs in Langfuse.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Read Scores API v3. Use cursor pagination instead of the legacy page parameter.
var response = await client.Scores.ScoresGetManyAsync(
    limit: 10);
```