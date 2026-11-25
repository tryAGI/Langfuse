
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorDecisionModelEvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorDecisionModelEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorDecisionModelEvaluatorType value)
        {
            return value switch
            {
                EvaluatorDecisionModelEvaluatorType.DecisionModel => "decision_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorDecisionModelEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "decision_model" => EvaluatorDecisionModelEvaluatorType.DecisionModel,
                _ => null,
            };
        }
    }
}