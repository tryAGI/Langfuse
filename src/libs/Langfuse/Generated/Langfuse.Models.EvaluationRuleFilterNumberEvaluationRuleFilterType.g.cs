
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterNumberEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterNumberEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterNumberEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterNumberEvaluationRuleFilterType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterNumberEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "number" => EvaluationRuleFilterNumberEvaluationRuleFilterType.Number,
                _ => null,
            };
        }
    }
}