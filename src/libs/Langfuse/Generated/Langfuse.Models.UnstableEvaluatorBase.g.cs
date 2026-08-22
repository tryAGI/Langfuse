
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableEvaluatorBase
    {
        /// <summary>
        /// Stable identifier of this evaluator across all versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Evaluator name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version number of this evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Variables that can be mapped when creating an evaluation rule.<br/>
        /// LLM evaluators require every variable to be mapped exactly once. Code evaluators always expose the fixed runtime payload fields and Langfuse maps them automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variables { get; set; }

        /// <summary>
        /// Default variable mapping for this evaluator version, or `null` when no default is configured.<br/>
        /// An entry's `source` is `null` when that variable was never fully configured, and sources<br/>
        /// are not restricted by rule `target` here, because the default is stored on the evaluator<br/>
        /// rather than on any one rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleReadMapping>? Mapping { get; set; }

        /// <summary>
        /// Number of evaluation rules in the project that currently use this evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluationRuleCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EvaluationRuleCount { get; set; }

        /// <summary>
        /// Timestamp when this evaluator was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when this evaluator was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of this evaluator across all versions.
        /// </param>
        /// <param name="name">
        /// Evaluator name.
        /// </param>
        /// <param name="version">
        /// Version number of this evaluator.
        /// </param>
        /// <param name="variables">
        /// Variables that can be mapped when creating an evaluation rule.<br/>
        /// LLM evaluators require every variable to be mapped exactly once. Code evaluators always expose the fixed runtime payload fields and Langfuse maps them automatically.
        /// </param>
        /// <param name="evaluationRuleCount">
        /// Number of evaluation rules in the project that currently use this evaluator.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this evaluator was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when this evaluator was last updated.
        /// </param>
        /// <param name="mapping">
        /// Default variable mapping for this evaluator version, or `null` when no default is configured.<br/>
        /// An entry's `source` is `null` when that variable was never fully configured, and sources<br/>
        /// are not restricted by rule `target` here, because the default is stored on the evaluator<br/>
        /// rather than on any one rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluatorBase(
            string id,
            string name,
            int version,
            global::System.Collections.Generic.IList<string> variables,
            int evaluationRuleCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleReadMapping>? mapping)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.Mapping = mapping;
            this.EvaluationRuleCount = evaluationRuleCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorBase" /> class.
        /// </summary>
        public UnstableEvaluatorBase()
        {
        }

    }
}