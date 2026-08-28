
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV1TextScoreV1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1TextScoreV1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1TextScoreV1DataType value)
        {
            return value switch
            {
                ScoreV1TextScoreV1DataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1TextScoreV1DataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => ScoreV1TextScoreV1DataType.Text,
                _ => null,
            };
        }
    }
}