
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableEvaluationRule
    {
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
        /// List of filter conditions used to decide whether a target should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter> Filter { get; set; }

        /// <summary>
        /// Variable mappings used to populate evaluator runtime variables from the live target object.
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
        /// Initializes a new instance of the <see cref="UnstableEvaluationRule" /> class.
        /// </summary>
        /// <param name="target">
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, `metadata`, and `tool_calls`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </param>
        /// <param name="filter">
        /// List of filter conditions used to decide whether a target should be evaluated.
        /// </param>
        /// <param name="mapping">
        /// Variable mappings used to populate evaluator runtime variables from the live target object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRule(
            global::Langfuse.UnstableEvaluationRuleTarget target,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter> filter,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> mapping)
        {
            this.Target = target;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRule" /> class.
        /// </summary>
        public UnstableEvaluationRule()
        {
        }

    }
}