#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://cloud.langfuse.com/generated/api/openapi.yml
# CI fetches the identical generated spec from GitHub to avoid intermittent
# 403 responses from the Langfuse CDN to GitHub-hosted runners.

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  -o openapi.yaml \
  https://raw.githubusercontent.com/langfuse/langfuse/main/web/public/generated/api/openapi.yml

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
