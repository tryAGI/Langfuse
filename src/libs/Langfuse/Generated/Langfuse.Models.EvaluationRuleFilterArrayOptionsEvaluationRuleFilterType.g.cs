
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        ArrayOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterArrayOptionsEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType.ArrayOptions => "arrayOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "arrayOptions" => EvaluationRuleFilterArrayOptionsEvaluationRuleFilterType.ArrayOptions,
                _ => null,
            };
        }
    }
}