
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        ArrayOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType.ArrayOptions => "arrayOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "arrayOptions" => UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType.ArrayOptions,
                _ => null,
            };
        }
    }
}