
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        NumberObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType.NumberObject => "numberObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "numberObject" => UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilterType.NumberObject,
                _ => null,
            };
        }
    }
}