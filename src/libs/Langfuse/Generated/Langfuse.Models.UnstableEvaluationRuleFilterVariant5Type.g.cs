
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        CategoryOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant5Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant5Type.CategoryOptions => "categoryOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "categoryOptions" => UnstableEvaluationRuleFilterVariant5Type.CategoryOptions,
                _ => null,
            };
        }
    }
}