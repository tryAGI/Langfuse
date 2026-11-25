
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicAssignmentTopic
    {
        /// <summary>
        /// Stable topic id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicAssignmentTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable topic id.
        /// </param>
        /// <param name="versionId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicAssignmentTopic(
            string id,
            string versionId,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicAssignmentTopic" /> class.
        /// </summary>
        public UnstableTopicAssignmentTopic()
        {
        }

    }
}