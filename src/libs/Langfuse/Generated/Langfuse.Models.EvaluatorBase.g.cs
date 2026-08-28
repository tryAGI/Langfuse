
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorBase
    {
        /// <summary>
        /// Stable identifier of this evaluator across all versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional human-readable evaluator description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User who created the resource, or `null` when no user can be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.Creator CreatedBy { get; set; }

        /// <summary>
        /// Effective evaluator runtime status.<br/>
        /// - `active`: the evaluator can run.<br/>
        /// - `paused`: Langfuse paused execution until the underlying issue is resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluatorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorStatus Status { get; set; }

        /// <summary>
        /// Timestamp when the evaluator was paused, otherwise `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedAt")]
        public global::System.DateTime? PausedAt { get; set; }

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
        /// All modern and legacy evaluation-rule assignments in newest-assignment-first order. Rule-specific mappings are exposed as `variableMappingOverride`; inherited defaults are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluationRuleAssignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment> EvaluationRuleAssignments { get; set; }

        /// <summary>
        /// Timestamp when the evaluator was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the evaluator was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Stable identifier of the latest evaluator version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Monotonically increasing latest evaluator version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Timestamp when the latest evaluator version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionCreatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime VersionCreatedAt { get; set; }

        /// <summary>
        /// User who created the resource, or `null` when no user can be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionCreatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.Creator VersionCreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of this evaluator across all versions.
        /// </param>
        /// <param name="name">
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="createdBy">
        /// User who created the resource, or `null` when no user can be resolved.
        /// </param>
        /// <param name="status">
        /// Effective evaluator runtime status.<br/>
        /// - `active`: the evaluator can run.<br/>
        /// - `paused`: Langfuse paused execution until the underlying issue is resolved.
        /// </param>
        /// <param name="evaluationRuleAssignments">
        /// All modern and legacy evaluation-rule assignments in newest-assignment-first order. Rule-specific mappings are exposed as `variableMappingOverride`; inherited defaults are omitted.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the evaluator was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the evaluator was last updated.
        /// </param>
        /// <param name="versionId">
        /// Stable identifier of the latest evaluator version.
        /// </param>
        /// <param name="version">
        /// Monotonically increasing latest evaluator version number.
        /// </param>
        /// <param name="versionCreatedAt">
        /// Timestamp when the latest evaluator version was created.
        /// </param>
        /// <param name="versionCreatedBy">
        /// User who created the resource, or `null` when no user can be resolved.
        /// </param>
        /// <param name="description">
        /// Optional human-readable evaluator description.
        /// </param>
        /// <param name="pausedAt">
        /// Timestamp when the evaluator was paused, otherwise `null`.
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
        public EvaluatorBase(
            string id,
            string name,
            global::Langfuse.Creator createdBy,
            global::Langfuse.EvaluatorStatus status,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleAssignment> evaluationRuleAssignments,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string versionId,
            int version,
            global::System.DateTime versionCreatedAt,
            global::Langfuse.Creator versionCreatedBy,
            string? description,
            global::System.DateTime? pausedAt,
            string? pausedReason,
            string? pausedMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Status = status;
            this.PausedAt = pausedAt;
            this.PausedReason = pausedReason;
            this.PausedMessage = pausedMessage;
            this.EvaluationRuleAssignments = evaluationRuleAssignments ?? throw new global::System.ArgumentNullException(nameof(evaluationRuleAssignments));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Version = version;
            this.VersionCreatedAt = versionCreatedAt;
            this.VersionCreatedBy = versionCreatedBy ?? throw new global::System.ArgumentNullException(nameof(versionCreatedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorBase" /> class.
        /// </summary>
        public EvaluatorBase()
        {
        }

    }
}