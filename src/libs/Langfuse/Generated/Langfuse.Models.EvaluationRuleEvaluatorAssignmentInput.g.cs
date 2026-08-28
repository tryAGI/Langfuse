
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationRuleEvaluatorAssignmentInput
    {
        /// <summary>
        /// Stable evaluator identifier. The rule automatically uses that evaluator's latest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluatorId { get; set; }

        /// <summary>
        /// Rule-specific prompt-variable mapping.<br/>
        /// Set to `null` or omit to inherit the evaluator's latest default mapping. Code evaluators use the fixed runtime mapping and should use `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleEvaluatorAssignmentInput" /> class.
        /// </summary>
        /// <param name="evaluatorId">
        /// Stable evaluator identifier. The rule automatically uses that evaluator's latest version.
        /// </param>
        /// <param name="variableMapping">
        /// Rule-specific prompt-variable mapping.<br/>
        /// Set to `null` or omit to inherit the evaluator's latest default mapping. Code evaluators use the fixed runtime mapping and should use `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRuleEvaluatorAssignmentInput(
            string evaluatorId,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? variableMapping)
        {
            this.EvaluatorId = evaluatorId ?? throw new global::System.ArgumentNullException(nameof(evaluatorId));
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleEvaluatorAssignmentInput" /> class.
        /// </summary>
        public EvaluationRuleEvaluatorAssignmentInput()
        {
        }

    }
}