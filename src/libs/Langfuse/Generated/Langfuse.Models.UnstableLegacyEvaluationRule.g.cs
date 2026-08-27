
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Legacy trace- or dataset-level evaluation rule returned by list and get for migration.<br/>
    /// This resource is read-only through the unstable public API. Its mapping preserves the trace, dataset item, or named observation selected for each evaluator variable.
    /// </summary>
    public sealed partial class UnstableLegacyEvaluationRule
    {
        /// <summary>
        /// Evaluators attached to this rule in deterministic assignment order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment> Evaluators { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableLegacyEvaluationRuleTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableLegacyEvaluationRuleTarget Target { get; set; }

        /// <summary>
        /// Delay in milliseconds before the legacy evaluation job runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Delay { get; set; }

        /// <summary>
        /// Whether the legacy rule evaluates newly ingested data, existing data, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeScope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleTimeScope> TimeScope { get; set; }

        /// <summary>
        /// Stored filters used by the legacy trace or dataset rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter> Filter { get; set; }

        /// <summary>
        /// Stored variable mappings, including the trace, dataset item, or named observation selected for each variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleMapping> Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLegacyEvaluationRule" /> class.
        /// </summary>
        /// <param name="evaluators">
        /// Evaluators attached to this rule in deterministic assignment order.
        /// </param>
        /// <param name="target"></param>
        /// <param name="delay">
        /// Delay in milliseconds before the legacy evaluation job runs.
        /// </param>
        /// <param name="timeScope">
        /// Whether the legacy rule evaluates newly ingested data, existing data, or both.
        /// </param>
        /// <param name="filter">
        /// Stored filters used by the legacy trace or dataset rule.
        /// </param>
        /// <param name="mapping">
        /// Stored variable mappings, including the trace, dataset item, or named observation selected for each variable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableLegacyEvaluationRule(
            global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleEvaluatorAssignment> evaluators,
            global::Langfuse.UnstableLegacyEvaluationRuleTarget target,
            int delay,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleTimeScope> timeScope,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter> filter,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableLegacyEvaluationRuleMapping> mapping)
        {
            this.Evaluators = evaluators ?? throw new global::System.ArgumentNullException(nameof(evaluators));
            this.Target = target;
            this.Delay = delay;
            this.TimeScope = timeScope ?? throw new global::System.ArgumentNullException(nameof(timeScope));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLegacyEvaluationRule" /> class.
        /// </summary>
        public UnstableLegacyEvaluationRule()
        {
        }

    }
}