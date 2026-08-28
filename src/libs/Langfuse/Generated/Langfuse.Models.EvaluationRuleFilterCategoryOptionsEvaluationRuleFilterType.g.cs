
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        CategoryOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType.CategoryOptions => "categoryOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "categoryOptions" => EvaluationRuleFilterCategoryOptionsEvaluationRuleFilterType.CategoryOptions,
                _ => null,
            };
        }
    }
}