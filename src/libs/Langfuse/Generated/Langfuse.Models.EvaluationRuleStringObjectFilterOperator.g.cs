
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleStringObjectFilterOperator
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
        IsNotSet,
        /// <summary>
        ///
        /// </summary>
        IsSet,
        /// <summary>
        ///
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRuleStringObjectFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleStringObjectFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleStringObjectFilterOperator.Eq => "=",
                EvaluationRuleStringObjectFilterOperator.Contains => "contains",
                EvaluationRuleStringObjectFilterOperator.DoesNotContain => "does not contain",
                EvaluationRuleStringObjectFilterOperator.EndsWith => "ends with",
                EvaluationRuleStringObjectFilterOperator.IsNotSet => "is not set",
                EvaluationRuleStringObjectFilterOperator.IsSet => "is set",
                EvaluationRuleStringObjectFilterOperator.StartsWith => "starts with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleStringObjectFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "=" => EvaluationRuleStringObjectFilterOperator.Eq,
                "contains" => EvaluationRuleStringObjectFilterOperator.Contains,
                "does not contain" => EvaluationRuleStringObjectFilterOperator.DoesNotContain,
                "ends with" => EvaluationRuleStringObjectFilterOperator.EndsWith,
                "is not set" => EvaluationRuleStringObjectFilterOperator.IsNotSet,
                "is set" => EvaluationRuleStringObjectFilterOperator.IsSet,
                "starts with" => EvaluationRuleStringObjectFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}