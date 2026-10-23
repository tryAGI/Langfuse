
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicWindow Window { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableTopic> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacetCounts> Facets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UtilsMetaResponse Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicList" /> class.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="data"></param>
        /// <param name="facets"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicList(
            global::Langfuse.UnstableTopicWindow window,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableTopic> data,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacetCounts> facets,
            global::Langfuse.UtilsMetaResponse meta)
        {
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Facets = facets ?? throw new global::System.ArgumentNullException(nameof(facets));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicList" /> class.
        /// </summary>
        public UnstableTopicList()
        {
        }

    }
}