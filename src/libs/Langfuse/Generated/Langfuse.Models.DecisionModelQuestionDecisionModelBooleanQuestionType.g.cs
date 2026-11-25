
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionModelQuestionDecisionModelBooleanQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionModelQuestionDecisionModelBooleanQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelQuestionDecisionModelBooleanQuestionType value)
        {
            return value switch
            {
                DecisionModelQuestionDecisionModelBooleanQuestionType.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelQuestionDecisionModelBooleanQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => DecisionModelQuestionDecisionModelBooleanQuestionType.Boolean,
                _ => null,
            };
        }
    }
}