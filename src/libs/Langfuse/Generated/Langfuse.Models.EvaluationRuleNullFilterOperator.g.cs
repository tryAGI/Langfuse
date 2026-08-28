
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleNullFilterOperator
    {
        /// <summary>
        ///
        /// </summary>
        IsNotNull,
        /// <summary>
        ///
        /// </summary>
        IsNull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleNullFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleNullFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleNullFilterOperator.IsNotNull => "is not null",
                EvaluationRuleNullFilterOperator.IsNull => "is null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleNullFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "is not null" => EvaluationRuleNullFilterOperator.IsNotNull,
                "is null" => EvaluationRuleNullFilterOperator.IsNull,
                _ => null,
            };
        }
    }
}