
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleArrayOptionsFilterOperator
    {
        /// <summary>
        ///
        /// </summary>
        AllOf,
        /// <summary>
        ///
        /// </summary>
        AnyOf,
        /// <summary>
        ///
        /// </summary>
        NoneOf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleArrayOptionsFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleArrayOptionsFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleArrayOptionsFilterOperator.AllOf => "all of",
                EvaluationRuleArrayOptionsFilterOperator.AnyOf => "any of",
                EvaluationRuleArrayOptionsFilterOperator.NoneOf => "none of",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleArrayOptionsFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "all of" => EvaluationRuleArrayOptionsFilterOperator.AllOf,
                "any of" => EvaluationRuleArrayOptionsFilterOperator.AnyOf,
                "none of" => EvaluationRuleArrayOptionsFilterOperator.NoneOf,
                _ => null,
            };
        }
    }
}