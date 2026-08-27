
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum PricingTierAttributeSource
    {
        /// <summary>
        ///
        /// </summary>
        Metadata,
        /// <summary>
        ///
        /// </summary>
        ModelParameters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingTierAttributeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingTierAttributeSource value)
        {
            return value switch
            {
                PricingTierAttributeSource.Metadata => "metadata",
                PricingTierAttributeSource.ModelParameters => "model_parameters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingTierAttributeSource? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => PricingTierAttributeSource.Metadata,
                "model_parameters" => PricingTierAttributeSource.ModelParameters,
                _ => null,
            };
        }
    }
}