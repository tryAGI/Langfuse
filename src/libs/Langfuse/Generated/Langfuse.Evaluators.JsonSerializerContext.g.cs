
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage), TypeInfoPropertyName = "CodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource), TypeInfoPropertyName = "PromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinition), TypeInfoPropertyName = "EvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>), TypeInfoPropertyName = "AllOfEvaluatorOutputDefinitionPublicEvaluatorNumericScore2PublicEvaluatorNumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType), TypeInfoPropertyName = "EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorNumericScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>), TypeInfoPropertyName = "AllOfEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2PublicEvaluatorBooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType), TypeInfoPropertyName = "EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorBooleanScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>), TypeInfoPropertyName = "AllOfEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2PublicEvaluatorCategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType), TypeInfoPropertyName = "EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorCategoricalScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinition), TypeInfoPropertyName = "PublicEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>), TypeInfoPropertyName = "AllOfPublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2PublicEvaluatorNumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType), TypeInfoPropertyName = "PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>), TypeInfoPropertyName = "AllOfPublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2PublicEvaluatorBooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType), TypeInfoPropertyName = "PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>), TypeInfoPropertyName = "AllOfPublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2PublicEvaluatorCategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType), TypeInfoPropertyName = "PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMapping), TypeInfoPropertyName = "PromptVariableMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyPromptVariableMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyEvaluationObject), TypeInfoPropertyName = "LegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorCode), TypeInfoPropertyName = "PublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Creator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CursorMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorChatMessageRole), TypeInfoPropertyName = "EvaluatorChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorChatPromptInput), TypeInfoPropertyName = "EvaluatorChatPromptInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAsJudgeEvaluatorVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluatorVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersion), TypeInfoPropertyName = "EvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>), TypeInfoPropertyName = "AllOfEvaluatorVersionLlmAsJudgeEvaluatorVersion2LlmAsJudgeEvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType), TypeInfoPropertyName = "EvaluatorVersionLlmAsJudgeEvaluatorVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>), TypeInfoPropertyName = "AllOfEvaluatorVersionCodeEvaluatorVersion2CodeEvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType), TypeInfoPropertyName = "EvaluatorVersionCodeEvaluatorVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorStatus), TypeInfoPropertyName = "EvaluatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAsJudgeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Evaluator), TypeInfoPropertyName = "Evaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>), TypeInfoPropertyName = "AllOfEvaluatorLlmAsJudgeEvaluator2LlmAsJudgeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType), TypeInfoPropertyName = "EvaluatorLlmAsJudgeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>), TypeInfoPropertyName = "AllOfEvaluatorCodeEvaluator2CodeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorCodeEvaluator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorCodeEvaluatorType), TypeInfoPropertyName = "EvaluatorCodeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateLlmAsJudgeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequest), TypeInfoPropertyName = "CreateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>), TypeInfoPropertyName = "AllOfCreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2CreateLlmAsJudgeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType), TypeInfoPropertyName = "CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>), TypeInfoPropertyName = "AllOfCreateEvaluatorRequestCreateCodeEvaluatorRequest2CreateCodeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType), TypeInfoPropertyName = "CreateEvaluatorRequestCreateCodeEvaluatorRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateEvaluatorMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateEvaluatorRequest), TypeInfoPropertyName = "UpdateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Evaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeletedEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage?), TypeInfoPropertyName = "NullableCodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource?), TypeInfoPropertyName = "NullablePromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinition?), TypeInfoPropertyName = "NullableEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?), TypeInfoPropertyName = "NullableAllOfEvaluatorOutputDefinitionPublicEvaluatorNumericScore2PublicEvaluatorNumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?), TypeInfoPropertyName = "NullableEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?), TypeInfoPropertyName = "NullableAllOfEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2PublicEvaluatorBooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?), TypeInfoPropertyName = "NullableEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?), TypeInfoPropertyName = "NullableAllOfEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2PublicEvaluatorCategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?), TypeInfoPropertyName = "NullableEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinition?), TypeInfoPropertyName = "NullablePublicEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?), TypeInfoPropertyName = "NullableAllOfPublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2PublicEvaluatorNumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?), TypeInfoPropertyName = "NullablePublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?), TypeInfoPropertyName = "NullableAllOfPublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2PublicEvaluatorBooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?), TypeInfoPropertyName = "NullablePublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?), TypeInfoPropertyName = "NullableAllOfPublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2PublicEvaluatorCategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?), TypeInfoPropertyName = "NullablePublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMapping?), TypeInfoPropertyName = "NullablePromptVariableMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyEvaluationObject?), TypeInfoPropertyName = "NullableLegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PublicApiErrorCode?), TypeInfoPropertyName = "NullablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorChatMessageRole?), TypeInfoPropertyName = "NullableEvaluatorChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorChatPromptInput?), TypeInfoPropertyName = "NullableEvaluatorChatPromptInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersion?), TypeInfoPropertyName = "NullableEvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?), TypeInfoPropertyName = "NullableAllOfEvaluatorVersionLlmAsJudgeEvaluatorVersion2LlmAsJudgeEvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType?), TypeInfoPropertyName = "NullableEvaluatorVersionLlmAsJudgeEvaluatorVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?), TypeInfoPropertyName = "NullableAllOfEvaluatorVersionCodeEvaluatorVersion2CodeEvaluatorVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType?), TypeInfoPropertyName = "NullableEvaluatorVersionCodeEvaluatorVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorStatus?), TypeInfoPropertyName = "NullableEvaluatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Evaluator?), TypeInfoPropertyName = "NullableEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?), TypeInfoPropertyName = "NullableAllOfEvaluatorLlmAsJudgeEvaluator2LlmAsJudgeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType?), TypeInfoPropertyName = "NullableEvaluatorLlmAsJudgeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?), TypeInfoPropertyName = "NullableAllOfEvaluatorCodeEvaluator2CodeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorCodeEvaluatorType?), TypeInfoPropertyName = "NullableEvaluatorCodeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequest?), TypeInfoPropertyName = "NullableCreateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?), TypeInfoPropertyName = "NullableAllOfCreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2CreateLlmAsJudgeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType?), TypeInfoPropertyName = "NullableCreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?), TypeInfoPropertyName = "NullableAllOfCreateEvaluatorRequestCreateCodeEvaluatorRequest2CreateCodeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType?), TypeInfoPropertyName = "NullableCreateEvaluatorRequestCreateCodeEvaluatorRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateEvaluatorRequest?), TypeInfoPropertyName = "NullableUpdateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Evaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorVersion>))]
    internal sealed partial class EvaluatorsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EvaluatorsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariableMappingJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorChatPromptInputJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorVersionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateEvaluatorRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UpdateEvaluatorRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>());
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
                    typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage)

                    || typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage?)

                    || typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource)

                    || typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject)

                    || typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject?)

                    || typeToConvert == typeof(global::Langfuse.PublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.PublicApiErrorCode?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorChatMessageRole)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorChatMessageRole?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorCodeEvaluatorType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorCodeEvaluatorType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorStatus)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorStatus?)

                    || typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType)

                    || typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType?)

                    || typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType)

                    || typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage))
                {
                    return new global::Langfuse.JsonConverters.CodeEvaluatorSourceCodeLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage?))
                {
                    return new global::Langfuse.JsonConverters.CodeEvaluatorSourceCodeLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource))
                {
                    return new global::Langfuse.JsonConverters.PromptVariableMappingSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource?))
                {
                    return new global::Langfuse.JsonConverters.PromptVariableMappingSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject))
                {
                    return new global::Langfuse.JsonConverters.LegacyEvaluationObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LegacyEvaluationObject?))
                {
                    return new global::Langfuse.JsonConverters.LegacyEvaluationObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.PublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.PublicApiErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorChatMessageRole))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorChatMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorChatMessageRole?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorChatMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorVersionCodeEvaluatorVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorVersionCodeEvaluatorVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorLlmAsJudgeEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorLlmAsJudgeEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorCodeEvaluatorType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorCodeEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorCodeEvaluatorType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorCodeEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorStatus))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorStatus?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType))
                {
                    return new global::Langfuse.JsonConverters.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType?))
                {
                    return new global::Langfuse.JsonConverters.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType))
                {
                    return new global::Langfuse.JsonConverters.CreateEvaluatorRequestCreateCodeEvaluatorRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType?))
                {
                    return new global::Langfuse.JsonConverters.CreateEvaluatorRequestCreateCodeEvaluatorRequestTypeNullableJsonConverter();
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
                    0 => new EvaluatorsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}