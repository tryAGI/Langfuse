#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://cloud.langfuse.com/generated/api/openapi.yml"
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# Langfuse spec defines BasicAuth per-operation but not at top level.
# AutoSDK reads top-level security for constructor generation.
yq -i '.security = [{"BasicAuth": []}]' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Langfuse \
  --clientClassName LangfuseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://cloud.langfuse.com
