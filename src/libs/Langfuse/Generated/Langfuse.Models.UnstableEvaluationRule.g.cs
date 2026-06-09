
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Live evaluation rule for incoming data.<br/>
    /// An evaluation rule answers:<br/>
    /// - which evaluator should be used<br/>
    /// - which target objects should trigger scoring<br/>
    /// - how often scoring should run<br/>
    /// - which target fields should populate each evaluator variable<br/>
    /// - whether the deployment is active, inactive, or paused<br/>
    /// Important status semantics:<br/>
    /// - `enabled` is the desired on/off setting from the client<br/>
    /// - `status` is the effective runtime state after Langfuse applies validation and blocking rules<br/>
    /// - `enabled=true` with `status=paused` means the rule should run, but Langfuse has paused it until the underlying problem is fixed
    /// </summary>
    public sealed partial class UnstableEvaluationRule
    {
        /// <summary>
        /// Stable evaluation rule identifier.<br/>
        /// Example: erule_123
        /// </summary>
        /// <example>erule_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable deployment name. This is independent from the evaluator name.<br/>
        /// Example: answer-correctness-live
        /// </summary>
        /// <example>answer-correctness-live</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Resolved evaluator currently used by the evaluation rule.<br/>
        /// `id` is the exact active evaluator version.<br/>
        /// `name`, `scope`, and `type` identify the evaluator family conceptually.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleEvaluator Evaluator { get; set; }

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
        /// Desired enabled state configured by the client.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Effective runtime status of the evaluation rule.<br/>
        /// - `active`: enabled and currently runnable.<br/>
        /// - `inactive`: disabled by configuration.<br/>
        /// - `paused`: enabled, but Langfuse has blocked execution until the underlying issue is resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleStatus Status { get; set; }

        /// <summary>
        /// Machine-readable reason when `status=paused`, otherwise `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedReason")]
        public string? PausedReason { get; set; }

        /// <summary>
        /// Human-readable explanation when `status=paused`, otherwise `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedMessage")]
        public string? PausedMessage { get; set; }

        /// <summary>
        /// Fraction of matching target objects that should be evaluated.<br/>
        /// Must be greater than `0` and less than or equal to `1`.<br/>
        /// - `1` means evaluate every matching target.<br/>
        /// - `0.25` means evaluate approximately 25% of matching targets.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sampling { get; set; }

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
        /// Timestamp when the evaluation rule was created.<br/>
        /// Example: 2026-03-30T09:20:00.000Z
        /// </summary>
        /// <example>2026-03-30T09:20:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the evaluation rule was last updated.<br/>
        /// Example: 2026-03-30T09:20:00.000Z
        /// </summary>
        /// <example>2026-03-30T09:20:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRule" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable evaluation rule identifier.<br/>
        /// Example: erule_123
        /// </param>
        /// <param name="name">
        /// Human-readable deployment name. This is independent from the evaluator name.<br/>
        /// Example: answer-correctness-live
        /// </param>
        /// <param name="evaluator">
        /// Resolved evaluator currently used by the evaluation rule.<br/>
        /// `id` is the exact active evaluator version.<br/>
        /// `name`, `scope`, and `type` identify the evaluator family conceptually.
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
        /// Desired enabled state configured by the client.<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Effective runtime status of the evaluation rule.<br/>
        /// - `active`: enabled and currently runnable.<br/>
        /// - `inactive`: disabled by configuration.<br/>
        /// - `paused`: enabled, but Langfuse has blocked execution until the underlying issue is resolved.
        /// </param>
        /// <param name="sampling">
        /// Fraction of matching target objects that should be evaluated.<br/>
        /// Must be greater than `0` and less than or equal to `1`.<br/>
        /// - `1` means evaluate every matching target.<br/>
        /// - `0.25` means evaluate approximately 25% of matching targets.<br/>
        /// Example: 1
        /// </param>
        /// <param name="filter">
        /// List of filter conditions used to decide whether a target should be evaluated.
        /// </param>
        /// <param name="mapping">
        /// Variable mappings used to populate evaluator runtime variables from the live target object.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the evaluation rule was created.<br/>
        /// Example: 2026-03-30T09:20:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the evaluation rule was last updated.<br/>
        /// Example: 2026-03-30T09:20:00.000Z
        /// </param>
        /// <param name="pausedReason">
        /// Machine-readable reason when `status=paused`, otherwise `null`.
        /// </param>
        /// <param name="pausedMessage">
        /// Human-readable explanation when `status=paused`, otherwise `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRule(
            string id,
            string name,
            global::Langfuse.UnstableEvaluationRuleEvaluator evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            global::Langfuse.UnstableEvaluationRuleStatus status,
            double sampling,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter> filter,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> mapping,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? pausedReason,
            string? pausedMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Target = target;
            this.Enabled = enabled;
            this.Status = status;
            this.PausedReason = pausedReason;
            this.PausedMessage = pausedMessage;
            this.Sampling = sampling;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRule" /> class.
        /// </summary>
        public UnstableEvaluationRule()
        {
        }

    }
}