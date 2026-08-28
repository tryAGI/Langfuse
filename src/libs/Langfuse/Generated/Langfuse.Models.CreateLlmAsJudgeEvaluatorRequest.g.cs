
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateLlmAsJudgeEvaluatorRequest
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
        /// A user prompt string, or a list containing exactly one user chat message.
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
        /// Default prompt-variable mapping, or `null` when no default is configured.
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
        /// Initializes a new instance of the <see cref="CreateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="type">
        /// Evaluator type.
        /// </param>
        /// <param name="prompt">
        /// A user prompt string, or a list containing exactly one user chat message.
        /// </param>
        /// <param name="outputDefinition">
        /// Flat structured output definition used when creating or updating an evaluator.<br/>
        /// - `dataType` is required.<br/>
        /// - `scoreReasoningInstructions` and `scoreValueInstructions` are optional instructions.<br/>
        /// - `minValue` and `maxValue` apply only to `NUMERIC` outputs. If both are set, `minValue` must not exceed `maxValue`.<br/>
        /// - `categories` and `shouldAllowMultipleMatches` apply only to `CATEGORICAL` outputs.<br/>
        /// - Do not send `version`; that is an internal storage detail.
        /// </param>
        /// <param name="description">
        /// Optional human-readable evaluator description.
        /// </param>
        /// <param name="modelConfig">
        /// Explicit model configuration for an evaluator.<br/>
        /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
        /// </param>
        /// <param name="variableMapping">
        /// Default prompt-variable mapping, or `null` when no default is configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLlmAsJudgeEvaluatorRequest(
            string name,
            string type,
            global::Langfuse.EvaluatorChatPromptInput prompt,
            global::Langfuse.EvaluatorOutputDefinition outputDefinition,
            string? description,
            global::Langfuse.EvaluatorModelConfig? modelConfig,
            global::System.Collections.Generic.IList<global::Langfuse.PromptVariableMappingInput>? variableMapping)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Prompt = prompt;
            this.ModelConfig = modelConfig;
            this.VariableMapping = variableMapping;
            this.OutputDefinition = outputDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        public CreateLlmAsJudgeEvaluatorRequest()
        {
        }

    }
}