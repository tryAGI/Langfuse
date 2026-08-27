
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionVariant1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionVariant1DataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionVariant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => UnstableEvaluatorOutputDefinitionVariant1DataType.Numeric,
                _ => null,
            };
        }
    }
}