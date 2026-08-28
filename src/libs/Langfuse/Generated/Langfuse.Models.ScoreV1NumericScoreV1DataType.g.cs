
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV1NumericScoreV1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1NumericScoreV1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1NumericScoreV1DataType value)
        {
            return value switch
            {
                ScoreV1NumericScoreV1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1NumericScoreV1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreV1NumericScoreV1DataType.Numeric,
                _ => null,
            };
        }
    }
}