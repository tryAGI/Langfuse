
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorVersionDecisionModelEvaluatorVersionType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorVersionDecisionModelEvaluatorVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorVersionDecisionModelEvaluatorVersionType value)
        {
            return value switch
            {
                EvaluatorVersionDecisionModelEvaluatorVersionType.DecisionModel => "decision_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorVersionDecisionModelEvaluatorVersionType? ToEnum(string value)
        {
            return value switch
            {
                "decision_model" => EvaluatorVersionDecisionModelEvaluatorVersionType.DecisionModel,
                _ => null,
            };
        }
    }
}