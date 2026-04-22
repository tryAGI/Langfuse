
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluatorOutputDefinitionVariant2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDefinitionVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDefinitionVariant2DataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDefinitionVariant2DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDefinitionVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => UnstableEvaluatorOutputDefinitionVariant2DataType.Boolean,
                _ => null,
            };
        }
    }
}