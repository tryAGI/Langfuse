
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEvaluationRuleRequest
    {
        /// <summary>
        /// Human-readable rule name. Names are not identifiers and do not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether live execution should start immediately. Enabled rules require at least one evaluator assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Fraction of matching observations to evaluate. Omit this field to use the default of `1`, which evaluates every match. `null` is not accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public double? Sampling { get; set; }

        /// <summary>
        /// Conditions used to select observations. Defaults to an empty list, which matches every incoming observation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? Filter { get; set; }

        /// <summary>
        /// Evaluators to attach to this rule. Disabled rules may use an empty list as a draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorAssignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput> EvaluatorAssignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable rule name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="enabled">
        /// Whether live execution should start immediately. Enabled rules require at least one evaluator assignment.
        /// </param>
        /// <param name="evaluatorAssignments">
        /// Evaluators to attach to this rule. Disabled rules may use an empty list as a draft.
        /// </param>
        /// <param name="sampling">
        /// Fraction of matching observations to evaluate. Omit this field to use the default of `1`, which evaluates every match. `null` is not accepted.
        /// </param>
        /// <param name="filter">
        /// Conditions used to select observations. Defaults to an empty list, which matches every incoming observation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationRuleRequest(
            string name,
            bool enabled,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput> evaluatorAssignments,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? filter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
            this.EvaluatorAssignments = evaluatorAssignments ?? throw new global::System.ArgumentNullException(nameof(evaluatorAssignments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationRuleRequest" /> class.
        /// </summary>
        public CreateEvaluationRuleRequest()
        {
        }

    }
}