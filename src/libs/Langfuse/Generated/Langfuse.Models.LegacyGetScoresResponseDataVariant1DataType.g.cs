
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyGetScoresResponseDataVariant1DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyGetScoresResponseDataVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyGetScoresResponseDataVariant1DataType value)
        {
            return value switch
            {
                LegacyGetScoresResponseDataVariant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyGetScoresResponseDataVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => LegacyGetScoresResponseDataVariant1DataType.Numeric,
                _ => null,
            };
        }
    }
}