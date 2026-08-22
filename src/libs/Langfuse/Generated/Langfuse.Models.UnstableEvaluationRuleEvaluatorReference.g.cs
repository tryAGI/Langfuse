
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Evaluator family reference used when updating an evaluation rule.<br/>
    /// `name` identifies the evaluator family in the authenticated project context.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRuleEvaluatorReference(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        public UnstableEvaluationRuleEvaluatorReference()
        {
        }

    }
}