
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant9Type
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant9Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant9Type.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => UnstableEvaluationRuleFilterVariant9Type.Boolean,
                _ => null,
            };
        }
    }
}