
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NumericScoreV3
    {
        /// <summary>
        /// The numeric value of the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScoreV3" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericScoreV3(
            double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericScoreV3" /> class.
        /// </summary>
        public NumericScoreV3()
        {
        }

    }
}