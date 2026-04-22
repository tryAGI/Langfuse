
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        ArrayOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant6Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant6Type.ArrayOptions => "arrayOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "arrayOptions" => UnstableEvaluationRuleFilterVariant6Type.ArrayOptions,
                _ => null,
            };
        }
    }
}