
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleNumberFilterOperator
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
    public static class UnstableEvaluationRuleNumberFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleNumberFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleNumberFilterOperator.Lt => "<",
                UnstableEvaluationRuleNumberFilterOperator.Lte => "<=",
                UnstableEvaluationRuleNumberFilterOperator.Eq => "=",
                UnstableEvaluationRuleNumberFilterOperator.Gt => ">",
                UnstableEvaluationRuleNumberFilterOperator.Gte => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleNumberFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => UnstableEvaluationRuleNumberFilterOperator.Lt,
                "<=" => UnstableEvaluationRuleNumberFilterOperator.Lte,
                "=" => UnstableEvaluationRuleNumberFilterOperator.Eq,
                ">" => UnstableEvaluationRuleNumberFilterOperator.Gt,
                ">=" => UnstableEvaluationRuleNumberFilterOperator.Gte,
                _ => null,
            };
        }
    }
}