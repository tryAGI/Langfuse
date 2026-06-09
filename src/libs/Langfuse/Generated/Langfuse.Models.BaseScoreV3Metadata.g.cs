
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Arbitrary metadata attached to the score. Present when "details" is included in the fields parameter.
    /// </summary>
    public sealed partial class BaseScoreV3Metadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}