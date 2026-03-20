# Scores

List scores for evaluating LLM outputs in Langfuse.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// List all scores in your project with pagination.
var response = await client.Scores.ScoresGetManyAsync(
    limit: 10);
```