
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// User who created the resource, or `null` when no user can be resolved.
    /// </summary>
    public sealed partial class Creator
    {
        /// <summary>
        /// User identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User name, or `null` when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Creator" /> class.
        /// </summary>
        /// <param name="id">
        /// User identifier.
        /// </param>
        /// <param name="name">
        /// User name, or `null` when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Creator(
            string id,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Creator" /> class.
        /// </summary>
        public Creator()
        {
        }

    }
}