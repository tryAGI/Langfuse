
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Metadata for cursor-based pagination.
    /// </summary>
    public sealed partial class ObservationsV2Meta
    {
        /// <summary>
        /// Present when an empty page has a cursor; continue requesting pages until the cursor is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Meta" /> class.
        /// </summary>
        /// <param name="comment">
        /// Present when an empty page has a cursor; continue requesting pages until the cursor is absent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationsV2Meta(
            string? comment)
        {
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Meta" /> class.
        /// </summary>
        public ObservationsV2Meta()
        {
        }

    }
}