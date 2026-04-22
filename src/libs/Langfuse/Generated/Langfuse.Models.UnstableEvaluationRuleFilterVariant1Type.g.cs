
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant1Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant1Type.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => UnstableEvaluationRuleFilterVariant1Type.Datetime,
                _ => null,
            };
        }
    }
}