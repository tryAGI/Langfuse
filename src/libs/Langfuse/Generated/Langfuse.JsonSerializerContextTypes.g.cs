
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
        public global::Langfuse.EvaluationRuleNumberFilterOperator? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleOptionsFilterOperator? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleArrayOptionsFilterOperator? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleBooleanFilterOperator? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNullFilterOperator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DateTimeEvaluationRuleFilter? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringEvaluationRuleFilter? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberEvaluationRuleFilter? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringOptionsEvaluationRuleFilter? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ArrayOptionsEvaluationRuleFilter? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringObjectEvaluationRuleFilter? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberObjectEvaluationRuleFilter? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoryOptionsEvaluationRuleFilter? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanEvaluationRuleFilter? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NullEvaluationRuleFilter? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingInput? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingRead? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMapping? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyPromptVariableMapping? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyEvaluationObject? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilter? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterBase? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterWithKey? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilter? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorCode? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiValidationIssue? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorDetails? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleEvaluatorAssignmentInput? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorAssignment? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRule? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Creator? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluationRuleRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluationRuleRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRulesPage? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRule>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CursorMeta? Type251 { get; set; }
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
        public global::Langfuse.EvaluatorChatMessage? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatPromptInput? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionBase? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluatorVersion? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorVersion? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersion? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleAssignment? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorBase? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorStatus? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluator? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluator? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Evaluator? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluator2? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluator2? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateLlmAsJudgeEvaluatorRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCodeEvaluatorRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorsPage? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Evaluator>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionsPage? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluator? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Experiment>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Experiment? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponseMeta? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItemsResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItem? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FeedbackTargetType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackRequest? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.HealthResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEvent? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventTraceEvent2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventTraceEventType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceEvent? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventScoreEvent2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventScoreEventType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreEvent? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateSpanEvent2? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateSpanEventType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSpanEvent? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateSpanEvent2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateSpanEventType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSpanEvent? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateGenerationEvent2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateGenerationEventType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateGenerationEvent? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateGenerationEvent2? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateGenerationEventType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateGenerationEvent? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateEventEvent2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateEventEventType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEventEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventSDKLogEvent2? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventSDKLogEventType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SDKLogEvent? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateObservationEvent2? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventCreateObservationEventType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateObservationEvent? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateObservationEvent2? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionEventUpdateObservationEventType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateObservationEvent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionUsage? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIUsage? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OptionalObservationBody? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEventBody? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEventBody? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSpanBody? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSpanBody? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateGenerationBody? Type361 { get; set; }
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
        public global::Langfuse.SDKLogBody? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBody? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseEvent? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionSuccess? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionError? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionResponse? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionSuccess>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionError>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAICompletionUsageSchema? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIResponseUsageSchema? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyMetricsResponse? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyObservations? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Observation>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyObservationsViews? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmConnection? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedLlmConnections? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpsertLlmConnectionRequest? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAdapter? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteLlmConnectionResponse? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PatchMediaBody? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MediaContentType? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlResponse? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MetricsV2Response? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelTokenizerId? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedModels? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Model>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateModelRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Response? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Meta? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResourceSpan? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResource? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScopeSpan? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttribute? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScope? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelSpan? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttributeValue? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelTraceResponse? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRole? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteMembershipRequest? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipResponse? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipDeletionResponse? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipsResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProject? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProjectsResponse? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKey? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKeysResponse? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Projects? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Project>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Project? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Organization? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectDeletionResponse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyList? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeySummary? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyDeletionResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMetaListResponse? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMeta? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreatePromptRequest? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptRequest? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptRequest? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageWithPlaceholders? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Prompt? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPrompt2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPromptType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatPrompt? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPrompt2? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPromptType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextPrompt? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BasePrompt? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessage? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessage? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessageType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ServiceProviderConfig? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimFeatureSupport? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BulkConfig? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FilterConfig? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AuthenticationScheme? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceMeta? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceTypesResponse? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ResourceType>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaExtension? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemasResponse? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaResource? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUsersListResponse? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimUser>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUser? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimName? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimEmail? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UserMeta? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EmptyResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigs? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreConfigRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateScoreConfigRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectTraceV3? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectObservationV3? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectSessionV3? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectExperimentV3? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV3? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV3? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV3? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV3? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScoreV3? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV32? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV3DataType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV32? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV3DataType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV32? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV3DataType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV32? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV3DataType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV32? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV3DataType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Meta? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Response? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreSource? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreResponse? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseTraceData? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataNumeric? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataCategorical? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataBoolean? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataCorrection? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataText? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseData? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.GetScoresResponseData>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedSessions? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Session>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Traces? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteTraceResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Sort? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorType? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleTarget? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleStatus? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePromptVariableMappingSource? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorModelConfig? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDataType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputFieldDefinition? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinition? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicNumericEvaluatorOutputScoreDefinition? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicCategoricalEvaluatorOutputScoreDefinition? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinition? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleStringFilterOperator? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleNumberFilterOperator? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleArrayOptionsFilterOperator? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleBooleanFilterOperator? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleNullFilterOperator? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDateTimeEvaluationRuleFilter? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableStringEvaluationRuleFilter? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableNumberEvaluationRuleFilter? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableStringOptionsEvaluationRuleFilter? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableStringObjectEvaluationRuleFilter? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableNumberObjectEvaluationRuleFilter? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableBooleanEvaluationRuleFilter? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableNullEvaluationRuleFilter? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePromptVariableMappingInput? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePromptVariableMappingRead? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilter? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilterType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilterType? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilterType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetView? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetViewWithLegacy? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetricAggregation? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDimension? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetric? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetFilter? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfig? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetSortOrder? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardWidgetRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardWidgetRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetList? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidget? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardWidgetResponse? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacement? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableWidgetPlacement? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePresetPlacement? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequest? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateWidgetPlacement? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreatePresetPlacement? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardPlacementRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardPlacementResponse? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardDefinition? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboard? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardList? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorCode? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiValidationIssue? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorDetails? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiError? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleBase? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleEvaluator? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRule? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePromptVariableMappingRead>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableReadableV2EvaluationRule? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyEvaluationRule? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyEvaluationRuleTarget? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleTimeScope>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleTimeScope? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyPromptVariableMapping>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyPromptVariableMapping? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableReadableEvaluationRule? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRules? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableReadableEvaluationRule>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluationRuleRequest? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluationRuleWithEvaluatorsRequest? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLlmAsJudgeEvaluationRuleEvaluatorReference? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePromptVariableMappingInput>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCodeEvaluationRuleEvaluatorReference? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateEvaluationRuleRequest? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRuleEvaluatorReference? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteEvaluationRuleResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLlmAsJudgeEvaluatorType? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyEvaluationObject? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluationRuleEvaluatorReference? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteEvaluatorResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluator? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLlmAsJudgeEvaluator? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCodeEvaluator? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluatorBase? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluators? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluator>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluatorRequest? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateCodeEvaluatorRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.IngestionBatchRequest? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.IngestionEvent>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpentelemetryExportTracesRequest? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateRequest? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsUpdateRequest? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateApiKeyRequest? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVersionUpdateRequest? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimCreateUserRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceDeleteMultipleRequest? Type749 { get; set; }

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
        public global::System.Collections.Generic.List<global::Langfuse.GetScoresResponseData>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Session>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.TraceWithDetails>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleEvaluatorAssignment>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleFilter>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePromptVariableMappingRead>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluationRuleTimeScope>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableLegacyPromptVariableMapping>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableReadableEvaluationRule>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePromptVariableMappingInput>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableEvaluator>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.IngestionEvent>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>? ListType80 { get; set; }
    }
}