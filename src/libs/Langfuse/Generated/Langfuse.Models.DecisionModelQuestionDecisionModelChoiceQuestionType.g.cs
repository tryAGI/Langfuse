
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionModelQuestionDecisionModelChoiceQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionModelQuestionDecisionModelChoiceQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelQuestionDecisionModelChoiceQuestionType value)
        {
            return value switch
            {
                DecisionModelQuestionDecisionModelChoiceQuestionType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelQuestionDecisionModelChoiceQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionModelQuestionDecisionModelChoiceQuestionType.Choice,
                _ => null,
            };
        }
    }
}