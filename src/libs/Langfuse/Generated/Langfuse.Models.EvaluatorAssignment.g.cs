
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorAssignment
    {
        /// <summary>
        /// Stable identifier of the evaluator associated with this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluatorId { get; set; }

        /// <summary>
        /// Stored rule-specific override, or `null` when the evaluator's latest default mapping is inherited. Legacy mappings are returned as an explicit `legacy` variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorAssignment" /> class.
        /// </summary>
        /// <param name="evaluatorId">
        /// Stable identifier of the evaluator associated with this rule.
        /// </param>
        /// <param name="variableMapping">
        /// Stored rule-specific override, or `null` when the evaluator's latest default mapping is inherited. Legacy mappings are returned as an explicit `legacy` variant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorAssignment(
            string evaluatorId,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMapping>? variableMapping)
        {
            this.EvaluatorId = evaluatorId ?? throw new global::System.ArgumentNullException(nameof(evaluatorId));
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorAssignment" /> class.
        /// </summary>
        public EvaluatorAssignment()
        {
        }

    }
}