#!/usr/bin/env python3
"""Keep the seven provider-supported Skills compatibility routes in generated SDKs.

Upstream proof: langfuse/langfuse#19025 (d9b656b), which retains the old server
routes as aliases while publishing only the stable paths in OpenAPI.
"""
import copy
import importlib.util
from pathlib import Path
import sys

_spec = importlib.util.spec_from_file_location('migration', Path(__file__).with_name('check-openapi-migration.py'))
migration = importlib.util.module_from_spec(_spec)
_spec.loader.exec_module(migration)

ALIASES = {
    f'{method} /api/public/unstable/skills{suffix}': f'{method} /api/public/skills{suffix}'
    for method, suffix in [
        ('get', ''), ('post', ''), ('get', '/{skillName}'), ('patch', '/{skillName}'),
        ('delete', '/{skillName}/versions/{skillVersion}'),
        ('patch', '/{skillName}/versions/{skillVersion}'), ('get', '/files/content'),
    ]
}
MAP_KEYS = {'properties', 'patternProperties', 'headers', 'responses', 'content', 'encoding', 'schemas', 'parameters', 'securitySchemes', 'links', 'callbacks', 'security'}
DOC_KEYS = {'description', 'summary', 'title', 'example', 'examples', 'externalDocs', 'operationId', 'tags'}


def resolve(document, reference):
    if not reference.startswith('#/'):
        raise ValueError(f'Unsupported compatibility reference: {reference}')
    value = document
    for part in reference[2:].split('/'):
        value = value[part.replace('~1', '/').replace('~0', '~')]
    return value


def same_contract(before, after, previous, candidate, seen=None, is_map=False):
    seen = set() if seen is None else seen
    if isinstance(before, dict) and isinstance(after, dict):
        pair = (before.get('$ref', id(before)), after.get('$ref', id(after)))
        if '$ref' in before or '$ref' in after:
            if pair in seen:
                return True
            seen = seen | {pair}
            before = {**resolve(previous, before['$ref']), **{k: v for k, v in before.items() if k != '$ref'}} if '$ref' in before else before
            after = {**resolve(candidate, after['$ref']), **{k: v for k, v in after.items() if k != '$ref'}} if '$ref' in after else after
        before = {k: v for k, v in before.items() if is_map or (k not in DOC_KEYS and not k.startswith('x-fern-'))}
        after = {k: v for k, v in after.items() if is_map or (k not in DOC_KEYS and not k.startswith('x-fern-'))}
        return before.keys() == after.keys() and all(same_contract(before[k], after[k], previous, candidate, seen, not is_map and k in MAP_KEYS) for k in before)
    if isinstance(before, list) and isinstance(after, list):
        return len(before) == len(after) and all(same_contract(a, b, previous, candidate, seen, is_map) for a, b in zip(before, after))
    return before == after


def preserve(previous, upstream):
    candidate = copy.deepcopy(upstream)
    old_operations, new_operations = migration.operations(previous), migration.operations(candidate)

    def copy_references(value, visited):
        if isinstance(value, dict):
            reference = value.get('$ref')
            if reference is not None and reference not in visited:
                visited.add(reference)
                original = resolve(previous, reference)
                try:
                    existing = resolve(candidate, reference)
                except KeyError:
                    parts = reference[2:].split('/')
                    target = candidate
                    for part in parts[:-1]:
                        target = target.setdefault(part.replace('~1', '/').replace('~0', '~'), {})
                    target[parts[-1].replace('~1', '/').replace('~0', '~')] = copy.deepcopy(original)
                    copy_references(original, visited)
                else:
                    if not same_contract(original, existing, previous, candidate):
                        raise ValueError(f'Compatibility schema changed: {reference}')
            for item in value.values():
                copy_references(item, visited)
        elif isinstance(value, list):
            for item in value:
                copy_references(item, visited)

    for legacy, stable in ALIASES.items():
        if stable not in new_operations or new_operations[stable].get('deprecated', False):
            raise ValueError(f'Missing or deprecated stable Skills replacement: {stable}')
        if legacy not in old_operations:
            raise ValueError(f'Missing pinned Skills compatibility operation: {legacy}')
        if not same_contract(old_operations[legacy], new_operations[stable], previous, candidate):
            raise ValueError(f'Skills wire contract changed: {legacy} -> {stable}')
        if legacy in new_operations:
            if not same_contract(old_operations[legacy], new_operations[legacy], previous, candidate):
                raise ValueError(f'Skills compatibility route changed: {legacy}')
        method, path = legacy.split(' ', 1)
        candidate['paths'].setdefault(path, {})[method] = copy.deepcopy(old_operations[legacy])
        copy_references(old_operations[legacy], set())
    return candidate


def main():
    import json
    previous_path, candidate_path = sys.argv[1:]
    candidate = preserve(migration.read_spec(previous_path), migration.read_spec(candidate_path))
    Path(candidate_path).write_text(json.dumps(candidate, indent=2) + '\n')
    print('Preserved seven reviewed Skills compatibility routes; stable wire contracts match.')


if __name__ == '__main__':
    main()
