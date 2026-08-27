
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleFilterVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        StringOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleFilterVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleFilterVariant4Type value)
        {
            return value switch
            {
                UnstableEvaluationRuleFilterVariant4Type.StringOptions => "stringOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleFilterVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "stringOptions" => UnstableEvaluationRuleFilterVariant4Type.StringOptions,
                _ => null,
            };
        }
    }
}