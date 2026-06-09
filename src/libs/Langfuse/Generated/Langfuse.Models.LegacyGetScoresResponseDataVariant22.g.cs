
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyGetScoresResponseDataVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.LegacyGetScoresResponseDataVariant2DataTypeJsonConverter))]
        public global::Langfuse.LegacyGetScoresResponseDataVariant2DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyGetScoresResponseDataVariant22" /> class.
        /// </summary>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyGetScoresResponseDataVariant22(
            global::Langfuse.LegacyGetScoresResponseDataVariant2DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyGetScoresResponseDataVariant22" /> class.
        /// </summary>
        public LegacyGetScoresResponseDataVariant22()
        {
        }

    }
}