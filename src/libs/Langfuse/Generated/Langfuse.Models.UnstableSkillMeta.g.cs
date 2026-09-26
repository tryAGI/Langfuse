
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableSkillMeta
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersionCreatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LatestVersionCreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersionLastUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LatestVersionLastUpdatedAt { get; set; }

        /// <summary>
        /// Version assigned the production label, or null when no version is assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productionVersion")]
        public int? ProductionVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableSkillMeta" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="latestVersion"></param>
        /// <param name="latestVersionCreatedAt"></param>
        /// <param name="latestVersionLastUpdatedAt"></param>
        /// <param name="productionVersion">
        /// Version assigned the production label, or null when no version is assigned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableSkillMeta(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> tags,
            int latestVersion,
            global::System.DateTime latestVersionCreatedAt,
            global::System.DateTime latestVersionLastUpdatedAt,
            int? productionVersion)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.LatestVersion = latestVersion;
            this.LatestVersionCreatedAt = latestVersionCreatedAt;
            this.LatestVersionLastUpdatedAt = latestVersionLastUpdatedAt;
            this.ProductionVersion = productionVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableSkillMeta" /> class.
        /// </summary>
        public UnstableSkillMeta()
        {
        }

    }
}