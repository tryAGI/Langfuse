
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleBooleanFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleBooleanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleBooleanFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleBooleanFilterOperator.x__ => "<>",
                UnstableEvaluationRuleBooleanFilterOperator.Eq => "=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleBooleanFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "<>" => UnstableEvaluationRuleBooleanFilterOperator.x__,
                "=" => UnstableEvaluationRuleBooleanFilterOperator.Eq,
                _ => null,
            };
        }
    }
}