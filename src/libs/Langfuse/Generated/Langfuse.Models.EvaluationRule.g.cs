
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Live evaluation rule for incoming observations.<br/>
    /// A rule determines which evaluators should be used, which observations should trigger scoring, how often scoring should run, and which observation fields should populate prompt variables.
    /// </summary>
    public sealed partial class EvaluationRule
    {
        /// <summary>
        /// Stable evaluation-rule identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable rule name. This is independent from evaluator names and does not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// User who created the resource, or `null` when no user can be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.Creator CreatedBy { get; set; }

        /// <summary>
        /// Whether live execution is enabled for this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Fraction of matching observations that should be evaluated.<br/>
        /// Must be between `0` and `1`.<br/>
        /// - `1` evaluates every matching observation.<br/>
        /// - `0.25` evaluates approximately 25% of matching observations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sampling { get; set; }

        /// <summary>
        /// List of stored filter conditions returned verbatim. Filters with a `key` use the keyed response shape; all others use the base shape. These response shapes are not broken down by internal filter type. An empty list matches every incoming object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter> Filter { get; set; }

        /// <summary>
        /// Evaluators attached to this rule in deterministic assignment order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorAssignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment> EvaluatorAssignments { get; set; }

        /// <summary>
        /// Timestamp when the evaluation rule was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the evaluation rule was last updated.
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
        /// Initializes a new instance of the <see cref="EvaluationRule" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable evaluation-rule identifier.
        /// </param>
        /// <param name="name">
        /// Human-readable rule name. This is independent from evaluator names and does not need to be unique.
        /// </param>
        /// <param name="createdBy">
        /// User who created the resource, or `null` when no user can be resolved.
        /// </param>
        /// <param name="enabled">
        /// Whether live execution is enabled for this rule.
        /// </param>
        /// <param name="sampling">
        /// Fraction of matching observations that should be evaluated.<br/>
        /// Must be between `0` and `1`.<br/>
        /// - `1` evaluates every matching observation.<br/>
        /// - `0.25` evaluates approximately 25% of matching observations.
        /// </param>
        /// <param name="filter">
        /// List of stored filter conditions returned verbatim. Filters with a `key` use the keyed response shape; all others use the base shape. These response shapes are not broken down by internal filter type. An empty list matches every incoming object.
        /// </param>
        /// <param name="evaluatorAssignments">
        /// Evaluators attached to this rule in deterministic assignment order.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the evaluation rule was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the evaluation rule was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRule(
            string id,
            string name,
            global::Langfuse.Creator createdBy,
            bool enabled,
            double sampling,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter> filter,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluatorAssignment> evaluatorAssignments,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.EvaluatorAssignments = evaluatorAssignments ?? throw new global::System.ArgumentNullException(nameof(evaluatorAssignments));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRule" /> class.
        /// </summary>
        public EvaluationRule()
        {
        }

    }
}