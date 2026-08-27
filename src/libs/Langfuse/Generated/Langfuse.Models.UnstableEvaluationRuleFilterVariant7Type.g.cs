
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        StringObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant7Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant7Type.StringObject => "stringObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "stringObject" => UnstableEvaluationRuleFilterVariant7Type.StringObject,
                _ => null,
            };
        }
    }
}