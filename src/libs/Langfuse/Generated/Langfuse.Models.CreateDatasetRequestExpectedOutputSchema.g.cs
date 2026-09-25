
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// JSON Schema for validating dataset item expected outputs. When set, all new and existing dataset items will be validated against this schema.
    /// </summary>
    public sealed partial class CreateDatasetRequestExpectedOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}