
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV3TextScoreV3DataType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3TextScoreV3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3TextScoreV3DataType value)
        {
            return value switch
            {
                ScoreV3TextScoreV3DataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3TextScoreV3DataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => ScoreV3TextScoreV3DataType.Text,
                _ => null,
            };
        }
    }
}