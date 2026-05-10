
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Optional explicit model configuration for an evaluator.<br/>
    /// If omitted, Langfuse uses the project's default evaluation model.<br/>
    /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
    /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
    /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
    /// Recovery guidance:<br/>
    /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
    /// </summary>
    public sealed partial class UnstableEvaluatorModelConfig
    {
        /// <summary>
        /// Provider identifier to use for this evaluator, for example `openai` or `anthropic`.<br/>
        /// To discover valid values for the current project, call `GET /api/public/llm-connections` and use one of the returned `provider` values.<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Model identifier exposed by the provider, for example `gpt-4.1-mini`.<br/>
        /// Example: gpt-4.1-mini
        /// </summary>
        /// <example>gpt-4.1-mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorModelConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// Provider identifier to use for this evaluator, for example `openai` or `anthropic`.<br/>
        /// To discover valid values for the current project, call `GET /api/public/llm-connections` and use one of the returned `provider` values.<br/>
        /// Example: openai
        /// </param>
        /// <param name="model">
        /// Model identifier exposed by the provider, for example `gpt-4.1-mini`.<br/>
        /// Example: gpt-4.1-mini
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluatorModelConfig(
            string provider,
            string model)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorModelConfig" /> class.
        /// </summary>
        public UnstableEvaluatorModelConfig()
        {
        }

    }
}