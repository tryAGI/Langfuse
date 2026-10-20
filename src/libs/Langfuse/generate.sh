#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://cloud.langfuse.com/generated/api/openapi.yml
# CI fetches the identical generated spec from GitHub to avoid intermittent
# 403 responses from the Langfuse CDN to GitHub-hosted runners.
install_autosdk_cli
temp_spec="$(mktemp)"
trap 'rm -f "$temp_spec"' EXIT
fetch_spec --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  -o "$temp_spec" \
  https://raw.githubusercontent.com/langfuse/langfuse/main/web/public/generated/api/openapi.yml

# Fail before replacing the checked-in spec on unexpected operation loss.
# Only reviewed migrations are approved; replacement APIs stay mandatory.
# Upstream retains the old Skills routes as compatibility aliases (langfuse#19025).
if [[ -f openapi.yaml ]]; then
  python3 ../../../scripts/preserve-skills-aliases.py openapi.yaml "$temp_spec"
  python3 ../../../scripts/check-openapi-migration.py openapi.yaml "$temp_spec"
else
  python3 ../../../scripts/check-openapi-migration.py "$temp_spec" "$temp_spec"
fi
mv "$temp_spec" openapi.yaml

# Auth: --security-scheme overrides per-operation BasicAuth with top-level HTTP Basic auth.
rm -rf Generated
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
