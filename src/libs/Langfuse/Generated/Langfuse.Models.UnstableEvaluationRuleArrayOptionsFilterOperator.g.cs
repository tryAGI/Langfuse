
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleArrayOptionsFilterOperator
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
    public static class UnstableEvaluationRuleArrayOptionsFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleArrayOptionsFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleArrayOptionsFilterOperator.AllOf => "all of",
                UnstableEvaluationRuleArrayOptionsFilterOperator.AnyOf => "any of",
                UnstableEvaluationRuleArrayOptionsFilterOperator.NoneOf => "none of",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleArrayOptionsFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "all of" => UnstableEvaluationRuleArrayOptionsFilterOperator.AllOf,
                "any of" => UnstableEvaluationRuleArrayOptionsFilterOperator.AnyOf,
                "none of" => UnstableEvaluationRuleArrayOptionsFilterOperator.NoneOf,
                _ => null,
            };
        }
    }
}