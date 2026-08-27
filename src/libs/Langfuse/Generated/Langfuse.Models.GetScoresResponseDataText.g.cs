
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetScoresResponseDataText
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::Langfuse.GetScoresResponseTraceData? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataText" /> class.
        /// </summary>
        /// <param name="trace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScoresResponseDataText(
            global::Langfuse.GetScoresResponseTraceData? trace)
        {
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataText" /> class.
        /// </summary>
        public GetScoresResponseDataText()
        {
        }

    }
}