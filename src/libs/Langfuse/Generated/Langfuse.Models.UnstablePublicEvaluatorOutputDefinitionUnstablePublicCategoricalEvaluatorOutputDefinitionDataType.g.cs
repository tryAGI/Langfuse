
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType.Categorical,
                _ => null,
            };
        }
    }
}