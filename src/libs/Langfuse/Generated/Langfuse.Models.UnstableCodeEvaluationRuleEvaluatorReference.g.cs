
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Code evaluator family reference used when creating an evaluation rule.
    /// </summary>
    public sealed partial class UnstableCodeEvaluationRuleEvaluatorReference
    {
        /// <summary>
        /// Evaluator family name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Must be `code`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCodeEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Evaluator family name.
        /// </param>
        /// <param name="type">
        /// Must be `code`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCodeEvaluationRuleEvaluatorReference(
            string name,
            string type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCodeEvaluationRuleEvaluatorReference" /> class.
        /// </summary>
        public UnstableCodeEvaluationRuleEvaluatorReference()
        {
        }

    }
}