
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyGetScoresResponseDataVariant2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyGetScoresResponseDataVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyGetScoresResponseDataVariant2DataType value)
        {
            return value switch
            {
                LegacyGetScoresResponseDataVariant2DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyGetScoresResponseDataVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => LegacyGetScoresResponseDataVariant2DataType.Categorical,
                _ => null,
            };
        }
    }
}