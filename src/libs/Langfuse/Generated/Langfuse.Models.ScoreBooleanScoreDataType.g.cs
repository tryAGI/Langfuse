
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreBooleanScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreBooleanScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreBooleanScoreDataType value)
        {
            return value switch
            {
                ScoreBooleanScoreDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreBooleanScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreBooleanScoreDataType.Boolean,
                _ => null,
            };
        }
    }
}