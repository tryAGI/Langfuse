
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionVariant1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionVariant1DataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionVariant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => UnstablePublicEvaluatorOutputDefinitionVariant1DataType.Numeric,
                _ => null,
            };
        }
    }
}