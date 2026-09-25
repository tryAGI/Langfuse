
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueStatus), TypeInfoPropertyName = "AnnotationQueueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueObjectType), TypeInfoPropertyName = "AnnotationQueueObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse), TypeInfoPropertyName = "BlobStorageIntegrationFileTypeResponse2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Deprecation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsViewSingle))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>), TypeInfoPropertyName = "AllOfScoreV1NumericScoreV12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV1DataType), TypeInfoPropertyName = "ScoreV1NumericScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>), TypeInfoPropertyName = "AllOfScoreV1CategoricalScoreV12CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType), TypeInfoPropertyName = "ScoreV1CategoricalScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>), TypeInfoPropertyName = "AllOfScoreV1BooleanScoreV12BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType), TypeInfoPropertyName = "ScoreV1BooleanScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>), TypeInfoPropertyName = "AllOfScoreV1TextScoreV12TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV1DataType), TypeInfoPropertyName = "ScoreV1TextScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Score))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>), TypeInfoPropertyName = "AllOfScoreNumericScore2NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScoreDataType), TypeInfoPropertyName = "ScoreNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>), TypeInfoPropertyName = "AllOfScoreCategoricalScore2CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScoreDataType), TypeInfoPropertyName = "ScoreCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>), TypeInfoPropertyName = "AllOfScoreBooleanScore2BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScoreDataType), TypeInfoPropertyName = "ScoreBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>), TypeInfoPropertyName = "AllOfScoreCorrectionScore2CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScoreDataType), TypeInfoPropertyName = "ScoreCorrectionScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>), TypeInfoPropertyName = "AllOfScoreTextScore2TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScoreDataType), TypeInfoPropertyName = "ScoreTextScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreValue), TypeInfoPropertyName = "CreateScoreValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CommentObjectType), TypeInfoPropertyName = "CommentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetStatus), TypeInfoPropertyName = "DatasetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.DatasetItemMediaReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItemMediaReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItemMediaReferenceField), TypeInfoPropertyName = "DatasetItemMediaReferenceField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItemMediaReferenceMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierCondition), TypeInfoPropertyName = "PricingTierCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierUsageCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierOperator), TypeInfoPropertyName = "PricingTierOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeSource), TypeInfoPropertyName = "PricingTierAttributeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierConditionInput), TypeInfoPropertyName = "PricingTierConditionInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierUsageConditionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierConditionInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MapValue), TypeInfoPropertyName = "MapValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorType), TypeInfoPropertyName = "EvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage), TypeInfoPropertyName = "CodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource), TypeInfoPropertyName = "PromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputScoreType), TypeInfoPropertyName = "EvaluatorOutputScoreType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeletedEvaluationRule))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CursorMeta), TypeInfoPropertyName = "CursorMeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsCursorMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeletedEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponseMeta), TypeInfoPropertyName = "ExperimentsResponseMeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3), TypeInfoPropertyName = "ScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.FeedbackTargetType), TypeInfoPropertyName = "FeedbackTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SubmitFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.SubmitFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.HealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEvent), TypeInfoPropertyName = "IngestionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>), TypeInfoPropertyName = "AllOfIngestionEventTraceEvent2TraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventTraceEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventTraceEventType), TypeInfoPropertyName = "IngestionEventTraceEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>), TypeInfoPropertyName = "AllOfIngestionEventScoreEvent2ScoreEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventScoreEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventScoreEventType), TypeInfoPropertyName = "IngestionEventScoreEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>), TypeInfoPropertyName = "AllOfIngestionEventCreateSpanEvent2CreateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateSpanEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateSpanEventType), TypeInfoPropertyName = "IngestionEventCreateSpanEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateSpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>), TypeInfoPropertyName = "AllOfIngestionEventUpdateSpanEvent2UpdateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateSpanEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateSpanEventType), TypeInfoPropertyName = "IngestionEventUpdateSpanEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateSpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>), TypeInfoPropertyName = "AllOfIngestionEventCreateGenerationEvent2CreateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateGenerationEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateGenerationEventType), TypeInfoPropertyName = "IngestionEventCreateGenerationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>), TypeInfoPropertyName = "AllOfIngestionEventUpdateGenerationEvent2UpdateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateGenerationEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateGenerationEventType), TypeInfoPropertyName = "IngestionEventUpdateGenerationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>), TypeInfoPropertyName = "AllOfIngestionEventCreateEventEvent2CreateEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateEventEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateEventEventType), TypeInfoPropertyName = "IngestionEventCreateEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateEventEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>), TypeInfoPropertyName = "AllOfIngestionEventCreateObservationEvent2CreateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateObservationEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateObservationEventType), TypeInfoPropertyName = "IngestionEventCreateObservationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateObservationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>), TypeInfoPropertyName = "AllOfIngestionEventUpdateObservationEvent2UpdateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateObservationEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateObservationEventType), TypeInfoPropertyName = "IngestionEventUpdateObservationEventType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Langfuse.MapValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UsageDetails), TypeInfoPropertyName = "UsageDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpdateGenerationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Observation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservationsViews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedLlmConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpsertLlmConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAdapter), TypeInfoPropertyName = "LlmAdapter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteLlmConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PatchMediaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaUploadUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MediaContentType), TypeInfoPropertyName = "MediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetMediaUploadUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MetricsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelTokenizerId), TypeInfoPropertyName = "ModelTokenizerId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsV2Meta), TypeInfoPropertyName = "ObservationsV2Meta2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>), TypeInfoPropertyName = "AllOfPromptChatPrompt2ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPrompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPromptType), TypeInfoPropertyName = "PromptChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>), TypeInfoPropertyName = "AllOfPromptTextPrompt2TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPrompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPromptType), TypeInfoPropertyName = "PromptTextPromptType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectTraceV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectObservationV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectSessionV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectExperimentV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3), TypeInfoPropertyName = "ScoreSubjectV32")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectTraceV32ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectTraceV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectObservationV32ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectObservationV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectSessionV32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectSessionV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectExperimentV32ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectExperimentV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>), TypeInfoPropertyName = "AllOfScoreV3NumericScoreV32NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV3DataType), TypeInfoPropertyName = "ScoreV3NumericScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>), TypeInfoPropertyName = "AllOfScoreV3BooleanScoreV32BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType), TypeInfoPropertyName = "ScoreV3BooleanScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>), TypeInfoPropertyName = "AllOfScoreV3CategoricalScoreV32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType), TypeInfoPropertyName = "ScoreV3CategoricalScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>), TypeInfoPropertyName = "AllOfScoreV3TextScoreV32TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV3DataType), TypeInfoPropertyName = "ScoreV3TextScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>), TypeInfoPropertyName = "AllOfScoreV3CorrectionScoreV32CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType), TypeInfoPropertyName = "ScoreV3CorrectionScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresV3Meta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreSource), TypeInfoPropertyName = "CreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseTraceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataNumeric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataCategorical))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataCorrection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseData), TypeInfoPropertyName = "GetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataNumeric2GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataNumericDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataCategorical2GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataCategoricalDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataBoolean2GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataBooleanDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataCorrection2GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataCorrectionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataText2GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataTextDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.GetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Traces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Sort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView), TypeInfoPropertyName = "UnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy), TypeInfoPropertyName = "UnstableDashboardWidgetViewWithLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartType), TypeInfoPropertyName = "UnstableDashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation), TypeInfoPropertyName = "UnstableDashboardWidgetMetricAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetDefaultSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetSortOrder), TypeInfoPropertyName = "UnstableDashboardWidgetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardWidgetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardWidgetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardWidgetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacement), TypeInfoPropertyName = "UnstableDashboardPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementUnstableWidgetPlacement2UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType), TypeInfoPropertyName = "UnstableDashboardPlacementUnstableWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementUnstablePresetPlacement2UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType), TypeInfoPropertyName = "UnstableDashboardPlacementUnstablePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePresetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreatePresetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardPlacementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardPlacementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode), TypeInfoPropertyName = "UnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueStatus?), TypeInfoPropertyName = "NullableAnnotationQueueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AnnotationQueueObjectType?), TypeInfoPropertyName = "NullableAnnotationQueueObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationType?), TypeInfoPropertyName = "NullableBlobStorageIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileType?), TypeInfoPropertyName = "NullableBlobStorageIntegrationFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?), TypeInfoPropertyName = "NullableBlobStorageIntegrationFileTypeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportMode?), TypeInfoPropertyName = "NullableBlobStorageExportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFrequency?), TypeInfoPropertyName = "NullableBlobStorageExportFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportSource?), TypeInfoPropertyName = "NullableBlobStorageExportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFieldGroup?), TypeInfoPropertyName = "NullableBlobStorageExportFieldGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageSyncStatus?), TypeInfoPropertyName = "NullableBlobStorageSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1?), TypeInfoPropertyName = "NullableScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel?), TypeInfoPropertyName = "NullableObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreConfigDataType?), TypeInfoPropertyName = "NullableScoreConfigDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource?), TypeInfoPropertyName = "NullableScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1NumericScoreV12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1NumericScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1CategoricalScoreV12CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1CategoricalScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1BooleanScoreV12BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1BooleanScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1TextScoreV12TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1TextScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>?), TypeInfoPropertyName = "NullableAllOfScoreNumericScore2NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScoreDataType?), TypeInfoPropertyName = "NullableScoreNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>?), TypeInfoPropertyName = "NullableAllOfScoreCategoricalScore2CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScoreDataType?), TypeInfoPropertyName = "NullableScoreCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>?), TypeInfoPropertyName = "NullableAllOfScoreBooleanScore2BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScoreDataType?), TypeInfoPropertyName = "NullableScoreBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>?), TypeInfoPropertyName = "NullableAllOfScoreCorrectionScore2CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScoreDataType?), TypeInfoPropertyName = "NullableScoreCorrectionScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>?), TypeInfoPropertyName = "NullableAllOfScoreTextScore2TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScoreDataType?), TypeInfoPropertyName = "NullableScoreTextScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreValue?), TypeInfoPropertyName = "NullableCreateScoreValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CommentObjectType?), TypeInfoPropertyName = "NullableCommentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetStatus?), TypeInfoPropertyName = "NullableDatasetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DatasetItemMediaReferenceField?), TypeInfoPropertyName = "NullableDatasetItemMediaReferenceField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelUsageUnit?), TypeInfoPropertyName = "NullableModelUsageUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierCondition?), TypeInfoPropertyName = "NullablePricingTierCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierOperator?), TypeInfoPropertyName = "NullablePricingTierOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeSource?), TypeInfoPropertyName = "NullablePricingTierAttributeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierConditionInput?), TypeInfoPropertyName = "NullablePricingTierConditionInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MapValue?), TypeInfoPropertyName = "NullableMapValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreDataType?), TypeInfoPropertyName = "NullableScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorType?), TypeInfoPropertyName = "NullableEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage?), TypeInfoPropertyName = "NullableCodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariableMappingSource?), TypeInfoPropertyName = "NullablePromptVariableMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluatorOutputScoreType?), TypeInfoPropertyName = "NullableEvaluatorOutputScoreType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CursorMeta?), TypeInfoPropertyName = "NullableCursorMeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponseMeta?), TypeInfoPropertyName = "NullableExperimentsResponseMeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3?), TypeInfoPropertyName = "NullableScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.FeedbackTargetType?), TypeInfoPropertyName = "NullableFeedbackTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEvent?), TypeInfoPropertyName = "NullableIngestionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventTraceEvent2TraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventTraceEventType?), TypeInfoPropertyName = "NullableIngestionEventTraceEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventScoreEvent2ScoreEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventScoreEventType?), TypeInfoPropertyName = "NullableIngestionEventScoreEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventCreateSpanEvent2CreateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateSpanEventType?), TypeInfoPropertyName = "NullableIngestionEventCreateSpanEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventUpdateSpanEvent2UpdateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateSpanEventType?), TypeInfoPropertyName = "NullableIngestionEventUpdateSpanEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventCreateGenerationEvent2CreateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateGenerationEventType?), TypeInfoPropertyName = "NullableIngestionEventCreateGenerationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventUpdateGenerationEvent2UpdateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateGenerationEventType?), TypeInfoPropertyName = "NullableIngestionEventUpdateGenerationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventCreateEventEvent2CreateEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateEventEventType?), TypeInfoPropertyName = "NullableIngestionEventCreateEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventCreateObservationEvent2CreateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventCreateObservationEventType?), TypeInfoPropertyName = "NullableIngestionEventCreateObservationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventUpdateObservationEvent2UpdateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventUpdateObservationEventType?), TypeInfoPropertyName = "NullableIngestionEventUpdateObservationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationType?), TypeInfoPropertyName = "NullableObservationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionUsage?), TypeInfoPropertyName = "NullableIngestionUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UsageDetails?), TypeInfoPropertyName = "NullableUsageDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAdapter?), TypeInfoPropertyName = "NullableLlmAdapter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MediaContentType?), TypeInfoPropertyName = "NullableMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelTokenizerId?), TypeInfoPropertyName = "NullableModelTokenizerId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsV2Meta?), TypeInfoPropertyName = "NullableObservationsV2Meta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipRole?), TypeInfoPropertyName = "NullableMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptType?), TypeInfoPropertyName = "NullablePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreatePromptRequest?), TypeInfoPropertyName = "NullableCreatePromptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageWithPlaceholders?), TypeInfoPropertyName = "NullableChatMessageWithPlaceholders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptType?), TypeInfoPropertyName = "NullableCreateChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptType?), TypeInfoPropertyName = "NullableCreateTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Prompt?), TypeInfoPropertyName = "NullablePrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptChatPrompt2ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPromptType?), TypeInfoPropertyName = "NullablePromptChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptTextPrompt2TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPromptType?), TypeInfoPropertyName = "NullablePromptTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageType?), TypeInfoPropertyName = "NullableChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessageType?), TypeInfoPropertyName = "NullablePlaceholderMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3?), TypeInfoPropertyName = "NullableScoreSubjectV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectTraceV32ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectTraceV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectObservationV32ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectObservationV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectSessionV32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectSessionV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectExperimentV32ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectExperimentV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3NumericScoreV32NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3NumericScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3BooleanScoreV32BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3BooleanScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3CategoricalScoreV32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3CategoricalScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3TextScoreV32TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3TextScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3CorrectionScoreV32CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3CorrectionScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreSource?), TypeInfoPropertyName = "NullableCreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseData?), TypeInfoPropertyName = "NullableGetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataNumeric2GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataNumericDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataCategorical2GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataCategoricalDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataBoolean2GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataBooleanDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataCorrection2GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataCorrectionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataText2GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataTextDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetViewWithLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartType?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetMetricAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacement?), TypeInfoPropertyName = "NullableUnstableDashboardPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementUnstableWidgetPlacement2UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementUnstableWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementUnstablePresetPlacement2UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementUnstablePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode?), TypeInfoPropertyName = "NullableUnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.AnnotationQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.AnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageExportFieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageIntegrationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ObservationsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ConfigCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetItemMediaReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRunItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierConditionInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleReadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Evaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluatorVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Observation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.GetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>))]
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
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateScoreValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionInputJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MapValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptVariableMappingJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluationRuleFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluationRuleReadFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorChatPromptInputJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorVersionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluatorJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateEvaluatorRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UpdateEvaluatorRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CursorMetaJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ExperimentsResponseMetaJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionUsageJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UsageDetailsJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ObservationsV2MetaJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.GetScoresResponseDataJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableDashboardPlacementJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>());
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
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>());
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
                    typeToConvert == typeof(global::Langfuse.AnnotationQueueStatus)

                    || typeToConvert == typeof(global::Langfuse.AnnotationQueueStatus?)

                    || typeToConvert == typeof(global::Langfuse.AnnotationQueueObjectType)

                    || typeToConvert == typeof(global::Langfuse.AnnotationQueueObjectType?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportMode)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportMode?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportSource)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportSource?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.DatasetItemMediaReferenceField)

                    || typeToConvert == typeof(global::Langfuse.DatasetItemMediaReferenceField?)

                    || typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource)

                    || typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource?)

                    || typeToConvert == typeof(global::Langfuse.PricingTierOperator)

                    || typeToConvert == typeof(global::Langfuse.PricingTierOperator?)

                    || typeToConvert == typeof(global::Langfuse.ModelUsageUnit)

                    || typeToConvert == typeof(global::Langfuse.ModelUsageUnit?)

                    || typeToConvert == typeof(global::Langfuse.ObservationLevel)

                    || typeToConvert == typeof(global::Langfuse.ObservationLevel?)

                    || typeToConvert == typeof(global::Langfuse.CommentObjectType)

                    || typeToConvert == typeof(global::Langfuse.CommentObjectType?)

                    || typeToConvert == typeof(global::Langfuse.DatasetStatus)

                    || typeToConvert == typeof(global::Langfuse.DatasetStatus?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.ScoreConfigDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreConfigDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorType?)

                    || typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage)

                    || typeToConvert == typeof(global::Langfuse.CodeEvaluatorSourceCodeLanguage?)

                    || typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource)

                    || typeToConvert == typeof(global::Langfuse.PromptVariableMappingSource?)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputScoreType)

                    || typeToConvert == typeof(global::Langfuse.EvaluatorOutputScoreType?)

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

                    || typeToConvert == typeof(global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType?)

                    || typeToConvert == typeof(global::Langfuse.FeedbackTargetType)

                    || typeToConvert == typeof(global::Langfuse.FeedbackTargetType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventTraceEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventTraceEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventScoreEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventScoreEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateSpanEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateSpanEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateSpanEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateSpanEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateGenerationEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateGenerationEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateGenerationEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateGenerationEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateEventEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateEventEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateObservationEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventCreateObservationEventType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateObservationEventType)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventUpdateObservationEventType?)

                    || typeToConvert == typeof(global::Langfuse.ObservationType)

                    || typeToConvert == typeof(global::Langfuse.ObservationType?)

                    || typeToConvert == typeof(global::Langfuse.LlmAdapter)

                    || typeToConvert == typeof(global::Langfuse.LlmAdapter?)

                    || typeToConvert == typeof(global::Langfuse.MediaContentType)

                    || typeToConvert == typeof(global::Langfuse.MediaContentType?)

                    || typeToConvert == typeof(global::Langfuse.ModelTokenizerId)

                    || typeToConvert == typeof(global::Langfuse.ModelTokenizerId?)

                    || typeToConvert == typeof(global::Langfuse.MembershipRole)

                    || typeToConvert == typeof(global::Langfuse.MembershipRole?)

                    || typeToConvert == typeof(global::Langfuse.PromptChatPromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptChatPromptType?)

                    || typeToConvert == typeof(global::Langfuse.PromptTextPromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptTextPromptType?)

                    || typeToConvert == typeof(global::Langfuse.PromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptType?)

                    || typeToConvert == typeof(global::Langfuse.ChatMessageType)

                    || typeToConvert == typeof(global::Langfuse.ChatMessageType?)

                    || typeToConvert == typeof(global::Langfuse.PlaceholderMessageType)

                    || typeToConvert == typeof(global::Langfuse.PlaceholderMessageType?)

                    || typeToConvert == typeof(global::Langfuse.CreateChatPromptType)

                    || typeToConvert == typeof(global::Langfuse.CreateChatPromptType?)

                    || typeToConvert == typeof(global::Langfuse.CreateTextPromptType)

                    || typeToConvert == typeof(global::Langfuse.CreateTextPromptType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.AnnotationQueueStatus))
                {
                    return new global::Langfuse.JsonConverters.AnnotationQueueStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.AnnotationQueueStatus?))
                {
                    return new global::Langfuse.JsonConverters.AnnotationQueueStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.AnnotationQueueObjectType))
                {
                    return new global::Langfuse.JsonConverters.AnnotationQueueObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.AnnotationQueueObjectType?))
                {
                    return new global::Langfuse.JsonConverters.AnnotationQueueObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportMode))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportMode?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportSource))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportSource?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1NumericScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1NumericScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1CategoricalScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1CategoricalScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1BooleanScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1BooleanScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1TextScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1TextScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreNumericScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreNumericScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreCategoricalScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreCategoricalScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreBooleanScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreBooleanScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreCorrectionScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreCorrectionScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreTextScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreTextScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.DatasetItemMediaReferenceField))
                {
                    return new global::Langfuse.JsonConverters.DatasetItemMediaReferenceFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.DatasetItemMediaReferenceField?))
                {
                    return new global::Langfuse.JsonConverters.DatasetItemMediaReferenceFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource))
                {
                    return new global::Langfuse.JsonConverters.PricingTierAttributeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource?))
                {
                    return new global::Langfuse.JsonConverters.PricingTierAttributeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierOperator))
                {
                    return new global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierOperator?))
                {
                    return new global::Langfuse.JsonConverters.PricingTierOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelUsageUnit))
                {
                    return new global::Langfuse.JsonConverters.ModelUsageUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelUsageUnit?))
                {
                    return new global::Langfuse.JsonConverters.ModelUsageUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ObservationLevel))
                {
                    return new global::Langfuse.JsonConverters.ObservationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ObservationLevel?))
                {
                    return new global::Langfuse.JsonConverters.ObservationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CommentObjectType))
                {
                    return new global::Langfuse.JsonConverters.CommentObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CommentObjectType?))
                {
                    return new global::Langfuse.JsonConverters.CommentObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.DatasetStatus))
                {
                    return new global::Langfuse.JsonConverters.DatasetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.DatasetStatus?))
                {
                    return new global::Langfuse.JsonConverters.DatasetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreConfigDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreConfigDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreConfigDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreConfigDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputScoreType))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.EvaluatorOutputScoreType?))
                {
                    return new global::Langfuse.JsonConverters.EvaluatorOutputScoreTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Langfuse.FeedbackTargetType))
                {
                    return new global::Langfuse.JsonConverters.FeedbackTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.FeedbackTargetType?))
                {
                    return new global::Langfuse.JsonConverters.FeedbackTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventTraceEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventTraceEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventTraceEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventTraceEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventScoreEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventScoreEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventScoreEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventScoreEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateSpanEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateSpanEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateSpanEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateSpanEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateSpanEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateSpanEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateSpanEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateSpanEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateGenerationEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateGenerationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateGenerationEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateGenerationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateGenerationEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateGenerationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateGenerationEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateGenerationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateEventEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateEventEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateEventEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateEventEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateObservationEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateObservationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventCreateObservationEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventCreateObservationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateObservationEventType))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateObservationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventUpdateObservationEventType?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventUpdateObservationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ObservationType))
                {
                    return new global::Langfuse.JsonConverters.ObservationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ObservationType?))
                {
                    return new global::Langfuse.JsonConverters.ObservationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LlmAdapter))
                {
                    return new global::Langfuse.JsonConverters.LlmAdapterJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.LlmAdapter?))
                {
                    return new global::Langfuse.JsonConverters.LlmAdapterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.MediaContentType))
                {
                    return new global::Langfuse.JsonConverters.MediaContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.MediaContentType?))
                {
                    return new global::Langfuse.JsonConverters.MediaContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelTokenizerId))
                {
                    return new global::Langfuse.JsonConverters.ModelTokenizerIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelTokenizerId?))
                {
                    return new global::Langfuse.JsonConverters.ModelTokenizerIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.MembershipRole))
                {
                    return new global::Langfuse.JsonConverters.MembershipRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.MembershipRole?))
                {
                    return new global::Langfuse.JsonConverters.MembershipRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptChatPromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptChatPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptChatPromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptChatPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptTextPromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptTextPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptTextPromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptTextPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ChatMessageType))
                {
                    return new global::Langfuse.JsonConverters.ChatMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ChatMessageType?))
                {
                    return new global::Langfuse.JsonConverters.ChatMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PlaceholderMessageType))
                {
                    return new global::Langfuse.JsonConverters.PlaceholderMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PlaceholderMessageType?))
                {
                    return new global::Langfuse.JsonConverters.PlaceholderMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateChatPromptType))
                {
                    return new global::Langfuse.JsonConverters.CreateChatPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateChatPromptType?))
                {
                    return new global::Langfuse.JsonConverters.CreateChatPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateTextPromptType))
                {
                    return new global::Langfuse.JsonConverters.CreateTextPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateTextPromptType?))
                {
                    return new global::Langfuse.JsonConverters.CreateTextPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectTraceV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectTraceV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectObservationV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectObservationV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectSessionV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectSessionV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectExperimentV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectExperimentV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3NumericScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3NumericScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3BooleanScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3BooleanScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CategoricalScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CategoricalScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3TextScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3TextScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CorrectionScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CorrectionScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataNumericDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataNumericDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCategoricalDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCategoricalDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataBooleanDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataBooleanDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCorrectionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCorrectionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataTextDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataTextDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewWithLegacyJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewWithLegacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetMetricAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetMetricAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstableWidgetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstableWidgetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstablePresetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstablePresetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}