
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Included only when `fields=metadata` is requested.
    /// </summary>
    public sealed partial class ExperimentMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}