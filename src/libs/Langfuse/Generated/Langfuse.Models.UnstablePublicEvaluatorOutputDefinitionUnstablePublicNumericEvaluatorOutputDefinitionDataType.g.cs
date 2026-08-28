
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType.Numeric,
                _ => null,
            };
        }
    }
}