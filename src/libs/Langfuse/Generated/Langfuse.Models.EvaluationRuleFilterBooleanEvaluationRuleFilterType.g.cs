
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterBooleanEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterBooleanEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterBooleanEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterBooleanEvaluationRuleFilterType.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterBooleanEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => EvaluationRuleFilterBooleanEvaluationRuleFilterType.Boolean,
                _ => null,
            };
        }
    }
}