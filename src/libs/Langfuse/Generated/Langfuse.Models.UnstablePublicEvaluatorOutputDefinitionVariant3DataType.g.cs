
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstablePublicEvaluatorOutputDefinitionVariant3DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicEvaluatorOutputDefinitionVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicEvaluatorOutputDefinitionVariant3DataType value)
        {
            return value switch
            {
                UnstablePublicEvaluatorOutputDefinitionVariant3DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinitionVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => UnstablePublicEvaluatorOutputDefinitionVariant3DataType.Categorical,
                _ => null,
            };
        }
    }
}