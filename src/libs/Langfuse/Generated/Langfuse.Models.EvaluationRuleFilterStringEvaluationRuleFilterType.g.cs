
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterStringEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterStringEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterStringEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterStringEvaluationRuleFilterType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterStringEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "string" => EvaluationRuleFilterStringEvaluationRuleFilterType.String,
                _ => null,
            };
        }
    }
}