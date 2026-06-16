
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Evaluator family reference used when updating an evaluation rule.<br/>
    /// `name` and `scope` identify the evaluator family in the authenticated project context.<br/>
    /// A rule's evaluator type cannot be changed, so this reference does not accept a `type`; the family must match the rule's current evaluator type.
    /// </summary>
    public sealed partial class UnstableEvaluationRuleEvaluatorReference
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Evaluator family name.
        /// </param>
        /// <param name="scope">
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRuleEvaluatorReference(
            string name,
            global::Langfuse.UnstableEvaluatorScope scope)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        public UnstableEvaluationRuleEvaluatorReference()
        {
        }

    }
}