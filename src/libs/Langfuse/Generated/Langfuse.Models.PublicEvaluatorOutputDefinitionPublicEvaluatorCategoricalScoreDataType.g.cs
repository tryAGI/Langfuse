
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType value)
        {
            return value switch
            {
                PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScoreDataType.Categorical,
                _ => null,
            };
        }
    }
}