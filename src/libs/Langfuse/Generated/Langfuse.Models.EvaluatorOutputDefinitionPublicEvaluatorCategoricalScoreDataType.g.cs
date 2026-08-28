
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType value)
        {
            return value switch
            {
                EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => EvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType.Categorical,
                _ => null,
            };
        }
    }
}