
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreV3Variant1DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3Variant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3Variant1DataType value)
        {
            return value switch
            {
                ScoreV3Variant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3Variant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreV3Variant1DataType.Numeric,
                _ => null,
            };
        }
    }
}