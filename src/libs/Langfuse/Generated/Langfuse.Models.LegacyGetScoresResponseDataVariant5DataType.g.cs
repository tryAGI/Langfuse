
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyGetScoresResponseDataVariant5DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyGetScoresResponseDataVariant5DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyGetScoresResponseDataVariant5DataType value)
        {
            return value switch
            {
                LegacyGetScoresResponseDataVariant5DataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyGetScoresResponseDataVariant5DataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => LegacyGetScoresResponseDataVariant5DataType.Text,
                _ => null,
            };
        }
    }
}