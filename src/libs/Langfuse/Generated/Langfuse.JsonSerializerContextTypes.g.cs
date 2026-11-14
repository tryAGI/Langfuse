
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
        public global::Langfuse.EvaluatorVersion? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionCodeEvaluatorVersionType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleAssignment? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorBase? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAsJudgeEvaluator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CodeEvaluator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Evaluator? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluator2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorLlmAsJudgeEvaluatorType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluator2? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorCodeEvaluatorType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateLlmAsJudgeEvaluatorRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateCodeEvaluatorRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequestType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorsPage? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Evaluator>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluatorVersionsPage? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CursorMeta? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsCursorMetaResponse? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeletedEvaluator? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Experiment>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Experiment? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentsResponseMeta? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItemsResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ExperimentItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FeedbackTargetType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SubmitFeedbackResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.HealthResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmConnection? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedLlmConnections? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.LlmConnection>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpsertLlmConnectionRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LlmAdapter? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteLlmConnectionResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PatchMediaBody? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MediaContentType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetMediaUploadUrlResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MetricsV2Response? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ModelTokenizerId? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PaginatedModels? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Model>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateModelRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Response? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ObservationV2>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ObservationsV2Meta? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResourceSpan? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelResource? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelScopeSpan>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScopeSpan? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelAttribute>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttribute? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelScope? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelSpan>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelSpan? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelAttributeValue? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OtelTraceResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRole? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteMembershipRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipDeletionResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.MembershipsResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.MembershipResponse>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProject? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationProjectsResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationProject>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKey? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OrganizationApiKeysResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OrganizationApiKey>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Projects? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.Project>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Project? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Organization? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectDeletionResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyList? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ApiKeySummary>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeySummary? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ApiKeyDeletionResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMetaListResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptMeta? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreatePromptRequest? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptRequest? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageWithPlaceholders? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateChatPromptType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateTextPromptType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.Prompt? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPrompt2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptChatPromptType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatPrompt? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPrompt2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptTextPromptType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextPrompt? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BasePrompt? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessage? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessage? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ChatMessageType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PlaceholderMessageType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ServiceProviderConfig? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimFeatureSupport? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BulkConfig? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.FilterConfig? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.AuthenticationScheme>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AuthenticationScheme? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceMeta? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceTypesResponse? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ResourceType>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ResourceType? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaExtension>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaExtension? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemasResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SchemaResource>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SchemaResource? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUsersListResponse? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimUser>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimUser? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimName? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimEmail? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UserMeta? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EmptyResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreConfigs? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreConfig>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreConfigRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateScoreConfigRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreSource? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoresResponse? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResults? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResponse? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchError? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectTraceV3? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectObservationV3? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectSessionV3? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectExperimentV3? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BaseScoreV3? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.NumericScoreV3? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.BooleanScoreV3? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CategoricalScoreV3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TextScoreV3? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CorrectionScoreV3? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV32? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3NumericScoreV3DataType? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV32? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3BooleanScoreV3DataType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV32? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CategoricalScoreV3DataType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV32? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3TextScoreV3DataType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV32? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreV3CorrectionScoreV3DataType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Meta? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.GetScoresV3Response? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScoreBody? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMetaListResponse? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillMeta>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillMeta? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillListPagination? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileInput? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileReference? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileCreateInput? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateSkillVersionRequest? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillVersionFileCreateInput>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFile? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContentsResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFileContent>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillFileContent? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersion? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.SkillFile>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateSkillLabelsRequest? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteSkillVersionResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.DeleteTraceResponse? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetView? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetViewWithLegacy? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetricAggregation? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDimension? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetMetric? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetFilter? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfig? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetSortOrder? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardWidgetRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardWidgetRequest? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidgetList? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardWidget? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardWidgetResponse? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacement? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableWidgetPlacement? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePresetPlacement? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateWidgetPlacement? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreatePresetPlacement? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardPlacementRequest? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardPlacementResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardDefinition? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboard? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDashboardList? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateDashboardRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateDashboardRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteDashboardResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorCode? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiValidationIssue? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiErrorDetails? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstablePublicApiError? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicResultsOrderBy? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicResultListMeta? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicRule? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicRuleList? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicRule>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummaryState? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummary? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicSummaryList? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicWindow? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicSummary>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentStatus? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentTopic? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignment? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicAssignmentList? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicAssignment>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicsOrderBy? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetPublishedRun? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacet? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetList? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacet>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetRef? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopic? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicWithStatus? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicStatusCounts? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicFacetCounts? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableTopicList? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopic>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacetCounts>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMetaListResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillMeta>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillMeta? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillListPagination? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersion? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFile>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFile? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableCreateSkillVersionRequest? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileCreateInput? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileInput? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileReference? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableDeleteSkillVersionResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableUpdateSkillLabelsRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContentsResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillFileContent>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillFileContent? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpentelemetryExportTracesRequest? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.OtelResourceSpan>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsUpdateRequest? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ProjectsCreateApiKeyRequest? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVersionUpdateRequest? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.ScimCreateUserRequest? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.TraceDeleteMultipleRequest? Type562 { get; set; }

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
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicRule>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicSummary>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicAssignment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacet>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopic>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacetCounts>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillMeta>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Langfuse.UnstableSkillFile>? ListType71 { get; set; }
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
        public global::System.Collections.Generic.List<global::Langfuse.OtelResourceSpan>? ListType74 { get; set; }
    }
}