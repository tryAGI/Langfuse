# Observations

List observations from the current Langfuse API.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Bound observation reads to a time range; follow response.Meta.Cursor for more rows.
var end = DateTime.UtcNow;
var response = await client.Observations.ObservationsGetManyAsync(
    limit: 10,
    fromStartTime: end.AddDays(-1),
    toStartTime: end);
```