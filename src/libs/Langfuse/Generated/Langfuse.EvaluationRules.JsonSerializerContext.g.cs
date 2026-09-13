
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource), TypeInfoPropertyName = "PromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleStringFilterOperator), TypeInfoPropertyName = "EvaluationRuleStringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleNumberFilterOperator), TypeInfoPropertyName = "EvaluationRuleNumberFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator), TypeInfoPropertyName = "EvaluationRuleOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator), TypeInfoPropertyName = "EvaluationRuleArrayOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator), TypeInfoPropertyName = "EvaluationRuleBooleanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleNullFilterOperator), TypeInfoPropertyName = "EvaluationRuleNullFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DateTimeEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.StringEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumberEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.StringOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ArrayOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.StringObjectEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumberObjectEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoryOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NullEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMapping), TypeInfoPropertyName = "PromptVariableMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyPromptVariableMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyEvaluationObject), TypeInfoPropertyName = "LegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilter), TypeInfoPropertyName = "EvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterDateTimeEvaluationRuleFilter2DateTimeEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterDateTimeEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterStringEvaluationRuleFilter2StringEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterStringEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterNumberEvaluationRuleFilter2NumberEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterNumberEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterStringOptionsEvaluationRuleFilter2StringOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterStringOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2CategoryOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterArrayOptionsEvaluationRuleFilter2ArrayOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterStringObjectEvaluationRuleFilter2StringObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterStringObjectEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterNumberObjectEvaluationRuleFilter2NumberObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterNumberObjectEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterBooleanEvaluationRuleFilter2BooleanEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterBooleanEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfEvaluationRuleFilterNullEvaluationRuleFilter2NullEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType), TypeInfoPropertyName = "EvaluationRuleFilterNullEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilterBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilterWithKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilter), TypeInfoPropertyName = "EvaluationRuleReadFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorCode), TypeInfoPropertyName = "PublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleEvaluatorAssignmentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Creator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRulesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CursorMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeletedEvaluationRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource?), TypeInfoPropertyName = "NullablePromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleStringFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleStringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleNumberFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleNumberFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleArrayOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleBooleanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleNullFilterOperator?), TypeInfoPropertyName = "NullableEvaluationRuleNullFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMapping?), TypeInfoPropertyName = "NullablePromptVariableMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyEvaluationObject?), TypeInfoPropertyName = "NullableLegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilter?), TypeInfoPropertyName = "NullableEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterDateTimeEvaluationRuleFilter2DateTimeEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterDateTimeEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterStringEvaluationRuleFilter2StringEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterStringEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterNumberEvaluationRuleFilter2NumberEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterNumberEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterStringOptionsEvaluationRuleFilter2StringOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterStringOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2CategoryOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterArrayOptionsEvaluationRuleFilter2ArrayOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterArrayOptionsEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterStringObjectEvaluationRuleFilter2StringObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterStringObjectEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterNumberObjectEvaluationRuleFilter2NumberObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterNumberObjectEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterBooleanEvaluationRuleFilter2BooleanEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterBooleanEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfEvaluationRuleFilterNullEvaluationRuleFilter2NullEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType?), TypeInfoPropertyName = "NullableEvaluationRuleFilterNullEvaluationRuleFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilter?), TypeInfoPropertyName = "NullableEvaluationRuleReadFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorCode?), TypeInfoPropertyName = "NullablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleReadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRule>))]
    internal sealed partial class EvaluationRulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationRulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EvaluationRulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariableMappingJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluationRuleFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluationRuleReadFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource)

                    || typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleStringFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleStringFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleNumberFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleNumberFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleNullFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleNullFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject)

                    || typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType)

                    || typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType?)

                    || typeToConvert == typeof(global::Langfuse.PublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.PublicApiErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource))
                {
                    return new global::Langfuse.JsonConverters.PromptVariableMappingSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource?))
                {
                    return new global::Langfuse.JsonConverters.PromptVariableMappingSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleStringFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleStringFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleStringFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleStringFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleNumberFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleNumberFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleNumberFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleNumberFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleOptionsFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleOptionsFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleOptionsFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleArrayOptionsFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleArrayOptionsFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleArrayOptionsFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleBooleanFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleBooleanFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleBooleanFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleNullFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleNullFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleNullFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleNullFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject))
                {
                    return new global::Langfuse.JsonConverters.LegacyEvaluationObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject?))
                {
                    return new global::Langfuse.JsonConverters.LegacyEvaluationObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterDateTimeEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterDateTimeEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNumberEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNumberEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringOptionsEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringOptionsEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringObjectEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterStringObjectEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNumberObjectEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNumberObjectEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterBooleanEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterBooleanEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNullEvaluationRuleFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluationRuleFilterNullEvaluationRuleFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.PublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.PublicApiErrorCodeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new EvaluationRulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}