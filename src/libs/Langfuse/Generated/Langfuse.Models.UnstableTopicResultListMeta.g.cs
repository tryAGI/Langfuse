
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicResultListMeta
    {
        /// <summary>
        /// Pass as `cursor` to fetch the next page. Null on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Set when the page is shorter than `limit` but more rows may follow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicResultListMeta" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Pass as `cursor` to fetch the next page. Null on the last page.
        /// </param>
        /// <param name="comment">
        /// Set when the page is shorter than `limit` but more rows may follow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicResultListMeta(
            string? cursor,
            string? comment)
        {
            this.Cursor = cursor;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicResultListMeta" /> class.
        /// </summary>
        public UnstableTopicResultListMeta()
        {
        }

    }
}