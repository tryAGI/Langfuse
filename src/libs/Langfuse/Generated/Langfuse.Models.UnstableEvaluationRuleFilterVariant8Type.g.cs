
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        NumberObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant8Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant8Type.NumberObject => "numberObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "numberObject" => UnstableEvaluationRuleFilterVariant8Type.NumberObject,
                _ => null,
            };
        }
    }
}