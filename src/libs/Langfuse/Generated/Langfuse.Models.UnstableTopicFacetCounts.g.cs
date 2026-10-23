
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicFacetCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicFacetRef Facet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedRunId")]
        public string? PublishedRunId { get; set; }

        /// <summary>
        /// Traces in the window by their current result for one facet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicStatusCounts Counts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicFacetCounts" /> class.
        /// </summary>
        /// <param name="facet"></param>
        /// <param name="counts">
        /// Traces in the window by their current result for one facet.
        /// </param>
        /// <param name="publishedRunId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicFacetCounts(
            global::Langfuse.UnstableTopicFacetRef facet,
            global::Langfuse.UnstableTopicStatusCounts counts,
            string? publishedRunId)
        {
            this.Facet = facet ?? throw new global::System.ArgumentNullException(nameof(facet));
            this.PublishedRunId = publishedRunId;
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicFacetCounts" /> class.
        /// </summary>
        public UnstableTopicFacetCounts()
        {
        }

    }
}