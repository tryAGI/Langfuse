
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionModelQuestionDecisionModelScoreQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionModelQuestionDecisionModelScoreQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelQuestionDecisionModelScoreQuestionType value)
        {
            return value switch
            {
                DecisionModelQuestionDecisionModelScoreQuestionType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelQuestionDecisionModelScoreQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "score" => DecisionModelQuestionDecisionModelScoreQuestionType.Score,
                _ => null,
            };
        }
    }
}