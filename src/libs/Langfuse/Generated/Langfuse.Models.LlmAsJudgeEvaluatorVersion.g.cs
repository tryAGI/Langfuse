
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LlmAsJudgeEvaluatorVersion
    {
        /// <summary>
        /// Evaluator type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A list containing exactly one user chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage> Prompt { get; set; }

        /// <summary>
        /// Variables extracted from the prompt and available for evaluation-rule mappings.<br/>
        /// Every variable must be mapped exactly once when a rule provides an explicit mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variables { get; set; }

        /// <summary>
        /// Default variable mapping for this evaluator version, or `null` when no default is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? VariableMapping { get; set; }

        /// <summary>
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Flat evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Optional empty descriptions from legacy definitions are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDefinition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.PublicEvaluatorOutputDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.PublicEvaluatorOutputDefinition OutputDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeEvaluatorVersion" /> class.
        /// </summary>
        /// <param name="type">
        /// Evaluator type.
        /// </param>
        /// <param name="prompt">
        /// A list containing exactly one user chat message.
        /// </param>
        /// <param name="variables">
        /// Variables extracted from the prompt and available for evaluation-rule mappings.<br/>
        /// Every variable must be mapped exactly once when a rule provides an explicit mapping.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
        /// <param name="outputDefinition">
        /// Flat evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Optional empty descriptions from legacy definitions are omitted.
        /// </param>
        /// <param name="variableMapping">
        /// Default variable mapping for this evaluator version, or `null` when no default is configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmAsJudgeEvaluatorVersion(
            string type,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage> prompt,
            global::System.Collections.Generic.IList<string> variables,
            global::Langfuse.EvaluatorModelConfig modelConfig,
            global::Langfuse.PublicEvaluatorOutputDefinition outputDefinition,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingRead>? variableMapping)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.VariableMapping = variableMapping;
            this.ModelConfig = modelConfig ?? throw new global::System.ArgumentNullException(nameof(modelConfig));
            this.OutputDefinition = outputDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeEvaluatorVersion" /> class.
        /// </summary>
        public LlmAsJudgeEvaluatorVersion()
        {
        }

    }
}