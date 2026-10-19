# Metrics

Query aggregate observation metrics through Metrics API v2.

This example assumes `using Langfuse;` is in scope and `publicKey` / `secretKey` contain your Langfuse project Basic Auth keys.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Query observations in a bounded UTC interval instead of legacy trace metrics.
var end = DateTime.UtcNow;
var query = $$"""
    {"view":"observations","metrics":[{"measure":"count","aggregation":"count"}],
     "dimensions":[],"filters":[],"fromTimestamp":"{{end.AddDays(-1):O}}","toTimestamp":"{{end:O}}"}
    """;
var response = await client.Metrics.MetricsMetricsAsync(query: query);
```