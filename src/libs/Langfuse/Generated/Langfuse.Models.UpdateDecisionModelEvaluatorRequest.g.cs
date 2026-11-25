
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDecisionModelEvaluatorRequest
    {
        /// <summary>
        /// New human-readable evaluator name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description. Set to `null` to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Evaluator type. The type of an existing evaluator cannot change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Complete replacement list of typed questions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion> Questions { get; set; }

        /// <summary>
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Complete replacement mapping from observation data to state keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput> VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDecisionModelEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Evaluator type. The type of an existing evaluator cannot change.
        /// </param>
        /// <param name="questions">
        /// Complete replacement list of typed questions.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
        /// <param name="variableMapping">
        /// Complete replacement mapping from observation data to state keys.
        /// </param>
        /// <param name="name">
        /// New human-readable evaluator name.
        /// </param>
        /// <param name="description">
        /// New description. Set to `null` to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDecisionModelEvaluatorRequest(
            string type,
            global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion> questions,
            global::Langfuse.EvaluatorModelConfig modelConfig,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput> variableMapping,
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.ModelConfig = modelConfig ?? throw new global::System.ArgumentNullException(nameof(modelConfig));
            this.VariableMapping = variableMapping ?? throw new global::System.ArgumentNullException(nameof(variableMapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDecisionModelEvaluatorRequest" /> class.
        /// </summary>
        public UpdateDecisionModelEvaluatorRequest()
        {
        }

    }
}