#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://cloud.langfuse.com/generated/api/openapi.yml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://cloud.langfuse.com/generated/api/openapi.yml -o openapi.yaml

# Auth: --security-scheme overrides per-operation BasicAuth with top-level HTTP Basic auth.
autosdk generate openapi.yaml \
  --namespace Langfuse \
  --clientClassName LangfuseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://cloud.langfuse.com \
  --security-scheme Http:Header:Basic \
  --auth-env-var LANGFUSE_PUBLIC_KEY \
  --auth-env-var LANGFUSE_SECRET_KEY
