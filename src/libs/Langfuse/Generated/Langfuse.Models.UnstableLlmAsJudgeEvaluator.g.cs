
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableLlmAsJudgeEvaluator
    {
        /// <summary>
        /// Prompt template used during evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Legacy stored evaluator definitions are normalized into this shape before they are returned.<br/>
        /// Use this response shape when deciding how to interpret future evaluation scores:<br/>
        /// - `NUMERIC`: expect numeric score values<br/>
        /// - `BOOLEAN`: expect `true` / `false`<br/>
        /// - `CATEGORICAL`: expect one or more values from `score.categories`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDefinition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePublicEvaluatorOutputDefinition OutputDefinition { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLlmAsJudgeEvaluator" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt template used during evaluation.
        /// </param>
        /// <param name="outputDefinition">
        /// Evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Legacy stored evaluator definitions are normalized into this shape before they are returned.<br/>
        /// Use this response shape when deciding how to interpret future evaluation scores:<br/>
        /// - `NUMERIC`: expect numeric score values<br/>
        /// - `BOOLEAN`: expect `true` / `false`<br/>
        /// - `CATEGORICAL`: expect one or more values from `score.categories`
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableLlmAsJudgeEvaluator(
            string prompt,
            global::Langfuse.UnstablePublicEvaluatorOutputDefinition outputDefinition,
            global::Langfuse.UnstableEvaluatorModelConfig? modelConfig)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.OutputDefinition = outputDefinition;
            this.ModelConfig = modelConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLlmAsJudgeEvaluator" /> class.
        /// </summary>
        public UnstableLlmAsJudgeEvaluator()
        {
        }

    }
}