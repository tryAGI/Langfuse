
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstablePublicNumericEvaluatorOutputScoreDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Inclusive minimum value for numeric evaluator scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// Inclusive maximum value for numeric evaluator scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicNumericEvaluatorOutputScoreDefinition" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="minValue">
        /// Inclusive minimum value for numeric evaluator scores.
        /// </param>
        /// <param name="maxValue">
        /// Inclusive maximum value for numeric evaluator scores.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicNumericEvaluatorOutputScoreDefinition(
            string description,
            double? minValue,
            double? maxValue)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicNumericEvaluatorOutputScoreDefinition" /> class.
        /// </summary>
        public UnstablePublicNumericEvaluatorOutputScoreDefinition()
        {
        }

    }
}