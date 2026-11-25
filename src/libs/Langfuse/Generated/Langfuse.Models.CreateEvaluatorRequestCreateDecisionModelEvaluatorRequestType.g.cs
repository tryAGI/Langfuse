
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType value)
        {
            return value switch
            {
                CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType.DecisionModel => "decision_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType? ToEnum(string value)
        {
            return value switch
            {
                "decision_model" => CreateEvaluatorRequestCreateDecisionModelEvaluatorRequestType.DecisionModel,
                _ => null,
            };
        }
    }
}