
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        CategoryOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType.CategoryOptions => "categoryOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "categoryOptions" => UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilterType.CategoryOptions,
                _ => null,
            };
        }
    }
}