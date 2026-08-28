
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterStringObjectEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        StringObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterStringObjectEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterStringObjectEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterStringObjectEvaluationRuleFilterType.StringObject => "stringObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterStringObjectEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "stringObject" => EvaluationRuleFilterStringObjectEvaluationRuleFilterType.StringObject,
                _ => null,
            };
        }
    }
}