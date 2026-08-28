
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterDateTimeEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterDateTimeEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterDateTimeEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterDateTimeEvaluationRuleFilterType.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterDateTimeEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => EvaluationRuleFilterDateTimeEvaluationRuleFilterType.Datetime,
                _ => null,
            };
        }
    }
}