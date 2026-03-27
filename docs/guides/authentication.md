# Authentication

The Langfuse SDK uses HTTP Basic authentication with a public key and secret key pair. You can obtain these from your [Langfuse project settings](https://cloud.langfuse.com/).

## Basic Usage

```csharp
using Langfuse;

var client = new LangfuseClient(
    username: Environment.GetEnvironmentVariable("LANGFUSE_PUBLIC_KEY")!,
    password: Environment.GetEnvironmentVariable("LANGFUSE_SECRET_KEY")!);
```

## Self-Hosted Instances

For self-hosted Langfuse instances, configure the base URL:

```csharp
var client = new LangfuseClient(
    username: Environment.GetEnvironmentVariable("LANGFUSE_PUBLIC_KEY")!,
    password: Environment.GetEnvironmentVariable("LANGFUSE_SECRET_KEY")!,
    baseUri: new Uri("https://your-langfuse-instance.example.com"));
```

## Environment Variables

| Variable | Description |
|----------|-------------|
| `LANGFUSE_PUBLIC_KEY` | Your Langfuse project public key |
| `LANGFUSE_SECRET_KEY` | Your Langfuse project secret key |
