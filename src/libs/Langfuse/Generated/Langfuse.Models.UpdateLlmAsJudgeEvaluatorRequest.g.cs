
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateLlmAsJudgeEvaluatorRequest
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
        /// A user prompt string shortcut, or an ordered list of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluatorChatPromptInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorChatPromptInput Prompt { get; set; }

        /// <summary>
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        public global::Langfuse.EvaluatorModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Complete replacement default variable mapping, or `null` when no default is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableMapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? VariableMapping { get; set; }

        /// <summary>
        /// Flat structured output definition used when creating or updating an evaluator.<br/>
        /// - `dataType` is required.<br/>
        /// - `scoreReasoningInstructions` and `scoreValueInstructions` are optional instructions.<br/>
        /// - `minValue` and `maxValue` apply only to `NUMERIC` outputs. If both are set, `minValue` must not exceed `maxValue`.<br/>
        /// - `categories` and `shouldAllowMultipleMatches` apply only to `CATEGORICAL` outputs.<br/>
        /// - Do not send `version`; that is an internal storage detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDefinition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluatorOutputDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorOutputDefinition OutputDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Evaluator type. The type of an existing evaluator cannot change.
        /// </param>
        /// <param name="prompt">
        /// A user prompt string shortcut, or an ordered list of chat messages.
        /// </param>
        /// <param name="outputDefinition">
        /// Flat structured output definition used when creating or updating an evaluator.<br/>
        /// - `dataType` is required.<br/>
        /// - `scoreReasoningInstructions` and `scoreValueInstructions` are optional instructions.<br/>
        /// - `minValue` and `maxValue` apply only to `NUMERIC` outputs. If both are set, `minValue` must not exceed `maxValue`.<br/>
        /// - `categories` and `shouldAllowMultipleMatches` apply only to `CATEGORICAL` outputs.<br/>
        /// - Do not send `version`; that is an internal storage detail.
        /// </param>
        /// <param name="name">
        /// New human-readable evaluator name.
        /// </param>
        /// <param name="description">
        /// New description. Set to `null` to clear it.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
        /// <param name="variableMapping">
        /// Complete replacement default variable mapping, or `null` when no default is configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLlmAsJudgeEvaluatorRequest(
            string type,
            global::Langfuse.EvaluatorChatPromptInput prompt,
            global::Langfuse.EvaluatorOutputDefinition outputDefinition,
            string? name,
            string? description,
            global::Langfuse.EvaluatorModelConfig? modelConfig,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? variableMapping)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Prompt = prompt;
            this.ModelConfig = modelConfig;
            this.VariableMapping = variableMapping;
            this.OutputDefinition = outputDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        public UpdateLlmAsJudgeEvaluatorRequest()
        {
        }

    }
}