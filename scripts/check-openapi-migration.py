#!/usr/bin/env python3
"""Permit only reviewed v4 removals; reject loss of replacement operations."""
import json
from pathlib import Path
import subprocess
import sys

METHODS = {'get', 'post', 'put', 'patch', 'delete', 'head', 'options', 'trace'}
OBSERVATIONS = 'get /api/public/v2/observations'
METRICS = 'get /api/public/v2/metrics'
SCORES = 'get /api/public/v3/scores'
EXPERIMENTS = 'get /api/public/experiments'
ITEMS = 'get /api/public/experiment-items'
OTEL = 'post /api/public/otel/v1/traces'
# Reviewed against https://langfuse.com/faq/all/deprecated-api-migration.
# These are semantic migrations, not aliases; see MIGRATION.md.
REVIEWED_REMOVALS = {
    'post /api/public/dataset-run-items': [OTEL],
    'get /api/public/dataset-run-items': [ITEMS],
    'get /api/public/datasets/{datasetName}/runs': [EXPERIMENTS, ITEMS],
    'get /api/public/datasets/{datasetName}/runs/{runName}': [EXPERIMENTS, ITEMS],
    'delete /api/public/datasets/{datasetName}/runs/{runName}': [ITEMS, 'delete /api/public/traces'],
    'post /api/public/ingestion': [OTEL, 'post /api/public/scores'],
    'get /api/public/metrics': [METRICS],
    'get /api/public/observations': [OBSERVATIONS],
    'get /api/public/observations/{observationId}': [OBSERVATIONS],
    'get /api/public/sessions': [OBSERVATIONS],
    'get /api/public/sessions/{sessionId}': [OBSERVATIONS],
    'get /api/public/traces': [OBSERVATIONS],
    'get /api/public/traces/{traceId}': [OBSERVATIONS],
    'get /api/public/v2/scores': [SCORES],
    'get /api/public/v2/scores/{scoreId}': [SCORES],
}
REQUIRED = {operation for replacements in REVIEWED_REMOVALS.values() for operation in replacements}
REQUIRED.add('delete /api/public/scores/{scoreId}')


def operations(spec):
    return {f'{method} {path}': operation
            for path, item in spec['paths'].items()
            for method, operation in item.items() if method in METHODS}


def validate(previous, candidate):
    before, after = operations(previous), operations(candidate)
    errors = []
    for operation in sorted(before.keys() - after.keys()):
        if operation not in REVIEWED_REMOVALS:
            errors.append(f'Unreviewed removal: {operation}')
    for operation in sorted(REQUIRED):
        if operation not in after or after[operation].get('deprecated', False):
            errors.append(f'Missing or deprecated replacement: {operation}')
    return errors


def read_spec(path):
    text = Path(path).read_text()
    try:
        return json.loads(text)
    except json.JSONDecodeError:
        return json.loads(subprocess.check_output(['yq', '-o=json', '.', str(path)], text=True))


def main():
    previous, candidate = (read_spec(path) for path in sys.argv[1:])
    errors = validate(previous, candidate)
    if errors:
        print('\n'.join(errors), file=sys.stderr)
        return 1
    print('Reviewed Langfuse migration accepted; replacement operations present.')
    return 0


if __name__ == '__main__':
    sys.exit(main())
