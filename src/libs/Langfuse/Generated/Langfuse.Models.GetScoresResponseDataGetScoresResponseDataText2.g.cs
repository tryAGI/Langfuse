
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetScoresResponseDataGetScoresResponseDataText2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataTextDataTypeJsonConverter))]
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataText2" /> class.
        /// </summary>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScoresResponseDataGetScoresResponseDataText2(
            global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataText2" /> class.
        /// </summary>
        public GetScoresResponseDataGetScoresResponseDataText2()
        {
        }

    }
}