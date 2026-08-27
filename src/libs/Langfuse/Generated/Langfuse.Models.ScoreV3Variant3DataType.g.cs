
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV3Variant3DataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3Variant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3Variant3DataType value)
        {
            return value switch
            {
                ScoreV3Variant3DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3Variant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => ScoreV3Variant3DataType.Categorical,
                _ => null,
            };
        }
    }
}