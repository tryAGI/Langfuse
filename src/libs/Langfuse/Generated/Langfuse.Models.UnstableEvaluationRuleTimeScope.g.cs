
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluationRuleTimeScope
    {
        /// <summary>
        ///
        /// </summary>
        Existing,
        /// <summary>
        ///
        /// </summary>
        New,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleTimeScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleTimeScope value)
        {
            return value switch
            {
                UnstableEvaluationRuleTimeScope.Existing => "EXISTING",
                UnstableEvaluationRuleTimeScope.New => "NEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleTimeScope? ToEnum(string value)
        {
            return value switch
            {
                "EXISTING" => UnstableEvaluationRuleTimeScope.Existing,
                "NEW" => UnstableEvaluationRuleTimeScope.New,
                _ => null,
            };
        }
    }
}