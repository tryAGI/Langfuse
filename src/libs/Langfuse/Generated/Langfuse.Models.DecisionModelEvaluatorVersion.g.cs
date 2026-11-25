
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionModelEvaluatorVersion
    {
        /// <summary>
        /// Evaluator type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Typed questions answered during evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion> Questions { get; set; }

        /// <summary>
        /// State keys available to the questions and evaluation-rule mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variables { get; set; }

        /// <summary>
        /// Default mapping from observation data to state keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead> VariableMapping { get; set; }

        /// <summary>
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelEvaluatorVersion" /> class.
        /// </summary>
        /// <param name="type">
        /// Evaluator type.
        /// </param>
        /// <param name="questions">
        /// Typed questions answered during evaluation.
        /// </param>
        /// <param name="variables">
        /// State keys available to the questions and evaluation-rule mappings.
        /// </param>
        /// <param name="variableMapping">
        /// Default mapping from observation data to state keys.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelEvaluatorVersion(
            string type,
            global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion> questions,
            global::System.Collections.Generic.IList<string> variables,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead> variableMapping,
            global::Langfuse.EvaluatorModelConfig modelConfig)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.VariableMapping = variableMapping ?? throw new global::System.ArgumentNullException(nameof(variableMapping));
            this.ModelConfig = modelConfig ?? throw new global::System.ArgumentNullException(nameof(modelConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelEvaluatorVersion" /> class.
        /// </summary>
        public DecisionModelEvaluatorVersion()
        {
        }

    }
}