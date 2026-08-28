
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterNullEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Null,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterNullEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterNullEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterNullEvaluationRuleFilterType.Null => "null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterNullEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "null" => EvaluationRuleFilterNullEvaluationRuleFilterType.Null,
                _ => null,
            };
        }
    }
}