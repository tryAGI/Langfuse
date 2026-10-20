# Migration to the current Langfuse APIs

This SDK targets .NET 10 and the current Langfuse v4 public API. Use Langfuse
Cloud or a compatible self-hosted Langfuse v4 deployment; the new read APIs are
not a drop-in replacement for self-hosted v3. The official SDK upgrade guides
require self-hosted v4.59.0 or later. Check the endpoint availability of your
server before upgrading.

Langfuse Cloud sunsets legacy reads and trace/observation ingestion on
**November 16, 2026**. This is an API migration, not just a client rename.
The regenerated SDK removes legacy schema types and moves Scores v3 into
`client.Scores`. Consumers of removed members must update and recompile.

## Stable Skills API (October 20, 2026)

`client.Skills` uses the newly stable `/api/public/skills` endpoints. Existing
`client.UnstableSkills` members and `UnstableSkill*` models remain available:
Langfuse retains their old server routes as compatibility aliases. New code
should use `client.Skills`; existing callers can migrate separately.

Regeneration preserves exactly seven reviewed aliases and the schema components
they reference. It verifies that each stable replacement remains present,
nondeprecated and wire-compatible before retaining the alias; unexpected
operation loss still fails the original migration guard. A request/response
schema change requires another review rather than silently copying stale data.

See [the provider stabilization change](https://github.com/langfuse/langfuse/pull/19025).

## Authentication

```csharp
using var client = new Langfuse.LangfuseClient(
    username: publicKey, password: secretKey);
```

Use `baseUri` for your Langfuse region or self-hosted server. These are project
Basic Auth keys, not a single bearer API key.

## Replacement map

All routes below are relative to `/api/public`.

| Previous API | Current SDK/API | Semantic changes |
| --- | --- | --- |
| `GET /observations`, `GET /observations/{observationId}` | `client.Observations.ObservationsGetManyAsync` (`GET /v2/observations`) | Filter by `id` for a single observation; returns rows, not the old object shape. |
| `GET /traces`, `GET /traces/{traceId}` | Same observations method, with `traceId` | Group observation rows by trace ID; no legacy trace-object getter. Trace DELETE operations remain supported. |
| `GET /sessions`, `GET /sessions/{sessionId}` | Same observations method, with `sessionId` | Returns observations for a session, not a session summary object. |
| `GET /metrics` | `client.Metrics.MetricsMetricsAsync` (`GET /v2/metrics`) | Use `view: observations` and the current metrics query schema, with a bounded interval. |
| `GET /v2/scores`, `GET /v2/scores/{scoreId}` | `client.Scores.ScoresGetManyAsync` (`GET /v3/scores`) | Use `id` to select score IDs, not a get-by-ID route. Response shape changes. |
| `client.ScoresV3.ScoresV3GetManyV3Async` | `client.Scores.ScoresGetManyAsync` | This is now the Scores v3 resource, alongside score creation and deletion. |
| `GET /datasets/{datasetName}/runs`, `GET /datasets/{datasetName}/runs/{runName}` | `client.Experiments.ExperimentsListAsync`, then `ExperimentsListItemsAsync` | Select experiment by name/ID and dataset ID; reads require `fromStartTime`. |
| `GET /dataset-run-items` | `client.Experiments.ExperimentsListItemsAsync` (`GET /experiment-items`) | Select by experiment ID/name; cursor pagination. |
| `POST /dataset-run-items` | OpenTelemetry spans with the provider's experiment attributes | There is no equivalent generated create-item REST method. Follow the official experiment ingestion contract. |
| `DELETE /datasets/{datasetName}/runs/{runName}` | No direct replacement | List experiment items, then explicitly delete underlying traces using `client.Trace.TraceDeleteMultipleAsync` if that is the intended destructive action. This also removes trace data and is not an automatic alias for deleting run metadata. |
| Trace/observation events via `POST /ingestion` | `client.Opentelemetry.OpentelemetryExportTracesAsync` (`POST /otel/v1/traces`) | OTLP/HTTP JSON; send `x-langfuse-ingestion-version: 4` for real-time visibility. |
| Score events via legacy ingestion | `client.Scores.ScoresCreateAsync` (`POST /scores`) | Accepts a list of `CreateScoreRequest`; inspect accepted/rejected counts and errors. Delete via `ScoresDeleteAsync`. |

Legacy `score-create` ingestion events remain supported by Langfuse after the
cutover, but new SDK integrations should use direct score ingestion.

## Bounded reads and pagination

See the executable examples in `src/tests/IntegrationTests/Examples` and
[the generated examples](docs/examples/observations.md).

- Pass `fromStartTime` and `toStartTime` for observation/experiment queries, or
  `fromTimestamp`/`toTimestamp` for scores. All example intervals use UTC.
- Replace legacy page numbers with the endpoint's cursor parameter. Observation
  and experiment responses expose `Meta.Cursor`; continue until it is absent.
- For observations, select `fields` deliberately. IO fields are raw strings;
  `parseIoAsJson: true` is deprecated and rejected by the server.
- Observation ID lookup uses a JSON filter on `id`, not a fabricated URL suffix.
- Scores v3 uses `id` for ID filtering; do not assume the old v2 response or
  numbered pagination metadata. Consult the current API for its cursor contract.

## Regeneration safety

`scripts/check-openapi-migration.py` permits only the reviewed legacy operation
removals and requires the replacement routes to remain present and nondeprecated.
It checks HTTP operations, including removal of a GET from a path that retains
DELETE. Unexpected removals fail generation before replacing the checked-in spec.
It continues protecting replacements after the migration has completed.

## Offline validation

```sh
python3 -m unittest discover -s scripts/tests
dotnet build Langfuse.slnx -c Release
dotnet test src/tests/IntegrationTests -c Release --filter FullyQualifiedName~ReplacementApiContracts
dotnet publish src/tests/NativeAot/Langfuse.NativeAot.csproj -c Release -r osx-arm64 -o /tmp/langfuse-native
/tmp/langfuse-native/Langfuse.NativeAot
autosdk trim src/libs/Langfuse/Langfuse.csproj
```

Use `linux-x64` on Linux. The shared HTTP contract fixture exercises replacement
reads, filters, cursors, authentication, OTLP JSON/header handling and direct score
writes/deletes with an in-memory handler. Both stable and legacy Skills list calls are also covered. The native executable disables JSON
reflection. It does not call a provider or prove live server acceptance.

## Primary references

- [Official per-endpoint migration](https://langfuse.com/faq/all/deprecated-api-migration)
- [Versions and compatibility](https://langfuse.com/docs/compatibility)
- [Custom ingestion migration](https://langfuse.com/integrations/native/opentelemetry/migration-to-v4)
- [Public API](https://langfuse.com/docs/api-and-data-platform/features/public-api)
