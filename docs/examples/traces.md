# Traces

List and retrieve traces from the Langfuse API.

This example assumes `using Langfuse;` is in scope and `apiKey` contains your Langfuse API key.

```csharp
using var client = new LangfuseClient(apiKey);

// List the most recent traces in your project.
var response = await client.Trace.TraceListAsync(
    limit: 10);
```