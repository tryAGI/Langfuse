
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableCreateCodeEvaluationRuleRequest
    {
        /// <summary>
        /// Human-readable deployment name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Code evaluator family reference used when creating an evaluation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableCodeEvaluationRuleEvaluatorReference Evaluator { get; set; }

        /// <summary>
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleTarget Target { get; set; }

        /// <summary>
        /// Whether the deployment should be active immediately after creation.
        /// </summary>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateCodeEvaluationRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable deployment name.
        /// </param>
        /// <param name="evaluator">
        /// Code evaluator family reference used when creating an evaluation rule.
        /// </param>
        /// <param name="target">
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </param>
        /// <param name="enabled">
        /// Whether the deployment should be active immediately after creation.
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
        public UnstableCreateCodeEvaluationRuleRequest(
            string name,
            global::Langfuse.UnstableCodeEvaluationRuleEvaluatorReference evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Target = target;
            this.Enabled = enabled;
            this.Sampling = sampling;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateCodeEvaluationRuleRequest" /> class.
        /// </summary>
        public UnstableCreateCodeEvaluationRuleRequest()
        {
        }

    }
}