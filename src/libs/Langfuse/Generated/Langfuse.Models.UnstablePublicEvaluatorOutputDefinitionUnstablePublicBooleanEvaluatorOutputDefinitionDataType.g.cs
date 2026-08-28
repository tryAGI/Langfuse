
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType.Boolean,
                _ => null,
            };
        }
    }
}