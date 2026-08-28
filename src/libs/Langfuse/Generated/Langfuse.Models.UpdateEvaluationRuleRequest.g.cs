
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// At least one field must be provided.
    /// </summary>
    public sealed partial class UpdateEvaluationRuleRequest
    {
        /// <summary>
        /// New human-readable rule name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New desired live-execution state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// New fraction of matching observations to evaluate. Omit to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public double? Sampling { get; set; }

        /// <summary>
        /// Complete replacement filter list. An empty list matches every incoming observation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Filter { get; set; }

        /// <summary>
        /// Complete replacement assignment list. An empty list disables the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorAssignments")]
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? EvaluatorAssignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluationRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New human-readable rule name.
        /// </param>
        /// <param name="enabled">
        /// New desired live-execution state.
        /// </param>
        /// <param name="sampling">
        /// New fraction of matching observations to evaluate. Omit to keep the current value.
        /// </param>
        /// <param name="filter">
        /// Complete replacement filter list. An empty list matches every incoming observation.
        /// </param>
        /// <param name="evaluatorAssignments">
        /// Complete replacement assignment list. An empty list disables the rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEvaluationRuleRequest(
            string? name,
            bool? enabled,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? filter,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? evaluatorAssignments)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
            this.EvaluatorAssignments = evaluatorAssignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluationRuleRequest" /> class.
        /// </summary>
        public UpdateEvaluationRuleRequest()
        {
        }

    }
}