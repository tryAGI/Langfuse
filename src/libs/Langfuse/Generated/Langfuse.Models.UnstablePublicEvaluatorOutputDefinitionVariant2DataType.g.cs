
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionVariant2DataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionVariant2DataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionVariant2DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => UnstablePublicEvaluatorOutputDefinitionVariant2DataType.Boolean,
                _ => null,
            };
        }
    }
}