
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableCreateEvaluationRuleWithEvaluatorsRequest
    {
        /// <summary>
        /// Human-readable deployment name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// One or more evaluator assignments. Providing the deprecated top-level `evaluator` or `mapping` fields alongside this is rejected with `400`.<br/>
        /// Multiple assignments are supported on writable targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment> Evaluators { get; set; }

        /// <summary>
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, `metadata`, and `tool_calls`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public double? Sampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleWithEvaluatorsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable deployment name.
        /// </param>
        /// <param name="evaluators">
        /// One or more evaluator assignments. Providing the deprecated top-level `evaluator` or `mapping` fields alongside this is rejected with `400`.<br/>
        /// Multiple assignments are supported on writable targets.
        /// </param>
        /// <param name="target">
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, `metadata`, and `tool_calls`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="sampling"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateEvaluationRuleWithEvaluatorsRequest(
            string name,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment> evaluators,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Evaluators = evaluators ?? throw new global::System.ArgumentNullException(nameof(evaluators));
            this.Target = target;
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleWithEvaluatorsRequest" /> class.
        /// </summary>
        public UnstableCreateEvaluationRuleWithEvaluatorsRequest()
        {
        }

    }
}