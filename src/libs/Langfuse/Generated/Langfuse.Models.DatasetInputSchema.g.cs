
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// JSON Schema for validating dataset item inputs
    /// </summary>
    public sealed partial class DatasetInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}