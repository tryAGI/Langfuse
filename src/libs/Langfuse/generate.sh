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
old_paths="$(mktemp)"
new_paths="$(mktemp)"
trap 'rm -f "$temp_spec" "$old_paths" "$new_paths"' EXIT
fetch_spec --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  -o "$temp_spec" \
  https://raw.githubusercontent.com/langfuse/langfuse/main/web/public/generated/api/openapi.yml

if [[ -f openapi.yaml ]]; then
  yq -r '.paths | keys | .[]' openapi.yaml | LC_ALL=C sort > "$old_paths"
  yq -r '.paths | keys | .[]' "$temp_spec" | LC_ALL=C sort > "$new_paths"
  removed_paths="$(comm -23 "$old_paths" "$new_paths")"
  if [[ -n "$removed_paths" ]]; then
    printf 'Warning: upstream Langfuse spec removed public paths; reusing checked-in spec:\n%s\n' "$removed_paths" >&2
  else
    mv "$temp_spec" openapi.yaml
  fi
else
  mv "$temp_spec" openapi.yaml
fi

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
