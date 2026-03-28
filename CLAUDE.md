# CLAUDE.md — Langfuse SDK

## Overview

Auto-generated C# SDK for [Langfuse](https://langfuse.com) — the open-source LLM observability platform.
Covers tracing, evaluation, prompt management, datasets, scores, metrics, and ingestion APIs.

## Build & Test

```bash
dotnet build Langfuse.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Langfuse uses **HTTP Basic Auth** (public key + secret key):

```csharp
var client = new LangfuseClient(
    username: publicKey,   // LANGFUSE_PUBLIC_KEY
    password: secretKey);  // LANGFUSE_SECRET_KEY
```

Self-hosted instances: pass `baseUri` parameter.

## Key Files

- `src/libs/Langfuse/generate.sh` — Regeneration script (downloads spec, runs autosdk with `--security-scheme`)
- `src/libs/Langfuse/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with Basic Auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://cloud.langfuse.com/generated/api/openapi.yml`
- Spec defines `BasicAuth` per-operation but not at top level; `--security-scheme Http:Header:Basic` overrides this at generation time
- No `servers` section in spec; `--base-url https://cloud.langfuse.com` passed to autosdk
