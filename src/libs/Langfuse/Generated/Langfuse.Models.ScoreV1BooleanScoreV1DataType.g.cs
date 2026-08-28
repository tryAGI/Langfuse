
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV1BooleanScoreV1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1BooleanScoreV1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1BooleanScoreV1DataType value)
        {
            return value switch
            {
                ScoreV1BooleanScoreV1DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1BooleanScoreV1DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreV1BooleanScoreV1DataType.Boolean,
                _ => null,
            };
        }
    }
}