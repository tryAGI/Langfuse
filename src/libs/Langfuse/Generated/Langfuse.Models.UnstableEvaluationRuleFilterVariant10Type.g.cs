
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant10Type
    {
        /// <summary>
        ///
        /// </summary>
        Null,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant10Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant10Type.Null => "null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "null" => UnstableEvaluationRuleFilterVariant10Type.Null,
                _ => null,
            };
        }
    }
}