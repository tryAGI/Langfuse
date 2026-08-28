
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilterType.Datetime,
                _ => null,
            };
        }
    }
}