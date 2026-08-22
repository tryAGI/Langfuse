
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableCreateEvaluationRuleEvaluatorReference
    {
        /// <summary>
        /// 
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
        public global::Langfuse.UnstableEvaluatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The evaluator engine type.<br/>
        /// The unstable public API supports LLM-as-a-judge and code evaluators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateEvaluationRuleEvaluatorReference(
            string name,
            global::Langfuse.UnstableEvaluatorType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        public UnstableCreateEvaluationRuleEvaluatorReference()
        {
        }

    }
}