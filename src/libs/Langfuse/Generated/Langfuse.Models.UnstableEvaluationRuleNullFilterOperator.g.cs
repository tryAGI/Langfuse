
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluationRuleNullFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleNullFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleNullFilterOperator value)
        {
            return value switch
            {
                UnstableEvaluationRuleNullFilterOperator.IsNotNull => "is not null",
                UnstableEvaluationRuleNullFilterOperator.IsNull => "is null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleNullFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "is not null" => UnstableEvaluationRuleNullFilterOperator.IsNotNull,
                "is null" => UnstableEvaluationRuleNullFilterOperator.IsNull,
                _ => null,
            };
        }
    }
}