
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Explicit model configuration for an evaluator.<br/>
    /// If the complete `modelConfig` is `null`, Langfuse uses the project's default evaluation model.<br/>
    /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.
    /// </summary>
    public sealed partial class EvaluatorModelConfig
    {
        /// <summary>
        /// Provider identifier, for example `openai` or `anthropic`.<br/>
        /// To discover valid values for the current project, call `GET /api/public/llm-connections` and use one of the returned `provider` values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Model identifier exposed by the provider, for example `gpt-4.1-mini`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorModelConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// Provider identifier, for example `openai` or `anthropic`.<br/>
        /// To discover valid values for the current project, call `GET /api/public/llm-connections` and use one of the returned `provider` values.
        /// </param>
        /// <param name="model">
        /// Model identifier exposed by the provider, for example `gpt-4.1-mini`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorModelConfig(
            string provider,
            string model)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorModelConfig" /> class.
        /// </summary>
        public EvaluatorModelConfig()
        {
        }

    }
}