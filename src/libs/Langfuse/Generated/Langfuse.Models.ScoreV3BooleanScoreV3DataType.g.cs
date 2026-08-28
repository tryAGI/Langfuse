
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV3BooleanScoreV3DataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3BooleanScoreV3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3BooleanScoreV3DataType value)
        {
            return value switch
            {
                ScoreV3BooleanScoreV3DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3BooleanScoreV3DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreV3BooleanScoreV3DataType.Boolean,
                _ => null,
            };
        }
    }
}