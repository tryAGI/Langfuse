
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyGetScoresResponseDataVariant3DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyGetScoresResponseDataVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyGetScoresResponseDataVariant3DataType value)
        {
            return value switch
            {
                LegacyGetScoresResponseDataVariant3DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyGetScoresResponseDataVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => LegacyGetScoresResponseDataVariant3DataType.Boolean,
                _ => null,
            };
        }
    }
}