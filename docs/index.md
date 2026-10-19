# Langfuse

[![Nuget package](https://img.shields.io/nuget/vpre/Langfuse)](https://www.nuget.org/packages/Langfuse/)
[![dotnet](https://github.com/tryAGI/Langfuse/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Langfuse/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Langfuse)](https://github.com/tryAGI/Langfuse/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Langfuse OpenAPI specification](https://cloud.langfuse.com/generated/api/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Targets .NET 10

## Langfuse v4 migration

This SDK uses the current v4 public APIs. See [MIGRATION.md](MIGRATION.md) for
breaking changes, replacement methods, and self-hosted compatibility. Langfuse
Cloud removes legacy reads and trace ingestion on November 16, 2026.

### Usage
```csharp
using Langfuse;

using var client = new LangfuseClient(username: publicKey, password: secretKey);
```

<!-- EXAMPLES:START -->
### Health Check
Basic example showing how to create a client and check API health.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Check that the Langfuse API and database are healthy.
var response = await client.Health.HealthHealthAsync();
```

### Observations
List observations from the current Langfuse API.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Bound observation reads to a time range; follow response.Meta.Cursor for more rows.
var end = DateTime.UtcNow;
var response = await client.Observations.ObservationsGetManyAsync(
    limit: 10,
    fromStartTime: end.AddDays(-1),
    toStartTime: end);
```

### Prompts
List prompts managed in Langfuse.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// List all prompts in your project.
var response = await client.Prompts.PromptsListAsync(
    limit: 10);
```

### OpenTelemetry ingestion
Ingest trace spans into Langfuse using the current OpenTelemetry endpoint.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Use the v4 ingestion header for real-time observation visibility.
var options = new AutoSDKRequestOptions
{
    Headers = { ["x-langfuse-ingestion-version"] = "4" },
};

// Create a span and send it via OTLP/HTTP JSON ingestion.
var nowNanoseconds = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1_000_000).ToString();
var response = await client.Opentelemetry.OpentelemetryExportTracesAsync(
    resourceSpans:
    [
        new OtelResourceSpan
        {
            ScopeSpans =
            [
                new OtelScopeSpan
                {
                    Spans =
                    [
                        new OtelSpan
                        {
                            TraceId = Guid.NewGuid().ToString("N"),
                            SpanId = Guid.NewGuid().ToString("N")[..16],
                            Name = "sdk-integration-test",
                            Kind = 1,
                            StartTimeUnixNano = nowNanoseconds,
                            EndTimeUnixNano = nowNanoseconds,
                        },
                    ],
                },
            ],
        },
    ],
    requestOptions: options);
```

### Projects
Get information about the project associated with the API key.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Retrieve the project associated with your API key.
var response = await client.Projects.ProjectsGetAsync();
```

### Scores
List scores for evaluating LLM outputs in Langfuse.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Read Scores API v3. Use cursor pagination instead of the legacy page parameter.
var response = await client.Scores.ScoresGetManyAsync(
    limit: 10);
```

### Datasets
List and manage datasets for LLM evaluation in Langfuse.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// List all datasets in your project with pagination.
var response = await client.Datasets.DatasetsListAsync(
    limit: 10);
```

### Experiments
Read experiment runs and items instead of deprecated dataset-run endpoints.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Experiment queries require a start time and use cursor pagination.
var end = DateTime.UtcNow;
var response = await client.Experiments.ExperimentsListAsync(
    fromStartTime: end.AddDays(-1),
    toStartTime: end,
    limit: 10);
```

### Experiment Items
Read experiment items instead of deprecated dataset-run items.

```csharp
using var client = new LangfuseClient(username: publicKey, password: secretKey);

// Use experimentId or experimentName to select a run; follow Meta.Cursor.
var end = DateTime.UtcNow;
var response = await client.Experiments.ExperimentsListItemsAsync(
    fromStartTime: end.AddDays(-1),
    toStartTime: end,
    limit: 10);
```

### Metrics
Query aggregate observation metrics through Metrics API v2.

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
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Langfuse/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Langfuse/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
