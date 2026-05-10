
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Request body for creating an evaluation rule.<br/>
    /// Checklist for agents and SDK clients:<br/>
    /// - reference an existing evaluator family by `evaluator.name` and `evaluator.scope`<br/>
    /// - choose `target=observation` or `target=experiment`<br/>
    /// - if `target=experiment` and you want a dataset filter, call `GET /api/public/v2/datasets` first and use dataset `id` values in `filter[].value`<br/>
    /// - fetch or inspect the evaluator first, then provide a complete variable mapping for every evaluator variable listed in `variables`<br/>
    /// - optionally narrow execution with `filter`<br/>
    /// - set `enabled=true` only when you want live execution immediately
    /// </summary>
    public sealed partial class UnstableCreateEvaluationRuleRequest
    {
        /// <summary>
        /// Human-readable deployment name.<br/>
        /// Example: answer-correctness-live
        /// </summary>
        /// <example>answer-correctness-live</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Evaluator family reference used when creating or updating an evaluation rule.<br/>
        /// `name` and `scope` are enough to identify the evaluator family in the authenticated project context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleEvaluatorReference Evaluator { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleTarget Target { get; set; }

        /// <summary>
        /// Whether the deployment should be active immediately after creation.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Optional sampling fraction. Defaults to `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public double? Sampling { get; set; }

        /// <summary>
        /// Optional filter list.<br/>
        /// Omit or pass an empty list to evaluate all matching targets for the selected `target`.<br/>
        /// Each filter object must use a column that is valid for that `target`.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? Filter { get; set; }

        /// <summary>
        /// Required variable mappings.<br/>
        /// Every evaluator variable must appear exactly once.<br/>
        /// Build this list from the evaluator `variables` array returned by the evaluator endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable deployment name.<br/>
        /// Example: answer-correctness-live
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
        /// Whether the deployment should be active immediately after creation.<br/>
        /// Example: true
        /// </param>
        /// <param name="mapping">
        /// Required variable mappings.<br/>
        /// Every evaluator variable must appear exactly once.<br/>
        /// Build this list from the evaluator `variables` array returned by the evaluator endpoints.
        /// </param>
        /// <param name="sampling">
        /// Optional sampling fraction. Defaults to `1`.
        /// </param>
        /// <param name="filter">
        /// Optional filter list.<br/>
        /// Omit or pass an empty list to evaluate all matching targets for the selected `target`.<br/>
        /// Each filter object must use a column that is valid for that `target`.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateEvaluationRuleRequest(
            string name,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> mapping,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Target = target;
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateEvaluationRuleRequest" /> class.
        /// </summary>
        public UnstableCreateEvaluationRuleRequest()
        {
        }

    }
}