
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleFilterNumberObjectEvaluationRuleFilterType
    {
        /// <summary>
        ///
        /// </summary>
        NumberObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleFilterNumberObjectEvaluationRuleFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleFilterNumberObjectEvaluationRuleFilterType value)
        {
            return value switch
            {
                EvaluationRuleFilterNumberObjectEvaluationRuleFilterType.NumberObject => "numberObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleFilterNumberObjectEvaluationRuleFilterType? ToEnum(string value)
        {
            return value switch
            {
                "numberObject" => EvaluationRuleFilterNumberObjectEvaluationRuleFilterType.NumberObject,
                _ => null,
            };
        }
    }
}