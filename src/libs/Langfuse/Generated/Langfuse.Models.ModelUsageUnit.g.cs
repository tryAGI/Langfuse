
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Unit of usage in Langfuse
    /// </summary>
    public enum ModelUsageUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Characters,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
        /// <summary>
        /// 
        /// </summary>
        Milliseconds,
        /// <summary>
        /// 
        /// </summary>
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        Requests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelUsageUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelUsageUnit value)
        {
            return value switch
            {
                ModelUsageUnit.Characters => "CHARACTERS",
                ModelUsageUnit.Tokens => "TOKENS",
                ModelUsageUnit.Milliseconds => "MILLISECONDS",
                ModelUsageUnit.Seconds => "SECONDS",
                ModelUsageUnit.Images => "IMAGES",
                ModelUsageUnit.Requests => "REQUESTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelUsageUnit? ToEnum(string value)
        {
            return value switch
            {
                "CHARACTERS" => ModelUsageUnit.Characters,
                "TOKENS" => ModelUsageUnit.Tokens,
                "MILLISECONDS" => ModelUsageUnit.Milliseconds,
                "SECONDS" => ModelUsageUnit.Seconds,
                "IMAGES" => ModelUsageUnit.Images,
                "REQUESTS" => ModelUsageUnit.Requests,
                _ => null,
            };
        }
    }
}