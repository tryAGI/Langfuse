
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableCreateEvaluationRuleEvaluatorAssignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableCreateEvaluationRuleEvaluatorReference Evaluator { get; set; }

        /// <summary>
        /// Optional rule-specific override. Omit to inherit the evaluator version's default mapping. Omit for code evaluators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleEvaluatorAssignment" /> class.
        /// </summary>
        /// <param name="evaluator"></param>
        /// <param name="mapping">
        /// Optional rule-specific override. Omit to inherit the evaluator version's default mapping. Omit for code evaluators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateEvaluationRuleEvaluatorAssignment(
            global::Langfuse.UnstableCreateEvaluationRuleEvaluatorReference evaluator,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? mapping)
        {
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Mapping = mapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleEvaluatorAssignment" /> class.
        /// </summary>
        public UnstableCreateEvaluationRuleEvaluatorAssignment()
        {
        }

    }
}