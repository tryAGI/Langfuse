
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
        public global::Langfuse.ObservationV2? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationLevel? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Usage? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigDataType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ConfigCategory>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ConfigCategory? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScore? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSource? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScore? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScore? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScore? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScore? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScore? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Score? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScore2? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScoreDataType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScore2? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScoreDataType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScore2? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScoreDataType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScore2? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScoreDataType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScore2? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScoreDataType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreValue? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CommentObjectType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Dataset? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItem? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetStatus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItemMediaReference>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReference? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceField? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceMedia? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Model? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelUsageUnit? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Langfuse.ModelPrice>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelPrice? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTier>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTier? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierCondition? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageCondition? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeCondition? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierOperator? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeSource? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierConditionInput? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageConditionInput? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierInput? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierConditionInput>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MapValue? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreDataType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIUsage? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteDatasetItemResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetItemRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasetItems? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItem>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasets? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Dataset>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorSourceCodeLanguage? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingSource? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputScoreType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinition? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorNumericScore? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorBooleanScore? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorCategoricalScore? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionBase? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinition? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringFilterOperator? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringObjectFilterOperator? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNumberFilterOperator? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleOptionsFilterOperator? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleArrayOptionsFilterOperator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleBooleanFilterOperator? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNullFilterOperator? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DateTimeEvaluationRuleFilter? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringEvaluationRuleFilter? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberEvaluationRuleFilter? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringOptionsEvaluationRuleFilter? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ArrayOptionsEvaluationRuleFilter? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringObjectEvaluationRuleFilter? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberObjectEvaluationRuleFilter? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoryOptionsEvaluationRuleFilter? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanEvaluationRuleFilter? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NullEvaluationRuleFilter? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingInput? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingRead? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMapping? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyPromptVariableMapping? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyEvaluationObject? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilter? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterBase? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterWithKey? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilter? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorCode? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiValidationIssue? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorDetails? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiError? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleEvaluatorAssignmentInput? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorAssignment? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRule? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Creator? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluationRuleRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluationRuleRequest? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRulesPage? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRule>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluationRule? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorModelConfig? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessageRole? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessage? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatPromptInput? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionBase? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluatorVersion? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorVersion? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersion? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleAssignment? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorBase? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorStatus? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Evaluator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluator2? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluator2? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateLlmAsJudgeEvaluatorRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCodeEvaluatorRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorsPage? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Evaluator>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionsPage? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CursorMeta? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsCursorMetaResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluator? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Experiment>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Experiment? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponseMeta? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItemsResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItem? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FeedbackTargetType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.HealthResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmConnection? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedLlmConnections? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpsertLlmConnectionRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAdapter? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteLlmConnectionResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PatchMediaBody? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MediaContentType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MetricsV2Response? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelTokenizerId? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedModels? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Model>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateModelRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Response? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Meta? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResourceSpan? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResource? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScopeSpan? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttribute? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScope? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelSpan? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttributeValue? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelTraceResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRole? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteMembershipRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipDeletionResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipsResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProject? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProjectsResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKey? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKeysResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Projects? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Project>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Project? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Organization? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectDeletionResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyList? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeySummary? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyDeletionResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMetaListResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMeta? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreatePromptRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptRequest? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageWithPlaceholders? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Prompt? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPrompt2? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPromptType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatPrompt? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPrompt2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPromptType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextPrompt? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BasePrompt? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessage? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessage? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessageType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ServiceProviderConfig? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimFeatureSupport? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BulkConfig? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FilterConfig? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AuthenticationScheme? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceMeta? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceTypesResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ResourceType>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaExtension? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemasResponse? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaResource? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUsersListResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimUser>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUser? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimName? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimEmail? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UserMeta? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EmptyResponse? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigs? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreConfigRequest? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateScoreConfigRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreSource? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoresResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResults? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResponse? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchError? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectTraceV3? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectObservationV3? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectSessionV3? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectExperimentV3? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV3? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV3? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV3? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV3? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScoreV3? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV32? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV3DataType? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV32? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV3DataType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV32? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV3DataType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV32? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV3DataType? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV32? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV3DataType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Meta? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Response? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBody? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMetaListResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillMeta>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMeta? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillListPagination? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileInput? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileReference? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileCreateInput? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSkillVersionRequest? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillVersionFileCreateInput>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFile? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContentsResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFileContent>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContent? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersion? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFile>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillLabelsRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteSkillVersionResponse? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteTraceResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetView? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetViewWithLegacy? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetricAggregation? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDimension? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetric? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetFilter? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfig? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetSortOrder? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardWidgetRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardWidgetRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetList? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidget? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardWidgetResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacement? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableWidgetPlacement? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePresetPlacement? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateWidgetPlacement? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreatePresetPlacement? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardPlacementRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardPlacementResponse? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardDefinition? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboard? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardList? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardResponse? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorCode? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiValidationIssue? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorDetails? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiError? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMetaListResponse? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillMeta>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMeta? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillListPagination? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersion? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFile>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFile? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateSkillVersionRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileCreateInput? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileInput? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileReference? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillRequest? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteSkillVersionResponse? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillLabelsRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContentsResponse? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFileContent>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpentelemetryExportTracesRequest? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsUpdateRequest? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateApiKeyRequest? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVersionUpdateRequest? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimCreateUserRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceDeleteMultipleRequest? Type533 { get; set; }

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
        public global::System.Collections.Generic.List<global::Langfuse.ConfigCategory>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetItemMediaReference>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTier>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierConditionInput>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DatasetItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Dataset>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PublicApiValidationIssue>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingInput>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMapping>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleReadFilter>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorAssignment>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleFilter>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRule>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorChatMessage>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptVariableMappingRead>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleAssignment>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Evaluator>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorVersion>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Experiment>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreV3>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.LlmConnection>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Model>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierInput>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ObservationV2>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelScopeSpan>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelAttribute>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelSpan>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.MembershipResponse>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationProject>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationApiKey>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Project>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ApiKeySummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptMeta>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ChatMessageWithPlaceholders>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.AuthenticationScheme>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ResourceType>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaExtension>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaResource>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimUser>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimEmail>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreConfig>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreRequest>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreBatchError>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillMeta>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillVersionFileCreateInput>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillFileContent>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillFile>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillMeta>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFile>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillVersionFileCreateInput>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFileContent>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>? ListType68 { get; set; }
    }
}