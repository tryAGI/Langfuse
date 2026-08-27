
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableCreateLlmAsJudgeEvaluatorRequest
    {
        /// <summary>
        /// Evaluator name within the authenticated project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Prompt template used by the evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Structured output definition to send when creating an evaluator.<br/>
        /// Agent guidance:<br/>
        /// - `dataType` is required.<br/>
        /// - Do not send `version`; that is an internal storage detail and is not part of the public request contract.<br/>
        /// - For `NUMERIC` and `BOOLEAN`, provide `reasoning.description` and `score.description`.<br/>
        /// - For `NUMERIC`, `score.minValue` and `score.maxValue` optionally define inclusive bounds. If both are set, `minValue` must not exceed `maxValue`.<br/>
        /// - For `CATEGORICAL`, also provide `score.categories` and `score.shouldAllowMultipleMatches`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDefinition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorOutputDefinition OutputDefinition { get; set; }

        /// <summary>
        /// Optional explicit model configuration for an evaluator.<br/>
        /// If omitted, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
        /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
        /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
        /// Recovery guidance:<br/>
        /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        public global::Langfuse.UnstableEvaluatorModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Optional default variable mapping inherited by rule assignments that do not provide an override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Evaluator name within the authenticated project.
        /// </param>
        /// <param name="prompt">
        /// Prompt template used by the evaluator.
        /// </param>
        /// <param name="outputDefinition">
        /// Structured output definition to send when creating an evaluator.<br/>
        /// Agent guidance:<br/>
        /// - `dataType` is required.<br/>
        /// - Do not send `version`; that is an internal storage detail and is not part of the public request contract.<br/>
        /// - For `NUMERIC` and `BOOLEAN`, provide `reasoning.description` and `score.description`.<br/>
        /// - For `NUMERIC`, `score.minValue` and `score.maxValue` optionally define inclusive bounds. If both are set, `minValue` must not exceed `maxValue`.<br/>
        /// - For `CATEGORICAL`, also provide `score.categories` and `score.shouldAllowMultipleMatches`.
        /// </param>
        /// <param name="modelConfig">
        /// Optional explicit model configuration for an evaluator.<br/>
        /// If omitted, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
        /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
        /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
        /// Recovery guidance:<br/>
        /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
        /// </param>
        /// <param name="mapping">
        /// Optional default variable mapping inherited by rule assignments that do not provide an override.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateLlmAsJudgeEvaluatorRequest(
            string name,
            string prompt,
            global::Langfuse.UnstableEvaluatorOutputDefinition outputDefinition,
            global::Langfuse.UnstableEvaluatorModelConfig? modelConfig,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? mapping)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.OutputDefinition = outputDefinition;
            this.ModelConfig = modelConfig;
            this.Mapping = mapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateLlmAsJudgeEvaluatorRequest" /> class.
        /// </summary>
        public UnstableCreateLlmAsJudgeEvaluatorRequest()
        {
        }

    }
}