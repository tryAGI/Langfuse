
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleStringFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        DoesNotContain,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleStringFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleStringFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleStringFilterOperator.Eq => "=",
                UnstableEvaluationRuleStringFilterOperator.Contains => "contains",
                UnstableEvaluationRuleStringFilterOperator.DoesNotContain => "does not contain",
                UnstableEvaluationRuleStringFilterOperator.EndsWith => "ends with",
                UnstableEvaluationRuleStringFilterOperator.StartsWith => "starts with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleStringFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "=" => UnstableEvaluationRuleStringFilterOperator.Eq,
                "contains" => UnstableEvaluationRuleStringFilterOperator.Contains,
                "does not contain" => UnstableEvaluationRuleStringFilterOperator.DoesNotContain,
                "ends with" => UnstableEvaluationRuleStringFilterOperator.EndsWith,
                "starts with" => UnstableEvaluationRuleStringFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}