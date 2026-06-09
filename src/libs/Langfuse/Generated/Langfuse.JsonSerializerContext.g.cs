
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
            typeof(global::Langfuse.JsonConverters.AnnotationQueueStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueObjectTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueObjectTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportModeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFieldGroupJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFieldGroupNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageSyncStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageSyncStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.PricingTierOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ModelUsageUnitJsonConverter),

            typeof(global::Langfuse.JsonConverters.ModelUsageUnitNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationLevelJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationLevelNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CommentObjectTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CommentObjectTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.DatasetStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.DatasetStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreConfigDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreConfigDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant3TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant3TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant4TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant4TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant5TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant5TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant6TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant6TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant7TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant7TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant8TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant8TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant9TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant9TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant10TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant10TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyCreateScoreSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyCreateScoreSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LlmAdapterJsonConverter),

            typeof(global::Langfuse.JsonConverters.LlmAdapterNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.MediaContentTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.MediaContentTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.MembershipRoleJsonConverter),

            typeof(global::Langfuse.JsonConverters.MembershipRoleNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PlaceholderMessageTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PlaceholderMessageTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateChatPromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateChatPromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateTextPromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateTextPromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant1KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant1KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant2KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant2KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant3KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant3KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant4KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant4KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1JsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateScoreValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.MapValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionUsageJsonConverter),

            typeof(global::Langfuse.JsonConverters.UsageDetailsJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3JsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluationRuleRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant12, global::Langfuse.NumericScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant22, global::Langfuse.CategoricalScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant32, global::Langfuse.BooleanScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant42, global::Langfuse.TextScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>),

            typeof(global::Langfuse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueStatus), TypeInfoPropertyName = "AnnotationQueueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueObjectType), TypeInfoPropertyName = "AnnotationQueueObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedAnnotationQueues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.AnnotationQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedAnnotationQueueItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.AnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateAnnotationQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateAnnotationQueueItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateAnnotationQueueItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteAnnotationQueueItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteAnnotationQueueAssignmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateAnnotationQueueAssignmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationType), TypeInfoPropertyName = "BlobStorageIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileType), TypeInfoPropertyName = "BlobStorageIntegrationFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportMode), TypeInfoPropertyName = "BlobStorageExportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFrequency), TypeInfoPropertyName = "BlobStorageExportFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportSource), TypeInfoPropertyName = "BlobStorageExportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFieldGroup), TypeInfoPropertyName = "BlobStorageExportFieldGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateBlobStorageIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.BlobStorageIntegrationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageSyncStatus), TypeInfoPropertyName = "BlobStorageSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationDeletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateCommentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateCommentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetCommentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Trace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceWithDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceWithFullDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ObservationsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1), TypeInfoPropertyName = "ScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SessionWithTraces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Observation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel), TypeInfoPropertyName = "ObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>), TypeInfoPropertyName = "DictionaryStringInt32_System_Collections_Generic_Dictionary_string_int")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreConfigDataType), TypeInfoPropertyName = "ScoreConfigDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ConfigCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ConfigCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource), TypeInfoPropertyName = "ScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant12, global::Langfuse.NumericScoreV1>), TypeInfoPropertyName = "AllOfScoreV1Variant12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant1DataType), TypeInfoPropertyName = "ScoreV1Variant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant22, global::Langfuse.CategoricalScoreV1>), TypeInfoPropertyName = "AllOfScoreV1Variant22CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant2DataType), TypeInfoPropertyName = "ScoreV1Variant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant32, global::Langfuse.BooleanScoreV1>), TypeInfoPropertyName = "AllOfScoreV1Variant32BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant3DataType), TypeInfoPropertyName = "ScoreV1Variant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant42, global::Langfuse.TextScoreV1>), TypeInfoPropertyName = "AllOfScoreV1Variant42TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant4DataType), TypeInfoPropertyName = "ScoreV1Variant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Score), TypeInfoPropertyName = "Score2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>), TypeInfoPropertyName = "AllOfScoreVariant12NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant1DataType), TypeInfoPropertyName = "ScoreVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>), TypeInfoPropertyName = "AllOfScoreVariant22CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant2DataType), TypeInfoPropertyName = "ScoreVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>), TypeInfoPropertyName = "AllOfScoreVariant32BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant3DataType), TypeInfoPropertyName = "ScoreVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>), TypeInfoPropertyName = "AllOfScoreVariant42CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant4DataType), TypeInfoPropertyName = "ScoreVariant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>), TypeInfoPropertyName = "AllOfScoreVariant52TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant5DataType), TypeInfoPropertyName = "ScoreVariant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreValue), TypeInfoPropertyName = "CreateScoreValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CommentObjectType), TypeInfoPropertyName = "CommentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetStatus), TypeInfoPropertyName = "DatasetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetRunItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetRunWithItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.DatasetRunItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelUsageUnit), TypeInfoPropertyName = "ModelUsageUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Langfuse.ModelPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierOperator), TypeInfoPropertyName = "PricingTierOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MapValue), TypeInfoPropertyName = "MapValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreDataType), TypeInfoPropertyName = "ScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteDatasetItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateDatasetItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedDatasetItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateDatasetRunItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedDatasetRunItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedDatasetRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.DatasetRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteDatasetRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.HealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEvent), TypeInfoPropertyName = "IngestionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant12TraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant1Type), TypeInfoPropertyName = "IngestionEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant22ScoreEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant2Type), TypeInfoPropertyName = "IngestionEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant32CreateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant3Type), TypeInfoPropertyName = "IngestionEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateSpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant42UpdateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant4Type), TypeInfoPropertyName = "IngestionEventVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateSpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant52CreateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant5Type), TypeInfoPropertyName = "IngestionEventVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant62UpdateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant6Type), TypeInfoPropertyName = "IngestionEventVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant72CreateEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant72))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant7Type), TypeInfoPropertyName = "IngestionEventVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEventEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant82SDKLogEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant82))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant8Type), TypeInfoPropertyName = "IngestionEventVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SDKLogEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant92CreateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant92))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant9Type), TypeInfoPropertyName = "IngestionEventVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateObservationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>), TypeInfoPropertyName = "AllOfIngestionEventVariant102UpdateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant102))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant10Type), TypeInfoPropertyName = "IngestionEventVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateObservationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationType), TypeInfoPropertyName = "ObservationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionUsage), TypeInfoPropertyName = "IngestionUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OpenAIUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OptionalObservationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEventBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateEventBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateSpanBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateSpanBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateGenerationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UsageDetails), TypeInfoPropertyName = "UsageDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateGenerationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SDKLogBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.IngestionSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.IngestionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OpenAICompletionUsageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int?>), TypeInfoPropertyName = "DictionaryStringInt32_System_Collections_Generic_Dictionary_string_int_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OpenAIResponseUsageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Observation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservationsViews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyCreateScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyCreateScoreSource), TypeInfoPropertyName = "LegacyCreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyCreateScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseTraceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataNumeric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataCategorical))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataCorrection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseData), TypeInfoPropertyName = "LegacyGetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>), TypeInfoPropertyName = "AllOfLegacyGetScoresResponseDataVariant12LegacyGetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant1DataType), TypeInfoPropertyName = "LegacyGetScoresResponseDataVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>), TypeInfoPropertyName = "AllOfLegacyGetScoresResponseDataVariant22LegacyGetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant2DataType), TypeInfoPropertyName = "LegacyGetScoresResponseDataVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>), TypeInfoPropertyName = "AllOfLegacyGetScoresResponseDataVariant32LegacyGetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant3DataType), TypeInfoPropertyName = "LegacyGetScoresResponseDataVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>), TypeInfoPropertyName = "AllOfLegacyGetScoresResponseDataVariant42LegacyGetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant4DataType), TypeInfoPropertyName = "LegacyGetScoresResponseDataVariant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>), TypeInfoPropertyName = "AllOfLegacyGetScoresResponseDataVariant52LegacyGetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponseDataVariant5DataType), TypeInfoPropertyName = "LegacyGetScoresResponseDataVariant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyGetScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.LegacyGetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedLlmConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpsertLlmConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAdapter), TypeInfoPropertyName = "LlmAdapter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteLlmConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PatchMediaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaUploadUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MediaContentType), TypeInfoPropertyName = "MediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaUploadUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MetricsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsV2Meta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelResourceSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelScopeSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OtelTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipRole), TypeInfoPropertyName = "MembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteMembershipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipDeletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OrganizationProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OrganizationProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OrganizationApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OrganizationApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Projects))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ProjectDeletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ApiKeyList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ApiKeySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ApiKeyDeletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptMetaListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptType), TypeInfoPropertyName = "PromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreatePromptRequest), TypeInfoPropertyName = "CreatePromptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageWithPlaceholders), TypeInfoPropertyName = "ChatMessageWithPlaceholders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptType), TypeInfoPropertyName = "CreateChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptType), TypeInfoPropertyName = "CreateTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Prompt), TypeInfoPropertyName = "Prompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>), TypeInfoPropertyName = "AllOfPromptVariant12ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant1Type), TypeInfoPropertyName = "PromptVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>), TypeInfoPropertyName = "AllOfPromptVariant22TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant2Type), TypeInfoPropertyName = "PromptVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BasePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageType), TypeInfoPropertyName = "ChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessageType), TypeInfoPropertyName = "PlaceholderMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ServiceProviderConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimFeatureSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BulkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.FilterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AuthenticationScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ResourceMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ResourceTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ResourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SchemaExtension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SchemasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SchemaResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimUsersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScimUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimEmail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UserMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EmptyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateScoreConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectObservation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubject), TypeInfoPropertyName = "ScoreSubject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>), TypeInfoPropertyName = "AllOfScoreSubjectVariant12ScoreSubjectTrace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant1Kind), TypeInfoPropertyName = "ScoreSubjectVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>), TypeInfoPropertyName = "AllOfScoreSubjectVariant22ScoreSubjectObservation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant2Kind), TypeInfoPropertyName = "ScoreSubjectVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>), TypeInfoPropertyName = "AllOfScoreSubjectVariant32ScoreSubjectSession2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant3Kind), TypeInfoPropertyName = "ScoreSubjectVariant3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>), TypeInfoPropertyName = "AllOfScoreSubjectVariant42ScoreSubjectExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectVariant4Kind), TypeInfoPropertyName = "ScoreSubjectVariant4Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3), TypeInfoPropertyName = "ScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>), TypeInfoPropertyName = "AllOfScoreV3Variant12NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant1DataType), TypeInfoPropertyName = "ScoreV3Variant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>), TypeInfoPropertyName = "AllOfScoreV3Variant22BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant2DataType), TypeInfoPropertyName = "ScoreV3Variant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>), TypeInfoPropertyName = "AllOfScoreV3Variant32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant3DataType), TypeInfoPropertyName = "ScoreV3Variant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>), TypeInfoPropertyName = "AllOfScoreV3Variant42TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant4DataType), TypeInfoPropertyName = "ScoreV3Variant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>), TypeInfoPropertyName = "AllOfScoreV3Variant52CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant5DataType), TypeInfoPropertyName = "ScoreV3Variant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Traces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Sort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorType), TypeInfoPropertyName = "UnstableEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage), TypeInfoPropertyName = "UnstableCodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorScope), TypeInfoPropertyName = "UnstableEvaluatorScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleTarget), TypeInfoPropertyName = "UnstableEvaluationRuleTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleStatus), TypeInfoPropertyName = "UnstableEvaluationRuleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleMappingSource), TypeInfoPropertyName = "UnstableEvaluationRuleMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDataType), TypeInfoPropertyName = "UnstableEvaluatorOutputDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputFieldDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinition), TypeInfoPropertyName = "UnstableEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstableEvaluatorOutputDefinitionVariant12UnstablePublicNumericEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType), TypeInfoPropertyName = "UnstableEvaluatorOutputDefinitionVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstableEvaluatorOutputDefinitionVariant22UnstablePublicBooleanEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType), TypeInfoPropertyName = "UnstableEvaluatorOutputDefinitionVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstableEvaluatorOutputDefinitionVariant32UnstablePublicCategoricalEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType), TypeInfoPropertyName = "UnstableEvaluatorOutputDefinitionVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicCategoricalEvaluatorOutputScoreDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinition), TypeInfoPropertyName = "UnstablePublicEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstablePublicEvaluatorOutputDefinitionVariant12UnstablePublicNumericEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType), TypeInfoPropertyName = "UnstablePublicEvaluatorOutputDefinitionVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstablePublicEvaluatorOutputDefinitionVariant22UnstablePublicBooleanEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType), TypeInfoPropertyName = "UnstablePublicEvaluatorOutputDefinitionVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>), TypeInfoPropertyName = "AllOfUnstablePublicEvaluatorOutputDefinitionVariant32UnstablePublicCategoricalEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType), TypeInfoPropertyName = "UnstablePublicEvaluatorOutputDefinitionVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleStringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleNumberFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleArrayOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleBooleanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator), TypeInfoPropertyName = "UnstableEvaluationRuleNullFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDateTimeEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableStringEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableNumberEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableStringOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableStringObjectEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableNumberObjectEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableBooleanEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableNullEvaluationRuleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilter), TypeInfoPropertyName = "UnstableEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant12UnstableDateTimeEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant22UnstableStringEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant32UnstableNumberEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant42UnstableStringOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant52UnstableCategoryOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant62UnstableArrayOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant72UnstableStringObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant72))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant82UnstableNumberObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant82))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant92UnstableBooleanEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant92))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>), TypeInfoPropertyName = "AllOfUnstableEvaluationRuleFilterVariant102UnstableNullEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant102))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type), TypeInfoPropertyName = "UnstableEvaluationRuleFilterVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode), TypeInfoPropertyName = "UnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleRequest), TypeInfoPropertyName = "UnstableCreateEvaluationRuleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteEvaluationRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType), TypeInfoPropertyName = "UnstableLlmAsJudgeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluator), TypeInfoPropertyName = "UnstableEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), TypeInfoPropertyName = "AllOfUnstableEvaluatorVariant12UnstableLlmAsJudgeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant1Type), TypeInfoPropertyName = "UnstableEvaluatorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), TypeInfoPropertyName = "AllOfUnstableEvaluatorVariant22UnstableCodeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant2Type), TypeInfoPropertyName = "UnstableEvaluatorVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluator))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Langfuse.JsonConverters.AnnotationQueueStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueObjectTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.AnnotationQueueObjectTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportModeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFieldGroupJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageExportFieldGroupNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageSyncStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.BlobStorageSyncStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreVariant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.PricingTierOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ModelUsageUnitJsonConverter),

            typeof(global::Langfuse.JsonConverters.ModelUsageUnitNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationLevelJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationLevelNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CommentObjectTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CommentObjectTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.DatasetStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.DatasetStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreConfigDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreConfigDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant3TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant3TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant4TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant4TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant5TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant5TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant6TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant6TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant7TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant7TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant8TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant8TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant9TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant9TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant10TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventVariant10TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ObservationTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyCreateScoreSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyCreateScoreSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.LlmAdapterJsonConverter),

            typeof(global::Langfuse.JsonConverters.LlmAdapterNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.MediaContentTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.MediaContentTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.MembershipRoleJsonConverter),

            typeof(global::Langfuse.JsonConverters.MembershipRoleNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.PlaceholderMessageTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.PlaceholderMessageTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateChatPromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateChatPromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateTextPromptTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateTextPromptTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant1KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant1KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant2KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant2KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant3KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant3KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant4KindJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant4KindNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1JsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateScoreValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.MapValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionUsageJsonConverter),

            typeof(global::Langfuse.JsonConverters.UsageDetailsJsonConverter),

            typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreSubjectJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV3JsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluationRuleRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableEvaluatorJsonConverter),

            typeof(global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant12, global::Langfuse.NumericScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant22, global::Langfuse.CategoricalScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant32, global::Langfuse.BooleanScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant42, global::Langfuse.TextScoreV1>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>),

            typeof(global::Langfuse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequest), TypeInfoPropertyName = "UnstableCreateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>), TypeInfoPropertyName = "AllOfUnstableCreateEvaluatorRequestVariant12UnstableCreateLlmAsJudgeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type), TypeInfoPropertyName = "UnstableCreateEvaluatorRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>), TypeInfoPropertyName = "AllOfUnstableCreateEvaluatorRequestVariant22UnstableCreateCodeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type), TypeInfoPropertyName = "UnstableCreateEvaluatorRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.IngestionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OpentelemetryExportTracesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ProjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ProjectsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ProjectsCreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVersionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScimCreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceDeleteMultipleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.AnnotationQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.AnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageExportFieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageIntegrationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ObservationsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ConfigCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRunItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Observation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.LegacyGetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.LlmConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ObservationV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OtelScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OtelAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OtelSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.MembershipResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OrganizationProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OrganizationApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ApiKeySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ChatMessageWithPlaceholders>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.AuthenticationScheme>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ResourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.SchemaExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.SchemaResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScimUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScimEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Langfuse.JsonConverters.AnnotationQueueStatusJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AnnotationQueueStatusNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AnnotationQueueObjectTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AnnotationQueueObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportModeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportSourceNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageSyncStatusJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.BlobStorageSyncStatusNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant4DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant4DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant5DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreVariant5DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ModelUsageUnitJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ModelUsageUnitNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ObservationLevelJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ObservationLevelNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CommentObjectTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CommentObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.DatasetStatusJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.DatasetStatusNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSourceJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreConfigDataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreConfigDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreDataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant1TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant2TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant3TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant4TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant4TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant5TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant5TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant6TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant6TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant7TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant7TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant8TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant8TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant9TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant9TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant10TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventVariant10TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ObservationTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ObservationTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyCreateScoreSourceJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyCreateScoreSourceNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant4DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant5DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LlmAdapterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LlmAdapterNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MediaContentTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MediaContentTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MembershipRoleJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MembershipRoleNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariant1TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariant2TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PlaceholderMessageTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PlaceholderMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateChatPromptTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateChatPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateTextPromptTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateTextPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant1KindJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant1KindNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant2KindJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant2KindNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant3KindJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant3KindNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant4KindJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectVariant4KindNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorScopeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateScoreValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MapValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionUsageJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UsageDetailsJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.LegacyGetScoresResponseDataJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluationRuleRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant12, global::Langfuse.NumericScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant22, global::Langfuse.CategoricalScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant32, global::Langfuse.BooleanScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1Variant42, global::Langfuse.TextScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}