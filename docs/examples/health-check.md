# Health Check

Basic example showing how to create a client and check API health.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// Check that the Langfuse API and database are healthy.
var response = await client.Health.HealthHealthAsync();
```