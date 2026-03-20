# Langfuse

[![Nuget package](https://img.shields.io/nuget/vpre/Langfuse)](https://www.nuget.org/packages/Langfuse/)
[![dotnet](https://github.com/tryAGI/Langfuse/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Langfuse/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Langfuse)](https://github.com/tryAGI/Langfuse/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Langfuse OpenAPI specification](https://raw.githubusercontent.com/Langfuse/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
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

## Support

Priority place for bugs: https://github.com/tryAGI/Langfuse/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Langfuse/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
