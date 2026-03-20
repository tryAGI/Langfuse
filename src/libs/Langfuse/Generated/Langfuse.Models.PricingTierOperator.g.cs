
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Comparison operators for pricing tier conditions
    /// </summary>
    public enum PricingTierOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingTierOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingTierOperator value)
        {
            return value switch
            {
                PricingTierOperator.Gt => "gt",
                PricingTierOperator.Gte => "gte",
                PricingTierOperator.Lt => "lt",
                PricingTierOperator.Lte => "lte",
                PricingTierOperator.Eq => "eq",
                PricingTierOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingTierOperator? ToEnum(string value)
        {
            return value switch
            {
                "gt" => PricingTierOperator.Gt,
                "gte" => PricingTierOperator.Gte,
                "lt" => PricingTierOperator.Lt,
                "lte" => PricingTierOperator.Lte,
                "eq" => PricingTierOperator.Eq,
                "neq" => PricingTierOperator.Neq,
                _ => null,
            };
        }
    }
}