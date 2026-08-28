
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleNumberFilterOperator
    {
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Lte,
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Gt,
        /// <summary>
        ///
        /// </summary>
        Gte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleNumberFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleNumberFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleNumberFilterOperator.Lt => "<",
                EvaluationRuleNumberFilterOperator.Lte => "<=",
                EvaluationRuleNumberFilterOperator.Eq => "=",
                EvaluationRuleNumberFilterOperator.Gt => ">",
                EvaluationRuleNumberFilterOperator.Gte => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleNumberFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => EvaluationRuleNumberFilterOperator.Lt,
                "<=" => EvaluationRuleNumberFilterOperator.Lte,
                "=" => EvaluationRuleNumberFilterOperator.Eq,
                ">" => EvaluationRuleNumberFilterOperator.Gt,
                ">=" => EvaluationRuleNumberFilterOperator.Gte,
                _ => null,
            };
        }
    }
}