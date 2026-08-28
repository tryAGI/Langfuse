
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Partial update body for an evaluation rule.<br/>
    /// Provide only the fields you want to change.<br/>
    /// An empty body is rejected.<br/>
    /// Practical guidance:<br/>
    /// - If you only want to rename the rule or change sampling, send just those fields.<br/>
    /// - To add, remove, or remap evaluators, send `evaluators`. It replaces the whole assignment set, so include every evaluator the rule should keep.<br/>
    /// - `evaluators` cannot be combined with the deprecated `evaluator`/`mapping` pair, which only ever addressed the first assignment.<br/>
    /// - If you change to an LLM-as-judge `evaluator`, send a fresh `mapping` unless you are certain the existing mapping still matches the prompt variables.<br/>
    /// - If you change `target` for an LLM-as-judge rule, usually send both `filter` and `mapping` in the same request.<br/>
    /// - For code evaluator rules, omit `mapping`; Langfuse stores the fixed code runtime mapping automatically.<br/>
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
        /// Full replacement of the rule's evaluator assignments: entries that are<br/>
        /// not listed are detached.<br/>
        /// Mutually exclusive with the deprecated `evaluator` and `mapping` fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>? Evaluators { get; set; }

        /// <summary>
        /// Evaluator family reference used when updating an evaluation rule.<br/>
        /// `name` identifies the evaluator family in the authenticated project context.<br/>
        /// A rule's evaluator type cannot be changed, so this reference does not accept a `type`; the family must match the rule's current evaluator type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        public global::Langfuse.UnstableEvaluationRuleEvaluatorReference? Evaluator { get; set; }

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
        /// Updated LLM-as-judge variable mappings.<br/>
        /// Do not send this field for code evaluator rules. Langfuse stores the fixed code runtime mapping automatically and returns it in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePromptVariableMappingInput>? Mapping { get; set; }

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
        /// <param name="evaluators">
        /// Full replacement of the rule's evaluator assignments: entries that are<br/>
        /// not listed are detached.<br/>
        /// Mutually exclusive with the deprecated `evaluator` and `mapping` fields.
        /// </param>
        /// <param name="evaluator">
        /// Evaluator family reference used when updating an evaluation rule.<br/>
        /// `name` identifies the evaluator family in the authenticated project context.<br/>
        /// A rule's evaluator type cannot be changed, so this reference does not accept a `type`; the family must match the rule's current evaluator type.
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
        /// Updated LLM-as-judge variable mappings.<br/>
        /// Do not send this field for code evaluator rules. Langfuse stores the fixed code runtime mapping automatically and returns it in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableUpdateEvaluationRuleRequest(
            string? name,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableCreateEvaluationRuleEvaluatorAssignment>? evaluators,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference? evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget? target,
            bool? enabled,
            double? sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter,
            global::System.Collections.Generic.IList<global::Langfuse.UnstablePromptVariableMappingInput>? mapping)
        {
            this.Name = name;
            this.Evaluators = evaluators;
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