
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicEvaluatorBooleanScore
    {
        /// <summary>
        /// Boolean score output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEvaluatorBooleanScore" /> class.
        /// </summary>
        /// <param name="dataType">
        /// Boolean score output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEvaluatorBooleanScore(
            string dataType)
        {
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEvaluatorBooleanScore" /> class.
        /// </summary>
        public PublicEvaluatorBooleanScore()
        {
        }

    }
}