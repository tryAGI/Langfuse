
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Partial update body for an evaluation rule.<br/>
    /// Provide only the fields you want to change.<br/>
    /// An empty body is rejected.<br/>
    /// Practical guidance:<br/>
    /// - If you only want to rename the rule or change sampling, send just those fields.<br/>
    /// - If you change `evaluator`, send a fresh `mapping` unless you are certain the existing mapping still matches the evaluator variables.<br/>
    /// - If you change `target`, usually send both `filter` and `mapping` in the same request.<br/>
    /// - If you change an experiment `datasetId` filter, call `GET /api/public/v2/datasets` and use dataset `id` values from that response.
    /// </summary>
    public sealed partial class UnstableUpdateEvaluationRuleRequest
    {
        /// <summary>
        /// Updated deployment name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Evaluator family reference used when creating or updating an evaluation rule.<br/>
        /// `name` and `scope` are enough to identify the evaluator family in the authenticated project context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        public global::Langfuse.UnstableEvaluationRuleEvaluatorReference? Evaluator { get; set; }

        /// <summary>
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter))]
        public global::Langfuse.UnstableEvaluationRuleTarget? Target { get; set; }

        /// <summary>
        /// Updated desired enabled state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Updated sampling fraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public double? Sampling { get; set; }

        /// <summary>
        /// Updated filter list.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? Filter { get; set; }

        /// <summary>
        /// Updated variable mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateEvaluationRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated deployment name.
        /// </param>
        /// <param name="evaluator">
        /// Evaluator family reference used when creating or updating an evaluation rule.<br/>
        /// `name` and `scope` are enough to identify the evaluator family in the authenticated project context.
        /// </param>
        /// <param name="target">
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </param>
        /// <param name="enabled">
        /// Updated desired enabled state.
        /// </param>
        /// <param name="sampling">
        /// Updated sampling fraction.
        /// </param>
        /// <param name="filter">
        /// Updated filter list.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </param>
        /// <param name="mapping">
        /// Updated variable mappings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableUpdateEvaluationRuleRequest(
            string? name,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference? evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget? target,
            bool? enabled,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? mapping)
        {
            this.Name = name;
            this.Evaluator = evaluator;
            this.Target = target;
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
            this.Mapping = mapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateEvaluationRuleRequest" /> class.
        /// </summary>
        public UnstableUpdateEvaluationRuleRequest()
        {
        }
    }
}