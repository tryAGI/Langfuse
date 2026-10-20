import copy
import importlib.util
from pathlib import Path
import unittest

spec = importlib.util.spec_from_file_location('skills_aliases', Path(__file__).parents[1] / 'preserve-skills-aliases.py')
aliases = importlib.util.module_from_spec(spec)
spec.loader.exec_module(aliases)


def document(stable):
    name = 'Skill' if stable else 'UnstableSkill'
    operation = {
        'operationId': 'skills_get' if stable else 'unstable_skills_get',
        'tags': ['skills' if stable else 'unstableSkills'],
        'responses': {'200': {'description': 'ok', 'content': {'application/json': {
            'schema': {'$ref': f'#/components/schemas/{name}'},
        }}}},
    }
    result = {'paths': {}, 'components': {'schemas': {name: {'type': 'object', 'properties': {
        'title': {'type': 'string'}, 'description': {'type': 'string'},
        'child': {'$ref': f'#/components/schemas/{name}'},
    }}}}}
    for operation_name in aliases.ALIASES.values() if stable else aliases.ALIASES.keys():
        method, path = operation_name.split(' ', 1)
        result['paths'].setdefault(path, {})[method] = copy.deepcopy(operation)
    return result


class SkillsAliasesTests(unittest.TestCase):
    def setUp(self):
        self.previous, self.candidate = document(False), document(True)

    def test_retains_all_seven_aliases_and_their_original_sdk_names(self):
        result = aliases.preserve(self.previous, self.candidate)
        operations = aliases.migration.operations(result)
        for legacy, stable in aliases.ALIASES.items():
            self.assertEqual('unstable_skills_get', operations[legacy]['operationId'])
            self.assertEqual('skills_get', operations[stable]['operationId'])
        self.assertIn('UnstableSkill', result['components']['schemas'])
        self.assertIn('Skill', result['components']['schemas'])
        self.assertEqual(self.candidate, document(True), 'Input must not be mutated')
        self.assertEqual(result, aliases.preserve(result, self.candidate))

    def test_every_stable_operation_is_mandatory(self):
        for operation_name in aliases.ALIASES.values():
            with self.subTest(operation_name=operation_name):
                candidate = copy.deepcopy(self.candidate)
                method, path = operation_name.split(' ', 1)
                del candidate['paths'][path][method]
                with self.assertRaisesRegex(ValueError, 'Missing or deprecated stable'):
                    aliases.preserve(self.previous, candidate)

    def test_deprecated_stable_operation_is_rejected(self):
        self.candidate['paths']['/api/public/skills']['get']['deprecated'] = True
        with self.assertRaisesRegex(ValueError, 'deprecated stable'):
            aliases.preserve(self.previous, self.candidate)

    def test_property_names_that_look_like_documentation_are_wire_contracts(self):
        for name in ['title', 'description']:
            with self.subTest(name=name):
                candidate = copy.deepcopy(self.candidate)
                del candidate['components']['schemas']['Skill']['properties'][name]
                with self.assertRaisesRegex(ValueError, 'wire contract changed'):
                    aliases.preserve(self.previous, candidate)

    def test_type_change_is_rejected(self):
        self.candidate['components']['schemas']['Skill']['properties']['title']['type'] = 'integer'
        with self.assertRaisesRegex(ValueError, 'wire contract changed'):
            aliases.preserve(self.previous, self.candidate)

    def test_missing_pinned_alias_is_rejected(self):
        del self.previous['paths']['/api/public/unstable/skills']['get']
        with self.assertRaisesRegex(ValueError, 'Missing pinned'):
            aliases.preserve(self.previous, self.candidate)

    def test_conflicting_legacy_component_is_not_overwritten(self):
        self.candidate['components']['schemas']['UnstableSkill'] = {'type': 'integer'}
        with self.assertRaisesRegex(ValueError, 'Compatibility schema changed'):
            aliases.preserve(self.previous, self.candidate)

    def test_aliases_from_upstream_cannot_change_wire_contract(self):
        self.candidate['paths']['/api/public/unstable/skills'] = {'get': {'responses': {}}}
        with self.assertRaisesRegex(ValueError, 'compatibility route changed'):
            aliases.preserve(self.previous, self.candidate)


if __name__ == '__main__':
    unittest.main()
