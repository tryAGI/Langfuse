
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The metadata associated with the trace. Values can be any JSON; non-object metadata sent at ingestion is returned under the `metadata` key.
    /// </summary>
    public sealed partial class TraceMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}