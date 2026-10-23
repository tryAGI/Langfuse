
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopic
    {
        /// <summary>
        /// Stable topic id, kept across map updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Id of this topic version.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicFacetRef Facet { get; set; }

        /// <summary>
        /// The run that produced this topic version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// Traces in the window whose current result for the facet is this topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TraceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable topic id, kept across map updates.
        /// </param>
        /// <param name="versionId">
        /// Id of this topic version.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="facet"></param>
        /// <param name="runId">
        /// The run that produced this topic version.
        /// </param>
        /// <param name="traceCount">
        /// Traces in the window whose current result for the facet is this topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopic(
            string id,
            string versionId,
            string name,
            string description,
            global::Langfuse.UnstableTopicFacetRef facet,
            string runId,
            int traceCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Facet = facet ?? throw new global::System.ArgumentNullException(nameof(facet));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.TraceCount = traceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopic" /> class.
        /// </summary>
        public UnstableTopic()
        {
        }

    }
}