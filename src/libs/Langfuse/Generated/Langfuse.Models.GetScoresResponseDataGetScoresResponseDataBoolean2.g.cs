
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetScoresResponseDataGetScoresResponseDataBoolean2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataBooleanDataTypeJsonConverter))]
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataBoolean2" /> class.
        /// </summary>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScoresResponseDataGetScoresResponseDataBoolean2(
            global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataBoolean2" /> class.
        /// </summary>
        public GetScoresResponseDataGetScoresResponseDataBoolean2()
        {
        }

    }
}