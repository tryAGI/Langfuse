
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDecisionModelEvaluatorRequest
    {
        /// <summary>
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional human-readable evaluator description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Evaluator type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Between 1 and 50 typed questions. Question ids and score names must be unique.
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
        /// At least one mapping from observation data to a state key. Each `variable` is a state key that starts with a letter or underscore and contains only letters, digits, and underscores.
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
        /// Initializes a new instance of the <see cref="CreateDecisionModelEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="type">
        /// Evaluator type.
        /// </param>
        /// <param name="questions">
        /// Between 1 and 50 typed questions. Question ids and score names must be unique.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
        /// <param name="variableMapping">
        /// At least one mapping from observation data to a state key. Each `variable` is a state key that starts with a letter or underscore and contains only letters, digits, and underscores.
        /// </param>
        /// <param name="description">
        /// Optional human-readable evaluator description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDecisionModelEvaluatorRequest(
            string name,
            string type,
            global::System.Collections.Generic.IList<global::Langfuse.DecisionModelQuestion> questions,
            global::Langfuse.EvaluatorModelConfig modelConfig,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput> variableMapping,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.ModelConfig = modelConfig ?? throw new global::System.ArgumentNullException(nameof(modelConfig));
            this.VariableMapping = variableMapping ?? throw new global::System.ArgumentNullException(nameof(variableMapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionModelEvaluatorRequest" /> class.
        /// </summary>
        public CreateDecisionModelEvaluatorRequest()
        {
        }

    }
}