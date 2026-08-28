
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleStringFilterOperator
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
    public static class EvaluationRuleStringFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleStringFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleStringFilterOperator.Eq => "=",
                EvaluationRuleStringFilterOperator.Contains => "contains",
                EvaluationRuleStringFilterOperator.DoesNotContain => "does not contain",
                EvaluationRuleStringFilterOperator.EndsWith => "ends with",
                EvaluationRuleStringFilterOperator.StartsWith => "starts with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleStringFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "=" => EvaluationRuleStringFilterOperator.Eq,
                "contains" => EvaluationRuleStringFilterOperator.Contains,
                "does not contain" => EvaluationRuleStringFilterOperator.DoesNotContain,
                "ends with" => EvaluationRuleStringFilterOperator.EndsWith,
                "starts with" => EvaluationRuleStringFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}