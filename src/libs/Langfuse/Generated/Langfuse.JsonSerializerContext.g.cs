
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Score))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponseMeta))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectTraceV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectObservationV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectSessionV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectExperimentV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3), TypeInfoPropertyName = "ScoreSubjectV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3Variant12ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant1Kind), TypeInfoPropertyName = "ScoreSubjectV3Variant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3Variant22ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant2Kind), TypeInfoPropertyName = "ScoreSubjectV3Variant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3Variant32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant3Kind), TypeInfoPropertyName = "ScoreSubjectV3Variant3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3Variant42ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant4Kind), TypeInfoPropertyName = "ScoreSubjectV3Variant4Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScoreV3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>), TypeInfoPropertyName = "AllOfGetScoresResponseDataVariant12GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant1DataType), TypeInfoPropertyName = "GetScoresResponseDataVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>), TypeInfoPropertyName = "AllOfGetScoresResponseDataVariant22GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant2DataType), TypeInfoPropertyName = "GetScoresResponseDataVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>), TypeInfoPropertyName = "AllOfGetScoresResponseDataVariant32GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant3DataType), TypeInfoPropertyName = "GetScoresResponseDataVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>), TypeInfoPropertyName = "AllOfGetScoresResponseDataVariant42GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant4DataType), TypeInfoPropertyName = "GetScoresResponseDataVariant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>), TypeInfoPropertyName = "AllOfGetScoresResponseDataVariant52GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant5DataType), TypeInfoPropertyName = "GetScoresResponseDataVariant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.GetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Traces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Sort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorType), TypeInfoPropertyName = "UnstableEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage), TypeInfoPropertyName = "UnstableCodeEvaluatorSourceCodeLanguage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicNumericEvaluatorOutputScoreDefinition))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleReadMapping))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView), TypeInfoPropertyName = "UnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy), TypeInfoPropertyName = "UnstableDashboardWidgetViewWithLegacy2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementVariant12UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type), TypeInfoPropertyName = "UnstableDashboardPlacementVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementVariant22UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type), TypeInfoPropertyName = "UnstableDashboardPlacementVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePresetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestVariant12UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestVariant22UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleReadMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget), TypeInfoPropertyName = "UnstableLegacyEvaluationRuleTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleTimeScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleTimeScope), TypeInfoPropertyName = "UnstableEvaluationRuleTimeScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationRuleMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableReadableEvaluationRule), TypeInfoPropertyName = "UnstableReadableEvaluationRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableReadableEvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleRequest), TypeInfoPropertyName = "UnstableCreateEvaluationRuleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleWithEvaluatorsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateEvaluationRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteEvaluationRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType), TypeInfoPropertyName = "UnstableLlmAsJudgeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationObject), TypeInfoPropertyName = "UnstableLegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleEvaluatorReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluator), TypeInfoPropertyName = "UnstableEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), TypeInfoPropertyName = "AllOfUnstableEvaluatorVariant12UnstableLlmAsJudgeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant1Type), TypeInfoPropertyName = "UnstableEvaluatorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), TypeInfoPropertyName = "AllOfUnstableEvaluatorVariant22UnstableCodeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant2Type), TypeInfoPropertyName = "UnstableEvaluatorVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant12, global::Langfuse.NumericScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1Variant12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant1DataType?), TypeInfoPropertyName = "NullableScoreV1Variant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant22, global::Langfuse.CategoricalScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1Variant22CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant2DataType?), TypeInfoPropertyName = "NullableScoreV1Variant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant32, global::Langfuse.BooleanScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1Variant32BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant3DataType?), TypeInfoPropertyName = "NullableScoreV1Variant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1Variant42, global::Langfuse.TextScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1Variant42TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1Variant4DataType?), TypeInfoPropertyName = "NullableScoreV1Variant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?), TypeInfoPropertyName = "NullableAllOfScoreVariant12NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant1DataType?), TypeInfoPropertyName = "NullableScoreVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?), TypeInfoPropertyName = "NullableAllOfScoreVariant22CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant2DataType?), TypeInfoPropertyName = "NullableScoreVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?), TypeInfoPropertyName = "NullableAllOfScoreVariant32BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant3DataType?), TypeInfoPropertyName = "NullableScoreVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?), TypeInfoPropertyName = "NullableAllOfScoreVariant42CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant4DataType?), TypeInfoPropertyName = "NullableScoreVariant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?), TypeInfoPropertyName = "NullableAllOfScoreVariant52TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreVariant5DataType?), TypeInfoPropertyName = "NullableScoreVariant5DataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3?), TypeInfoPropertyName = "NullableScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.FeedbackTargetType?), TypeInfoPropertyName = "NullableFeedbackTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEvent?), TypeInfoPropertyName = "NullableIngestionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant12TraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant1Type?), TypeInfoPropertyName = "NullableIngestionEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant22ScoreEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant2Type?), TypeInfoPropertyName = "NullableIngestionEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant32CreateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant3Type?), TypeInfoPropertyName = "NullableIngestionEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant42UpdateSpanEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant4Type?), TypeInfoPropertyName = "NullableIngestionEventVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant52CreateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant5Type?), TypeInfoPropertyName = "NullableIngestionEventVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant62UpdateGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant6Type?), TypeInfoPropertyName = "NullableIngestionEventVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant72CreateEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant7Type?), TypeInfoPropertyName = "NullableIngestionEventVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant82SDKLogEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant8Type?), TypeInfoPropertyName = "NullableIngestionEventVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant92CreateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant9Type?), TypeInfoPropertyName = "NullableIngestionEventVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?), TypeInfoPropertyName = "NullableAllOfIngestionEventVariant102UpdateObservationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionEventVariant10Type?), TypeInfoPropertyName = "NullableIngestionEventVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationType?), TypeInfoPropertyName = "NullableObservationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.IngestionUsage?), TypeInfoPropertyName = "NullableIngestionUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UsageDetails?), TypeInfoPropertyName = "NullableUsageDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAdapter?), TypeInfoPropertyName = "NullableLlmAdapter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MediaContentType?), TypeInfoPropertyName = "NullableMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelTokenizerId?), TypeInfoPropertyName = "NullableModelTokenizerId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.MembershipRole?), TypeInfoPropertyName = "NullableMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptType?), TypeInfoPropertyName = "NullablePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreatePromptRequest?), TypeInfoPropertyName = "NullableCreatePromptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageWithPlaceholders?), TypeInfoPropertyName = "NullableChatMessageWithPlaceholders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptType?), TypeInfoPropertyName = "NullableCreateChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptType?), TypeInfoPropertyName = "NullableCreateTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Prompt?), TypeInfoPropertyName = "NullablePrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptVariant12ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant1Type?), TypeInfoPropertyName = "NullablePromptVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptVariant22TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptVariant2Type?), TypeInfoPropertyName = "NullablePromptVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageType?), TypeInfoPropertyName = "NullableChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessageType?), TypeInfoPropertyName = "NullablePlaceholderMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3?), TypeInfoPropertyName = "NullableScoreSubjectV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3Variant12ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant1Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3Variant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3Variant22ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant2Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3Variant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3Variant32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3Variant3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3Variant42ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3Variant4Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3Variant4Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3Variant12NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant1DataType?), TypeInfoPropertyName = "NullableScoreV3Variant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3Variant22BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant2DataType?), TypeInfoPropertyName = "NullableScoreV3Variant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3Variant32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant3DataType?), TypeInfoPropertyName = "NullableScoreV3Variant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3Variant42TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant4DataType?), TypeInfoPropertyName = "NullableScoreV3Variant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3Variant52CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3Variant5DataType?), TypeInfoPropertyName = "NullableScoreV3Variant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreSource?), TypeInfoPropertyName = "NullableCreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseData?), TypeInfoPropertyName = "NullableGetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataVariant12GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant1DataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataVariant22GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant2DataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataVariant32GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant3DataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataVariant42GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant4DataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataVariant4DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataVariant52GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataVariant5DataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataVariant5DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorType?), TypeInfoPropertyName = "NullableUnstableEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage?), TypeInfoPropertyName = "NullableUnstableCodeEvaluatorSourceCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleTarget?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleStatus?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleMappingSource?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleMappingSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDataType?), TypeInfoPropertyName = "NullableUnstableEvaluatorOutputDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinition?), TypeInfoPropertyName = "NullableUnstableEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluatorOutputDefinitionVariant12UnstablePublicNumericEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType?), TypeInfoPropertyName = "NullableUnstableEvaluatorOutputDefinitionVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluatorOutputDefinitionVariant22UnstablePublicBooleanEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType?), TypeInfoPropertyName = "NullableUnstableEvaluatorOutputDefinitionVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluatorOutputDefinitionVariant32UnstablePublicCategoricalEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType?), TypeInfoPropertyName = "NullableUnstableEvaluatorOutputDefinitionVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinition?), TypeInfoPropertyName = "NullableUnstablePublicEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstablePublicEvaluatorOutputDefinitionVariant12UnstablePublicNumericEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType?), TypeInfoPropertyName = "NullableUnstablePublicEvaluatorOutputDefinitionVariant1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstablePublicEvaluatorOutputDefinitionVariant22UnstablePublicBooleanEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType?), TypeInfoPropertyName = "NullableUnstablePublicEvaluatorOutputDefinitionVariant2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?), TypeInfoPropertyName = "NullableAllOfUnstablePublicEvaluatorOutputDefinitionVariant32UnstablePublicCategoricalEvaluatorOutputDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType?), TypeInfoPropertyName = "NullableUnstablePublicEvaluatorOutputDefinitionVariant3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleStringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleNumberFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleArrayOptionsFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleBooleanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleNullFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilter?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant12UnstableDateTimeEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant22UnstableStringEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant32UnstableNumberEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant42UnstableStringOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant52UnstableCategoryOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant62UnstableArrayOptionsEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant72UnstableStringObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant82UnstableNumberObjectEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant92UnstableBooleanEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluationRuleFilterVariant102UnstableNullEvaluationRuleFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleFilterVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetViewWithLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartType?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetMetricAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacement?), TypeInfoPropertyName = "NullableUnstableDashboardPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementVariant12UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementVariant22UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestVariant12UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestVariant22UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode?), TypeInfoPropertyName = "NullableUnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget?), TypeInfoPropertyName = "NullableUnstableLegacyEvaluationRuleTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluationRuleTimeScope?), TypeInfoPropertyName = "NullableUnstableEvaluationRuleTimeScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableReadableEvaluationRule?), TypeInfoPropertyName = "NullableUnstableReadableEvaluationRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluationRuleRequest?), TypeInfoPropertyName = "NullableUnstableCreateEvaluationRuleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType?), TypeInfoPropertyName = "NullableUnstableLlmAsJudgeEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableLegacyEvaluationObject?), TypeInfoPropertyName = "NullableUnstableLegacyEvaluationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluator?), TypeInfoPropertyName = "NullableUnstableEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluatorVariant12UnstableLlmAsJudgeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant1Type?), TypeInfoPropertyName = "NullableUnstableEvaluatorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?), TypeInfoPropertyName = "NullableAllOfUnstableEvaluatorVariant22UnstableCodeEvaluator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableEvaluatorVariant2Type?), TypeInfoPropertyName = "NullableUnstableEvaluatorVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequest?), TypeInfoPropertyName = "NullableUnstableCreateEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateEvaluatorRequestVariant12UnstableCreateLlmAsJudgeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type?), TypeInfoPropertyName = "NullableUnstableCreateEvaluatorRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateEvaluatorRequestVariant22UnstableCreateCodeEvaluatorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type?), TypeInfoPropertyName = "NullableUnstableCreateEvaluatorRequestVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetItemMediaReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRunItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierConditionInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.DatasetRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionSuccess>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleReadMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleTimeScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableLegacyEvaluationRuleMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableReadableEvaluationRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleMapping>))]
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateScoreValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionInputJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.MapValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionEventJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.IngestionUsageJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UsageDetailsJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.GetScoresResponseDataJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableDashboardPlacementJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableReadableEvaluationRuleJsonConverter());
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
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>());
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
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

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

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant2DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant4DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1Variant4DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant2DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant4DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant4DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant5DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreVariant5DataType?)

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

                    || typeToConvert == typeof(global::Langfuse.FeedbackTargetType)

                    || typeToConvert == typeof(global::Langfuse.FeedbackTargetType?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant2Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant3Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant3Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant4Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant4Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant5Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant5Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant6Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant6Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant7Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant7Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant8Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant8Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant9Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant9Type?)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant10Type)

                    || typeToConvert == typeof(global::Langfuse.IngestionEventVariant10Type?)

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

                    || typeToConvert == typeof(global::Langfuse.PromptVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.PromptVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.PromptVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.PromptVariant2Type?)

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

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant1Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant1Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant2Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant2Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant4Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant4Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant2DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant4DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant4DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant5DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3Variant5DataType?)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant1DataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant2DataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant3DataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant4DataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant4DataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant5DataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant5DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorType)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage)

                    || typeToConvert == typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTarget)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTarget?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStatus)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStatus?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleMappingSource)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleMappingSource?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDataType)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type?)

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

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?)

                    || typeToConvert == typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType)

                    || typeToConvert == typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTimeScope)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTimeScope?)

                    || typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget)

                    || typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget?)

                    || typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationObject)

                    || typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationObject?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant2Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type?);
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

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant2DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant4DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1Variant4DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1Variant4DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant2DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant4DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant4DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant4DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant4DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant5DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant5DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreVariant5DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreVariant5DataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Langfuse.FeedbackTargetType))
                {
                    return new global::Langfuse.JsonConverters.FeedbackTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.FeedbackTargetType?))
                {
                    return new global::Langfuse.JsonConverters.FeedbackTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant3Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant3Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant4Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant4Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant5Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant5Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant6Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant6Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant7Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant7Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant8Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant8Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant9Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant9Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant10Type))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.IngestionEventVariant10Type?))
                {
                    return new global::Langfuse.JsonConverters.IngestionEventVariant10TypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Langfuse.PromptVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.PromptVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.PromptVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.PromptVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.PromptVariant2TypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant1Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant1Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant2Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant2Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant4Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant4KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3Variant4Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3Variant4KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant2DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant4DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant4DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant4DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant5DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3Variant5DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3Variant5DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant1DataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant2DataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant3DataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant4DataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant4DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant4DataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant4DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant5DataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant5DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataVariant5DataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataVariant5DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorType))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage))
                {
                    return new global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTarget))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTarget?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStatus))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStatus?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleMappingSource))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleMappingSource?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDataType))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorOutputDefinitionVariant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant1DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant2DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant3DataType?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleStringFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleStringFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNumberFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleOptionsFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleArrayOptionsFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleBooleanFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleNullFilterOperator?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant3Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant4Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant5Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant6Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant7Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant8Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant9Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleFilterVariant10Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleFilterVariant10TypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType))
                {
                    return new global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLlmAsJudgeEvaluatorType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTimeScope))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleTimeScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluationRuleTimeScope?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluationRuleTimeScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget))
                {
                    return new global::Langfuse.JsonConverters.UnstableLegacyEvaluationRuleTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationRuleTarget?))
                {
                    return new global::Langfuse.JsonConverters.UnstableLegacyEvaluationRuleTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationObject))
                {
                    return new global::Langfuse.JsonConverters.UnstableLegacyEvaluationObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableLegacyEvaluationObject?))
                {
                    return new global::Langfuse.JsonConverters.UnstableLegacyEvaluationObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableEvaluatorVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableEvaluatorVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant1Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateEvaluatorRequestVariant2Type?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateEvaluatorRequestVariant2TypeNullableJsonConverter();
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