
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => UnstableEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinitionDataType.Boolean,
                _ => null,
            };
        }
    }
}