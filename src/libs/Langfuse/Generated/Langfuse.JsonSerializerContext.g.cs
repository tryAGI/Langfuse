
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

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant1DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant1DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant2DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant2DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant3DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant3DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant4DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant4DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant5DataTypeJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataVariant5DataTypeNullableJsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreV1JsonConverter),

            typeof(global::Langfuse.JsonConverters.ScoreJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreateScoreValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.MapValueJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionEventJsonConverter),

            typeof(global::Langfuse.JsonConverters.IngestionUsageJsonConverter),

            typeof(global::Langfuse.JsonConverters.UsageDetailsJsonConverter),

            typeof(global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter),

            typeof(global::Langfuse.JsonConverters.PromptJsonConverter),

            typeof(global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter),

            typeof(global::Langfuse.JsonConverters.GetScoresResponseDataJsonConverter),

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

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant12, global::Langfuse.ChatPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptVariant22, global::Langfuse.TextPrompt>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>),

            typeof(global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateBlobStorageIntegrationRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int?>), TypeInfoPropertyName = "DictionaryStringInt32_System_Collections_Generic_Dictionary_string_int")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.OpenAIResponseUsageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Observation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyObservationsViews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyCreateScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LegacyCreateScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedLlmConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UpsertLlmConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.LlmAdapter), TypeInfoPropertyName = "LlmAdapter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.IngestionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}