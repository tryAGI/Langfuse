
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Langfuse.BlobStorageIntegrationAuthType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationFileType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationFileTypeResponse? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportMode? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportFrequency? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportSource? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageExportFieldGroup? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateBlobStorageIntegrationRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationsResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.BlobStorageIntegrationResponse>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageSyncStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationStatusResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BlobStorageIntegrationDeletionResponse? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCommentRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCommentResponse? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetCommentsResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Comment>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Comment? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Deprecation? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationV2? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationLevel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Usage? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigDataType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ConfigCategory>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ConfigCategory? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScore? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSource? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScore? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScore? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScore? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScore? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScore? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Score? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScore2? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreNumericScoreDataType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScore2? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCategoricalScoreDataType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScore2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBooleanScoreDataType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScore2? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreCorrectionScoreDataType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScore2? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreTextScoreDataType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreValue? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CommentObjectType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Dataset? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItem? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetStatus? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItemMediaReference>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReference? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceField? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DatasetItemMediaReferenceMedia? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Model? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelUsageUnit? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Langfuse.ModelPrice>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelPrice? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTier>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTier? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierCondition? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageCondition? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeCondition? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierOperator? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeSource? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierConditionInput? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageConditionInput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierInput? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierConditionInput>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MapValue? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreDataType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIUsage? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteDatasetItemResponse? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetItemRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasetItems? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DatasetItem>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedDatasets? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Dataset>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDatasetRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorSourceCodeLanguage? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingSource? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputScoreType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinition? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorNumericScore? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorBooleanScore? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorCategoricalScore? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorOutputDefinitionBase? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinition? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringFilterOperator? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleStringObjectFilterOperator? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNumberFilterOperator? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleOptionsFilterOperator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleArrayOptionsFilterOperator? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleBooleanFilterOperator? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleNullFilterOperator? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DateTimeEvaluationRuleFilter? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringEvaluationRuleFilter? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberEvaluationRuleFilter? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringOptionsEvaluationRuleFilter? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ArrayOptionsEvaluationRuleFilter? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.StringObjectEvaluationRuleFilter? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumberObjectEvaluationRuleFilter? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoryOptionsEvaluationRuleFilter? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanEvaluationRuleFilter? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NullEvaluationRuleFilter? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingInput? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingRead? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMapping? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyPromptVariableMapping? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyEvaluationObject? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilter? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilterType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilterType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilterType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilterType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilterType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilterType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilterType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilterType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterBase? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterWithKey? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilter? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorCode? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiValidationIssue? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiErrorDetails? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PublicApiError? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleEvaluatorAssignmentInput? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorAssignment? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRule? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Creator? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluationRuleRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluationRuleRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRulesPage? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRule>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluationRule? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorModelConfig? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessageRole? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatMessage? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorChatPromptInput? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionBase? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluatorVersion? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluatorVersion? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelEntry? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelChoiceCriterion? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelScoreCriterion? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelBooleanCriteria? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelBooleanCriterion? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelChoiceQuestion? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DecisionModelChoiceCriterion>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelScoreQuestion? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DecisionModelScoreCriterion>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelBooleanQuestion? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestion? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestionType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestionType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelEvaluatorVersion? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersion? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersionType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleAssignment? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorBase? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorStatus? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluator? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluator? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DecisionModelEvaluator? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Evaluator? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluator2? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluator2? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluatorType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorDecisionModelEvaluator2, global::Langfuse.DecisionModelEvaluator>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorDecisionModelEvaluator2? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorDecisionModelEvaluatorType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateLlmAsJudgeEvaluatorRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCodeEvaluatorRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateDecisionModelEvaluatorRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequest? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateDecisionModelEvaluatorRequest2, global::Langfuse.CreateDecisionModelEvaluatorRequest>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateDecisionModelEvaluatorRequest2? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateDecisionModelEvaluatorRequest? Type292 { get; set; }
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
        public global::Langfuse.CursorMeta? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsCursorMetaResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluator? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Experiment>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Experiment? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponseMeta? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItemsResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItem? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FeedbackTargetType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.HealthResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmConnection? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedLlmConnections? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpsertLlmConnectionRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAdapter? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteLlmConnectionResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PatchMediaBody? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MediaContentType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlResponse? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MetricsV2Response? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelTokenizerId? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedModels? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Model>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateModelRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Response? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Meta? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResourceSpan? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResource? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScopeSpan? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttribute? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScope? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelSpan? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttributeValue? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelTraceResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRole? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRequest? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteMembershipRequest? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipDeletionResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipsResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProject? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProjectsResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKey? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKeysResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Projects? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Project>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Project? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Organization? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectDeletionResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyList? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeySummary? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyDeletionResponse? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMetaListResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMeta? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptType? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreatePromptRequest? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptRequest? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageWithPlaceholders? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptType? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Prompt? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPrompt2? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPromptType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatPrompt? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPrompt2? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPromptType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextPrompt? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BasePrompt? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessage? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessage? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageType? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessageType? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ServiceProviderConfig? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimFeatureSupport? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BulkConfig? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FilterConfig? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AuthenticationScheme? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceMeta? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceTypesResponse? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ResourceType>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceType? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaExtension? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemasResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaResource? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUsersListResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimUser>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUser? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimName? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimEmail? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UserMeta? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EmptyResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigs? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreConfigRequest? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateScoreConfigRequest? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreSource? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoresResponse? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResults? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResponse? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchError? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectTraceV3? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectObservationV3? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectSessionV3? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectExperimentV3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV3? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV3? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV3? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV3? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV3? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScoreV3? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV32? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV3DataType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV32? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV3DataType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV32? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV3DataType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV32? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV3DataType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV32? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV3DataType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Meta? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Response? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBody? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMetaListResponse? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillMeta>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMeta? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillListPagination? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileInput? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileReference? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileCreateInput? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSkillVersionRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillVersionFileCreateInput>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFile? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContentsResponse? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFileContent>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContent? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersion? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFile>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillLabelsRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteSkillVersionResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteTraceResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableBillableUnitsGranularity? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableBillableUnitsRow? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableBillableUnitsResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableBillableUnitsRow>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetView? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetViewWithLegacy? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetricAggregation? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDimension? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetric? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetFilter? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfig? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetSortOrder? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardWidgetRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardWidgetRequest? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetList? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidget? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardWidgetResponse? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacement? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableWidgetPlacement? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePresetPlacement? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequest? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateWidgetPlacement? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreatePresetPlacement? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardPlacementRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardPlacementResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardDefinition? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboard? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardList? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardResponse? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorCode? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiValidationIssue? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorDetails? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiError? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicResultsOrderBy? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicResultListMeta? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicRule? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicRuleList? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicRule>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummaryState? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummary? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummaryList? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicWindow? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicSummary>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentStatus? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentTopic? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignment? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentList? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicAssignment>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicsOrderBy? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetPublishedRun? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacet? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetList? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacet>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetRef? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopic? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicWithStatus? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicStatusCounts? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetCounts? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicList? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopic>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacetCounts>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMetaListResponse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillMeta>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMeta? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillListPagination? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFile>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFile? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateSkillVersionRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileCreateInput? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileInput? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileReference? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteSkillVersionResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillLabelsRequest? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContentsResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFileContent>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContent? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpentelemetryExportTracesRequest? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateRequest? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsUpdateRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateApiKeyRequest? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVersionUpdateRequest? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimCreateUserRequest? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceDeleteMultipleRequest? Type600 { get; set; }

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
        public global::System.Collections.Generic.List<global::Langfuse.DecisionModelChoiceCriterion>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DecisionModelScoreCriterion>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.DecisionModelQuestion>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleAssignment>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Evaluator>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.EvaluatorVersion>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Experiment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreV3>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.LlmConnection>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Model>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PricingTierInput>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ObservationV2>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelScopeSpan>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelAttribute>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelSpan>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.MembershipResponse>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationProject>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OrganizationApiKey>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.Project>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ApiKeySummary>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.PromptMeta>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ChatMessageWithPlaceholders>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.AuthenticationScheme>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ResourceType>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaExtension>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SchemaResource>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimUser>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScimEmail>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.ScoreConfig>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreRequest>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.CreateScoreBatchError>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillMeta>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillVersionFileCreateInput>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillFileContent>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.SkillFile>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableBillableUnitsRow>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicRule>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicSummary>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicAssignment>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacet>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopic>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacetCounts>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillMeta>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFile>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillVersionFileCreateInput>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFileContent>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>? ListType78 { get; set; }
    }
}