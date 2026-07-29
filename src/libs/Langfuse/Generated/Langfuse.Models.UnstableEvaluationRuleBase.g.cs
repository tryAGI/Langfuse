
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
    public sealed partial class UnstableEvaluationRuleBase
    {
        /// <summary>
        /// Stable evaluation rule identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable deployment name. This is independent from the evaluator name.
        /// </summary>
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
        /// Desired enabled state configured by the client.
        /// </summary>
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
        /// - `0.25` means evaluate approximately 25% of matching targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sampling { get; set; }

        /// <summary>
        /// Timestamp when the evaluation rule was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the evaluation rule was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable evaluation rule identifier.
        /// </param>
        /// <param name="name">
        /// Human-readable deployment name. This is independent from the evaluator name.
        /// </param>
        /// <param name="evaluator">
        /// Resolved evaluator currently used by the evaluation rule.<br/>
        /// `id` is the exact active evaluator version.<br/>
        /// `name`, `scope`, and `type` identify the evaluator family conceptually.
        /// </param>
        /// <param name="enabled">
        /// Desired enabled state configured by the client.
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
        /// - `0.25` means evaluate approximately 25% of matching targets.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the evaluation rule was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the evaluation rule was last updated.
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
        public UnstableEvaluationRuleBase(
            string id,
            string name,
            global::Langfuse.UnstableEvaluationRuleEvaluator evaluator,
            bool enabled,
            global::Langfuse.UnstableEvaluationRuleStatus status,
            double sampling,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? pausedReason,
            string? pausedMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Evaluator = evaluator ?? throw new global::System.ArgumentNullException(nameof(evaluator));
            this.Enabled = enabled;
            this.Status = status;
            this.PausedReason = pausedReason;
            this.PausedMessage = pausedMessage;
            this.Sampling = sampling;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleBase" /> class.
        /// </summary>
        public UnstableEvaluationRuleBase()
        {
        }

    }
}