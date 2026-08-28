
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleOptionsFilterOperator
    {
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
    public static class EvaluationRuleOptionsFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleOptionsFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleOptionsFilterOperator.AnyOf => "any of",
                EvaluationRuleOptionsFilterOperator.NoneOf => "none of",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleOptionsFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "any of" => EvaluationRuleOptionsFilterOperator.AnyOf,
                "none of" => EvaluationRuleOptionsFilterOperator.NoneOf,
                _ => null,
            };
        }
    }
}