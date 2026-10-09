
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AnnotationQueueStatus? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AnnotationQueueObjectType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AnnotationQueue? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AnnotationQueueItem? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedAnnotationQueues? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AnnotationQueue>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsMetaResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedAnnotationQueueItems? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AnnotationQueueItem>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateAnnotationQueueRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateAnnotationQueueItemRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateAnnotationQueueItemRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteAnnotationQueueItemResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AnnotationQueueAssignmentRequest? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteAnnotationQueueAssignmentResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateAnnotationQueueAssignmentResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationFileType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationFileTypeResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportMode? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportFrequency? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportSource? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportFieldGroup? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateBlobStorageIntegrationRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationsResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.BlobStorageIntegrationResponse>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageSyncStatus? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationStatusResponse? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationDeletionResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCommentRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCommentResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetCommentsResponse? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Comment>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Comment? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Deprecation? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Trace? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceWithDetails? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceWithFullDetails? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationsView>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsView? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV1>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Session? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SessionWithTraces? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Trace>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Observation? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Usage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationLevel? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsViewSingle? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationV2? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfig? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigDataType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ConfigCategory>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ConfigCategory? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV1? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSource? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV1? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV1? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV1? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV1? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1NumericScoreV12? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1NumericScoreV1DataType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1CategoricalScoreV12? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1CategoricalScoreV1DataType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1BooleanScoreV12? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1BooleanScoreV1DataType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1TextScoreV12? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV1TextScoreV1DataType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScore? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScore? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScore? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScore? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScore? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScore? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Score? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScore2? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScoreDataType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScore2? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScoreDataType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScore2? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScoreDataType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScore2? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScoreDataType? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScore2? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScoreDataType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreValue? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CommentObjectType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Dataset? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItem? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItemMediaReference>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReference? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceField? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceMedia? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetRunItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetRun? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetRunWithItems? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetRunItem>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Model? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelUsageUnit? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Langfuse.ModelPrice>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelPrice? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTier>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTier? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierCondition? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageCondition? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeCondition? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierOperator? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeSource? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierConditionInput? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageConditionInput? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierInput? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierConditionInput>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MapValue? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreDataType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteDatasetItemResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetItemRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasetItems? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItem>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetRunItemRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasetRunItems? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasets? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Dataset>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasetRuns? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetRun>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteDatasetRunResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorSourceCodeLanguage? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingSource? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputScoreType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinition? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorNumericScore? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorBooleanScore? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorCategoricalScore? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionBase? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinition? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringFilterOperator? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringObjectFilterOperator? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNumberFilterOperator? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleOptionsFilterOperator? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleArrayOptionsFilterOperator? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleBooleanFilterOperator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNullFilterOperator? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DateTimeEvaluationRuleFilter? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringEvaluationRuleFilter? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberEvaluationRuleFilter? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringOptionsEvaluationRuleFilter? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ArrayOptionsEvaluationRuleFilter? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringObjectEvaluationRuleFilter? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberObjectEvaluationRuleFilter? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoryOptionsEvaluationRuleFilter? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanEvaluationRuleFilter? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NullEvaluationRuleFilter? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingInput? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingRead? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMapping? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyPromptVariableMapping? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyEvaluationObject? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilter? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterBase? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterWithKey? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilter? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorCode? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiValidationIssue? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorDetails? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiError? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleEvaluatorAssignmentInput? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorAssignment? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRule? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Creator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluationRuleRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluationRuleRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRulesPage? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRule>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluationRule? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorModelConfig? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessageRole? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessage? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatPromptInput? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionBase? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluatorVersion? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorVersion? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersion? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleAssignment? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorBase? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorStatus? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluator? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluator? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Evaluator? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluator2? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluator2? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluatorType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateLlmAsJudgeEvaluatorRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCodeEvaluatorRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorsPage? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Evaluator>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionsPage? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CursorMeta? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsCursorMetaResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluator? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Experiment>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Experiment? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponseMeta? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItemsResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItem? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FeedbackTargetType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.HealthResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEvent? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventTraceEvent2? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventTraceEventType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceEvent? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventScoreEvent2? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventScoreEventType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreEvent? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateSpanEvent2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateSpanEventType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSpanEvent? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateSpanEvent2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateSpanEventType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSpanEvent? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateGenerationEvent2? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateGenerationEventType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateGenerationEvent? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateGenerationEvent2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateGenerationEventType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateGenerationEvent? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateEventEvent2? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateEventEventType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEventEvent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateObservationEvent2? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateObservationEventType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateObservationEvent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateObservationEvent2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateObservationEventType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateObservationEvent? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionUsage? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIUsage? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OptionalObservationBody? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEventBody? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEventBody? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSpanBody? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSpanBody? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateGenerationBody? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Langfuse.MapValue>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UsageDetails? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateGenerationBody? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationBody? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceBody? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBody? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseEvent? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionSuccess? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionError? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionSuccess>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionError>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAICompletionUsageSchema? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIResponseUsageSchema? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyMetricsResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyObservations? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Observation>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyObservationsViews? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmConnection? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedLlmConnections? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpsertLlmConnectionRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAdapter? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteLlmConnectionResponse? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaResponse? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PatchMediaBody? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MediaContentType? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MetricsV2Response? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelTokenizerId? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedModels? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Model>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateModelRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Response? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Meta? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResourceSpan? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResource? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScopeSpan? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttribute? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScope? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelSpan? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttributeValue? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelTraceResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRole? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteMembershipRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipDeletionResponse? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipsResponse? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProject? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProjectsResponse? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKey? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKeysResponse? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Projects? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Project>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Project? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Organization? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectDeletionResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyList? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeySummary? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyResponse? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyDeletionResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMetaListResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMeta? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreatePromptRequest? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptRequest? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptRequest? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageWithPlaceholders? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Prompt? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPrompt2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPromptType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatPrompt? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPrompt2? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPromptType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextPrompt? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BasePrompt? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessage? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessage? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessageType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ServiceProviderConfig? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimFeatureSupport? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BulkConfig? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FilterConfig? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AuthenticationScheme? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceMeta? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceTypesResponse? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ResourceType>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaExtension? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemasResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaResource? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUsersListResponse? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimUser>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUser? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimName? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimEmail? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UserMeta? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EmptyResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigs? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreConfigRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateScoreConfigRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectTraceV3? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectObservationV3? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectSessionV3? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectExperimentV3? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV3? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV3? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV3? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV3? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScoreV3? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV32? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV3DataType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV32? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV3DataType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV32? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV3DataType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV32? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV3DataType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV32? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV3DataType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Meta? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Response? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoresRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreSource? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoresResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResults? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResponse? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseTraceData? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataNumeric? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataCategorical? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataBoolean? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataCorrection? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataText? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseData? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.GetScoresResponseData>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchError? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedSessions? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Session>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Traces? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteTraceResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Sort? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetView? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetViewWithLegacy? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartType? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetricAggregation? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDimension? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetric? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetFilter? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfig? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetSortOrder? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardWidgetRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardWidgetRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetList? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidget? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardWidgetResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacement? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableWidgetPlacement? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePresetPlacement? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateWidgetPlacement? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreatePresetPlacement? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardPlacementRequest? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardPlacementResponse? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardDefinition? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboard? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardList? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardRequest? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardRequest? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorCode? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiValidationIssue? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorDetails? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiError? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMetaListResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillMeta>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMeta? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillListPagination? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileInput? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileReference? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileCreateInput? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateSkillVersionRequest? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFile? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContentsResponse? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFileContent>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContent? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersion? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFile>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillRequest? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillLabelsRequest? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteSkillVersionResponse? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionBatchRequest? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionEvent>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpentelemetryExportTracesRequest? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateRequest? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsUpdateRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateApiKeyRequest? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVersionUpdateRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimCreateUserRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceDeleteMultipleRequest? Type647 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.AnnotationQueue>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.AnnotationQueueItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.BlobStorageExportFieldGroup>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.BlobStorageIntegrationResponse>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Comment>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ObservationsView>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreV1>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Trace>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ConfigCategory>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetItemMediaReference>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetRunItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTier>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierConditionInput>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Dataset>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetRun>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PublicApiValidationIssue>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingInput>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMapping>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleReadFilter>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorAssignment>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleFilter>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRule>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorChatMessage>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingRead>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleAssignment>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Evaluator>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorVersion>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Experiment>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreV3>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.IngestionSuccess>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.IngestionError>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Observation>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.LlmConnection>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Model>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierInput>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ObservationV2>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelScopeSpan>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelAttribute>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelSpan>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.MembershipResponse>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationProject>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationApiKey>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Project>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ApiKeySummary>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptMeta>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ChatMessageWithPlaceholders>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.AuthenticationScheme>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ResourceType>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaExtension>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaResource>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimUser>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimEmail>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreConfig>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreRequest>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.GetScoresResponseData>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreBatchError>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Session>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.TraceWithDetails>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillMeta>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillVersionFileCreateInput>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFileContent>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFile>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.IngestionEvent>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>? ListType76 { get; set; }
    }
}