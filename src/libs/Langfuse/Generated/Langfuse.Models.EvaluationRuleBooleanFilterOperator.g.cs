
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRuleBooleanFilterOperator
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
    public static class EvaluationRuleBooleanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRuleBooleanFilterOperator value)
        {
            return value switch
            {
                EvaluationRuleBooleanFilterOperator.x__ => "<>",
                EvaluationRuleBooleanFilterOperator.Eq => "=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRuleBooleanFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "<>" => EvaluationRuleBooleanFilterOperator.x__,
                "=" => EvaluationRuleBooleanFilterOperator.Eq,
                _ => null,
            };
        }
    }
}