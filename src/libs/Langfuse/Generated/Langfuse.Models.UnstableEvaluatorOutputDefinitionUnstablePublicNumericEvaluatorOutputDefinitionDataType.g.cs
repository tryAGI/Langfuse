
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => UnstableEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType.Numeric,
                _ => null,
            };
        }
    }
}