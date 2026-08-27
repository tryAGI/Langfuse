
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableEvaluationRuleEvaluatorAssignment
    {
        /// <summary>
        /// Resolved evaluator currently used by the evaluation rule.<br/>
        /// `id` identifies the evaluator family. Evaluation runs automatically use<br/>
        /// the latest available evaluator version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleEvaluator Evaluator { get; set; }

        /// <summary>
        /// Rule-specific override, or `null` to inherit the evaluator version's default mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleReadMapping>? Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluatorAssignment" /> class.
        /// </summary>
        /// <param name="evaluator">
        /// Resolved evaluator currently used by the evaluation rule.<br/>
        /// `id` identifies the evaluator family. Evaluation runs automatically use<br/>
        /// the latest available evaluator version.
        /// </param>
        /// <param name="mapping">
        /// Rule-specific override, or `null` to inherit the evaluator version's default mapping.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRuleEvaluatorAssignment(
            global::Langfuse.UnstableEvaluationRuleEvaluator evaluator,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleReadMapping>? mapping)
        {
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Mapping = mapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluatorAssignment" /> class.
        /// </summary>
        public UnstableEvaluationRuleEvaluatorAssignment()
        {
        }

    }
}