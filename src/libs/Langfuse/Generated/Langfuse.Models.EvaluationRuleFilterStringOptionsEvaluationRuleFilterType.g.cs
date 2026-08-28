
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterStringOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        StringOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterStringOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterStringOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterStringOptionsEvaluationRuleFilterType.StringOptions => "stringOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterStringOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "stringOptions" => EvaluationRuleFilterStringOptionsEvaluationRuleFilterType.StringOptions,
                _ => null,
            };
        }
    }
}