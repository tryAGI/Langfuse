
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Effective runtime status of the evaluation rule.<br/>
    /// - `active`: enabled and currently runnable.<br/>
    /// - `inactive`: disabled by configuration.<br/>
    /// - `paused`: enabled, but Langfuse has blocked execution until the underlying issue is resolved.
    /// </summary>
    public enum UnstableEvaluationRuleStatus
    {
        /// <summary>
        /// enabled and currently runnable.
        /// </summary>
        Active,
        /// <summary>
        /// disabled by configuration.
        /// </summary>
        Inactive,
        /// <summary>
        /// enabled, but Langfuse has blocked execution until the underlying issue is resolved.
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleStatus value)
        {
            return value switch
            {
                UnstableEvaluationRuleStatus.Active => "active",
                UnstableEvaluationRuleStatus.Inactive => "inactive",
                UnstableEvaluationRuleStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UnstableEvaluationRuleStatus.Active,
                "inactive" => UnstableEvaluationRuleStatus.Inactive,
                "paused" => UnstableEvaluationRuleStatus.Paused,
                _ => null,
            };
        }
    }
}