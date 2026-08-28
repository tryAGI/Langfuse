
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreNumericScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreNumericScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreNumericScoreDataType value)
        {
            return value switch
            {
                ScoreNumericScoreDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreNumericScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreNumericScoreDataType.Numeric,
                _ => null,
            };
        }
    }
}