# Health Check

Basic example showing how to create a client and check API health.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Check that the Langfuse API and database are healthy.
var response = await client.Health.HealthHealthAsync();
```