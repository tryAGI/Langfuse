
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV1CategoricalScoreV1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1CategoricalScoreV1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1CategoricalScoreV1DataType value)
        {
            return value switch
            {
                ScoreV1CategoricalScoreV1DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1CategoricalScoreV1DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => ScoreV1CategoricalScoreV1DataType.Categorical,
                _ => null,
            };
        }
    }
}