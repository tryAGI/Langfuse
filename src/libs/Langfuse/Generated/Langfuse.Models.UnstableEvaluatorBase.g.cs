
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableEvaluatorBase
    {
        /// <summary>
        /// Identifier of this evaluator.
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
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorScope Scope { get; set; }

        /// <summary>
        /// Variables that can be mapped when creating an evaluation rule.<br/>
        /// LLM evaluators require every variable to be mapped exactly once. Code evaluators always expose the fixed runtime payload fields and Langfuse maps them automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variables { get; set; }

        /// <summary>
        /// Number of evaluation rules in the project that currently use this evaluator version.
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
        /// Identifier of this evaluator.
        /// </param>
        /// <param name="name">
        /// Evaluator name.
        /// </param>
        /// <param name="version">
        /// Version number of this evaluator.
        /// </param>
        /// <param name="scope">
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </param>
        /// <param name="variables">
        /// Variables that can be mapped when creating an evaluation rule.<br/>
        /// LLM evaluators require every variable to be mapped exactly once. Code evaluators always expose the fixed runtime payload fields and Langfuse maps them automatically.
        /// </param>
        /// <param name="evaluationRuleCount">
        /// Number of evaluation rules in the project that currently use this evaluator version.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this evaluator was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when this evaluator was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluatorBase(
            string id,
            string name,
            int version,
            global::Langfuse.UnstableEvaluatorScope scope,
            global::System.Collections.Generic.IList<string> variables,
            int evaluationRuleCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Scope = scope;
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
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