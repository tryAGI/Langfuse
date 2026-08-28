
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        StringOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType.StringOptions => "stringOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "stringOptions" => UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilterType.StringOptions,
                _ => null,
            };
        }
    }
}