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
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Langfuse;

using var client = new LangfuseClient(apiKey);
```

<!-- EXAMPLES:START -->
### Health Check
Basic example showing how to create a client and check API health.

```csharp
using var client = new LangfuseClient(apiKey);

// Check that the Langfuse API and database are healthy.
var response = await client.Health.HealthHealthAsync();
```

### Traces
List and retrieve traces from the Langfuse API.

```csharp
using var client = new LangfuseClient(apiKey);

// List the most recent traces in your project.
var response = await client.Trace.TraceListAsync(
    limit: 10);
```

### Prompts
List prompts managed in Langfuse.

```csharp
using var client = new LangfuseClient(apiKey);

// List all prompts in your project.
var response = await client.Prompts.PromptsListAsync(
    limit: 10);
```

### Ingestion
Ingest trace events into Langfuse using the batch ingestion API.

```csharp
using var client = new LangfuseClient(apiKey);

// Create a trace event and send it via batch ingestion.
var traceId = Guid.NewGuid().ToString();
var traceEvent = new TraceEvent(body: new TraceBody
{
    Id = traceId,
    Name = "sdk-integration-test",
    Input = "What is Langfuse?",
    Output = "Langfuse is an open-source LLM observability platform.",
});

var ingestionEvent = new IngestionEvent(
    new AllOf<IngestionEventVariant12, TraceEvent>(
        value1: new IngestionEventVariant12(
            type: IngestionEventVariant1Type.TraceCreate),
        value2: traceEvent));

var response = await client.Ingestion.IngestionBatchAsync(
    batch: [ingestionEvent]);
```

### Projects
Get information about the project associated with the API key.

```csharp
using var client = new LangfuseClient(apiKey);

// Retrieve the project associated with your API key.
var response = await client.Projects.ProjectsGetAsync();
```

### Scores
List scores for evaluating LLM outputs in Langfuse.

```csharp
using var client = new LangfuseClient(apiKey);

// List all scores in your project with pagination.
var response = await client.Scores.ScoresGetManyAsync(
    limit: 10);
```

### Datasets
List and manage datasets for LLM evaluation in Langfuse.

```csharp
using var client = new LangfuseClient(apiKey);

// List all datasets in your project with pagination.
var response = await client.Datasets.DatasetsListAsync(
    limit: 10);
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
