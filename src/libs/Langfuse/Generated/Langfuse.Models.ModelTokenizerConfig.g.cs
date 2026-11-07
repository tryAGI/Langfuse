
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Legacy tokenizer configuration retained for API compatibility. Ingestion no longer uses it to infer observation usage.
    /// </summary>
    public sealed partial class ModelTokenizerConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}