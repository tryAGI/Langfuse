
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Metadata for cursor-based pagination.
    /// </summary>
    public sealed partial class UtilsCursorMetaResponse
    {
        /// <summary>
        /// Opaque cursor for the next page. Omitted when there is no next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsCursorMetaResponse" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor for the next page. Omitted when there is no next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtilsCursorMetaResponse(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsCursorMetaResponse" /> class.
        /// </summary>
        public UtilsCursorMetaResponse()
        {
        }

    }
}