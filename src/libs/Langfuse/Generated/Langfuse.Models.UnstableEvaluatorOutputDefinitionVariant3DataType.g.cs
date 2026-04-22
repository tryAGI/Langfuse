
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionVariant3DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionVariant3DataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionVariant3DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => UnstableEvaluatorOutputDefinitionVariant3DataType.Categorical,
                _ => null,
            };
        }
    }
}