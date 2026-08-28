
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Metadata-only update. At least one field must be provided.
    /// </summary>
    public sealed partial class UpdateEvaluatorMetadataRequest
    {
        /// <summary>
        /// New human-readable evaluator name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description. Set to `null` to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluatorMetadataRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New human-readable evaluator name.
        /// </param>
        /// <param name="description">
        /// New description. Set to `null` to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEvaluatorMetadataRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluatorMetadataRequest" /> class.
        /// </summary>
        public UpdateEvaluatorMetadataRequest()
        {
        }

    }
}