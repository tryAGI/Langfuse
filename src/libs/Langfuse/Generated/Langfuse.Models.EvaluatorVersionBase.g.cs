
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorVersionBase
    {
        /// <summary>
        /// Stable identifier of this evaluator version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Monotonically increasing evaluator version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Timestamp when this evaluator version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// User who created the resource, or `null` when no user can be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.Creator CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of this evaluator version.
        /// </param>
        /// <param name="version">
        /// Monotonically increasing evaluator version number.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this evaluator version was created.
        /// </param>
        /// <param name="createdBy">
        /// User who created the resource, or `null` when no user can be resolved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorVersionBase(
            string id,
            int version,
            global::System.DateTime createdAt,
            global::Langfuse.Creator createdBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionBase" /> class.
        /// </summary>
        public EvaluatorVersionBase()
        {
        }

    }
}