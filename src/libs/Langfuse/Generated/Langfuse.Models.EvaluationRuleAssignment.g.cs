
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Evaluation-rule assignment associated with this evaluator.
    /// </summary>
    public sealed partial class EvaluationRuleAssignment
    {
        /// <summary>
        /// Stable identifier of the assigned evaluation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluationRuleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationRuleId { get; set; }

        /// <summary>
        /// Rule-specific variable mapping override. Omitted when the evaluator's latest default mapping is inherited. Legacy mappings use the explicit `legacy` variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMappingOverride")]
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? VariableMappingOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleAssignment" /> class.
        /// </summary>
        /// <param name="evaluationRuleId">
        /// Stable identifier of the assigned evaluation rule.
        /// </param>
        /// <param name="variableMappingOverride">
        /// Rule-specific variable mapping override. Omitted when the evaluator's latest default mapping is inherited. Legacy mappings use the explicit `legacy` variant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRuleAssignment(
            string evaluationRuleId,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? variableMappingOverride)
        {
            this.EvaluationRuleId = evaluationRuleId ?? throw new global::System.ArgumentNullException(nameof(evaluationRuleId));
            this.VariableMappingOverride = variableMappingOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleAssignment" /> class.
        /// </summary>
        public EvaluationRuleAssignment()
        {
        }

    }
}