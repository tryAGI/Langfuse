
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Effective evaluator runtime status.<br/>
    /// - `active`: the evaluator can run.<br/>
    /// - `paused`: Langfuse paused execution until the underlying issue is resolved.
    /// </summary>
    public enum EvaluatorStatus
    {
        /// <summary>
        /// the evaluator can run.
        /// </summary>
        Active,
        /// <summary>
        /// Langfuse paused execution until the underlying issue is resolved.
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorStatus value)
        {
            return value switch
            {
                EvaluatorStatus.Active => "active",
                EvaluatorStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => EvaluatorStatus.Active,
                "paused" => EvaluatorStatus.Paused,
                _ => null,
            };
        }
    }
}