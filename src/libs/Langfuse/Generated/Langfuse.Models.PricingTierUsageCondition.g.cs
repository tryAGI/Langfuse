
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Condition that sums usage details whose keys match a regex.
    /// </summary>
    public sealed partial class PricingTierUsageCondition
    {
        /// <summary>
        /// Regex pattern matched against usage detail keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDetailPattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsageDetailPattern { get; set; }

        /// <summary>
        /// Comparison operators for pricing tier conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.PricingTierOperator Operator { get; set; }

        /// <summary>
        /// Numeric threshold for the summed matching usage values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Whether the usage-detail regex is case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierUsageCondition" /> class.
        /// </summary>
        /// <param name="usageDetailPattern">
        /// Regex pattern matched against usage detail keys.
        /// </param>
        /// <param name="operator">
        /// Comparison operators for pricing tier conditions
        /// </param>
        /// <param name="value">
        /// Numeric threshold for the summed matching usage values.
        /// </param>
        /// <param name="caseSensitive">
        /// Whether the usage-detail regex is case-sensitive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingTierUsageCondition(
            string usageDetailPattern,
            global::Langfuse.PricingTierOperator @operator,
            double value,
            bool caseSensitive)
        {
            this.UsageDetailPattern = usageDetailPattern ?? throw new global::System.ArgumentNullException(nameof(usageDetailPattern));
            this.Operator = @operator;
            this.Value = value;
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierUsageCondition" /> class.
        /// </summary>
        public PricingTierUsageCondition()
        {
        }

    }
}