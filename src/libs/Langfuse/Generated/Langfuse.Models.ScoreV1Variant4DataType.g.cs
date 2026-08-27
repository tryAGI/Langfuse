
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV1Variant4DataType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1Variant4DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1Variant4DataType value)
        {
            return value switch
            {
                ScoreV1Variant4DataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1Variant4DataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => ScoreV1Variant4DataType.Text,
                _ => null,
            };
        }
    }
}