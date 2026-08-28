
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => UnstableEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType.Categorical,
                _ => null,
            };
        }
    }
}