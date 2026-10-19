import copy
import importlib.util
from pathlib import Path
import unittest

spec = importlib.util.spec_from_file_location('migration', Path(__file__).parents[1] / 'check-openapi-migration.py')
migration = importlib.util.module_from_spec(spec)
spec.loader.exec_module(migration)


def document(operations):
    result = {'paths': {}}
    for operation in operations:
        method, path = operation.split(' ', 1)
        result['paths'].setdefault(path, {})[method] = {}
    return result


class MigrationTests(unittest.TestCase):
    def setUp(self):
        self.current = document(migration.REQUIRED)
        self.legacy = document(migration.REQUIRED | migration.REVIEWED_REMOVALS.keys())

    def test_reviewed_removals_require_all_replacements(self):
        self.assertEqual([], migration.validate(self.legacy, self.current))

    def test_unreviewed_removal_on_retained_path_is_rejected(self):
        previous = copy.deepcopy(self.current)
        previous['paths']['/api/public/traces']['patch'] = {}
        self.assertIn('Unreviewed removal: patch /api/public/traces', migration.validate(previous, self.current))

    def test_unreviewed_path_removal_is_rejected(self):
        previous = copy.deepcopy(self.current)
        previous['paths']['/api/public/prompts'] = {'get': {}}
        self.assertIn('Unreviewed removal: get /api/public/prompts', migration.validate(previous, self.current))

    def test_every_replacement_is_protected_after_migration(self):
        for operation in migration.REQUIRED:
            with self.subTest(operation=operation):
                candidate = copy.deepcopy(self.current)
                method, path = operation.split(' ', 1)
                del candidate['paths'][path][method]
                self.assertTrue(migration.validate(self.current, candidate))

    def test_deprecated_replacement_is_rejected(self):
        candidate = copy.deepcopy(self.current)
        candidate['paths']['/api/public/v2/observations']['get']['deprecated'] = True
        self.assertTrue(migration.validate(self.current, candidate))


if __name__ == '__main__':
    unittest.main()
