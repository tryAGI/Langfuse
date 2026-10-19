# Experiments

Read experiment runs and items instead of deprecated dataset-run endpoints.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Experiment queries require a start time and use cursor pagination.
var end = DateTime.UtcNow;
var response = await client.Experiments.ExperimentsListAsync(
    fromStartTime: end.AddDays(-1),
    toStartTime: end,
    limit: 10);
```