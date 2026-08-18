
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Condition that matches any configured value for a top-level observation attribute.
    /// </summary>
    public sealed partial class PricingTierAttributeCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.PricingTierAttributeSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.PricingTierAttributeSource Source { get; set; }

        /// <summary>
        /// Exact top-level attribute key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Membership operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Accepted string attribute values. At least one value is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierAttributeCondition" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key">
        /// Exact top-level attribute key.
        /// </param>
        /// <param name="operator">
        /// Membership operator.
        /// </param>
        /// <param name="values">
        /// Accepted string attribute values. At least one value is required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingTierAttributeCondition(
            global::Langfuse.PricingTierAttributeSource source,
            string key,
            string @operator,
            global::System.Collections.Generic.IList<string> values)
        {
            this.Source = source;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierAttributeCondition" /> class.
        /// </summary>
        public PricingTierAttributeCondition()
        {
        }

    }
}