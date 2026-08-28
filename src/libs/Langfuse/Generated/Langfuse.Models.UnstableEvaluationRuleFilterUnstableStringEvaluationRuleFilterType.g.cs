
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "string" => UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType.String,
                _ => null,
            };
        }
    }
}