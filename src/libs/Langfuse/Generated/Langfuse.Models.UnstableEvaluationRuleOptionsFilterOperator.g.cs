
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleOptionsFilterOperator
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
    public static class UnstableEvaluationRuleOptionsFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleOptionsFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleOptionsFilterOperator.AnyOf => "any of",
                UnstableEvaluationRuleOptionsFilterOperator.NoneOf => "none of",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleOptionsFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "any of" => UnstableEvaluationRuleOptionsFilterOperator.AnyOf,
                "none of" => UnstableEvaluationRuleOptionsFilterOperator.NoneOf,
                _ => null,
            };
        }
    }
}