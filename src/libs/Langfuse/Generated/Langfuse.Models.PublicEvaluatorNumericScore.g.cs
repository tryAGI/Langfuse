
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicEvaluatorNumericScore
    {
        /// <summary>
        /// Numeric score output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataType { get; set; }

        /// <summary>
        /// Optional inclusive minimum value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// Optional inclusive maximum value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEvaluatorNumericScore" /> class.
        /// </summary>
        /// <param name="dataType">
        /// Numeric score output.
        /// </param>
        /// <param name="minValue">
        /// Optional inclusive minimum value.
        /// </param>
        /// <param name="maxValue">
        /// Optional inclusive maximum value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEvaluatorNumericScore(
            string dataType,
            double? minValue,
            double? maxValue)
        {
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEvaluatorNumericScore" /> class.
        /// </summary>
        public PublicEvaluatorNumericScore()
        {
        }

    }
}