
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// LLM-as-judge evaluator family reference used when creating an evaluation rule.
    /// </summary>
    public sealed partial class UnstableLlmAsJudgeEvaluationRuleEvaluatorReference
    {
        /// <summary>
        /// Evaluator family name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableLlmAsJudgeEvaluatorTypeJsonConverter))]
        public global::Langfuse.UnstableLlmAsJudgeEvaluatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLlmAsJudgeEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Evaluator family name.
        /// </param>
        /// <param name="scope">
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableLlmAsJudgeEvaluationRuleEvaluatorReference(
            string name,
            global::Langfuse.UnstableEvaluatorScope scope,
            global::Langfuse.UnstableLlmAsJudgeEvaluatorType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLlmAsJudgeEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        public UnstableLlmAsJudgeEvaluationRuleEvaluatorReference()
        {
        }

    }
}