
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicFacet
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBuiltIn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBuiltIn { get; set; }

        /// <summary>
        /// Whether the facet is attached to the project's Topics rule. True for all facets if the project has no rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Latest facet version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Prompt of the latest facet version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedRun")]
        public global::Langfuse.UnstableTopicFacetPublishedRun? PublishedRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicFacet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isBuiltIn"></param>
        /// <param name="active">
        /// Whether the facet is attached to the project's Topics rule. True for all facets if the project has no rule.
        /// </param>
        /// <param name="version">
        /// Latest facet version.
        /// </param>
        /// <param name="prompt">
        /// Prompt of the latest facet version.
        /// </param>
        /// <param name="publishedRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicFacet(
            string id,
            string name,
            string description,
            bool isBuiltIn,
            bool active,
            int version,
            string prompt,
            global::Langfuse.UnstableTopicFacetPublishedRun? publishedRun)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsBuiltIn = isBuiltIn;
            this.Active = active;
            this.Version = version;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PublishedRun = publishedRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicFacet" /> class.
        /// </summary>
        public UnstableTopicFacet()
        {
        }

    }
}