
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        StringObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType.StringObject => "stringObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "stringObject" => UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilterType.StringObject,
                _ => null,
            };
        }
    }
}