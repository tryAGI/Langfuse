# Experiment Items

Read experiment items instead of deprecated dataset-run items.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Use experimentId or experimentName to select a run; follow Meta.Cursor.
var end = DateTime.UtcNow;
var response = await client.Experiments.ExperimentsListItemsAsync(
    fromStartTime: end.AddDays(-1),
    toStartTime: end,
    limit: 10);
```