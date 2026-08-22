
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Resolved evaluator currently used by the evaluation rule.<br/>
    /// `id` identifies the evaluator family. Evaluation runs automatically use<br/>
    /// the latest available evaluator version.
    /// </summary>
    public sealed partial class UnstableEvaluationRuleEvaluator
    {
        /// <summary>
        /// Identifier of the exact evaluator version currently used by the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Evaluator family name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The evaluator engine type.<br/>
        /// The unstable public API supports LLM-as-a-judge and code evaluators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluator" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the exact evaluator version currently used by the rule.
        /// </param>
        /// <param name="name">
        /// Evaluator family name.
        /// </param>
        /// <param name="type">
        /// The evaluator engine type.<br/>
        /// The unstable public API supports LLM-as-a-judge and code evaluators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRuleEvaluator(
            string id,
            string name,
            global::Langfuse.UnstableEvaluatorType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluator" /> class.
        /// </summary>
        public UnstableEvaluationRuleEvaluator()
        {
        }

    }
}