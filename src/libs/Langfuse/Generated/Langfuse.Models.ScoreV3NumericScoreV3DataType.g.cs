
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV3NumericScoreV3DataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3NumericScoreV3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3NumericScoreV3DataType value)
        {
            return value switch
            {
                ScoreV3NumericScoreV3DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3NumericScoreV3DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreV3NumericScoreV3DataType.Numeric,
                _ => null,
            };
        }
    }
}