
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetRunWithItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRunItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.DatasetRunItem> DatasetRunItems { get; set; }

        /// <summary>
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_deprecation")]
        public global::Langfuse.Deprecation? Deprecation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRunWithItems" /> class.
        /// </summary>
        /// <param name="datasetRunItems"></param>
        /// <param name="deprecation">
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRunWithItems(
            global::System.Collections.Generic.IList<global::Langfuse.DatasetRunItem> datasetRunItems,
            global::Langfuse.Deprecation? deprecation)
        {
            this.DatasetRunItems = datasetRunItems ?? throw new global::System.ArgumentNullException(nameof(datasetRunItems));
            this.Deprecation = deprecation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRunWithItems" /> class.
        /// </summary>
        public DatasetRunWithItems()
        {
        }

    }
}