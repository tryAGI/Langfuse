
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetScoresResponseDataGetScoresResponseDataNumeric2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataNumericDataTypeJsonConverter))]
        public global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataNumeric2" /> class.
        /// </summary>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScoresResponseDataGetScoresResponseDataNumeric2(
            global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataGetScoresResponseDataNumeric2" /> class.
        /// </summary>
        public GetScoresResponseDataGetScoresResponseDataNumeric2()
        {
        }

    }
}