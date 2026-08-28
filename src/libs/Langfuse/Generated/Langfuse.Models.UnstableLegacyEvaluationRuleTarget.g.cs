
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// **Deprecated:** Legacy trace or dataset evaluation target.
    /// </summary>
    public enum UnstableLegacyEvaluationRuleTarget
    {
        /// <summary>
        /// ** Legacy trace or dataset evaluation target.
        /// </summary>
        Dataset,
        /// <summary>
        /// ** Legacy trace or dataset evaluation target.
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableLegacyEvaluationRuleTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableLegacyEvaluationRuleTarget value)
        {
            return value switch
            {
                UnstableLegacyEvaluationRuleTarget.Dataset => "dataset",
                UnstableLegacyEvaluationRuleTarget.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableLegacyEvaluationRuleTarget? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => UnstableLegacyEvaluationRuleTarget.Dataset,
                "trace" => UnstableLegacyEvaluationRuleTarget.Trace,
                _ => null,
            };
        }
    }
}