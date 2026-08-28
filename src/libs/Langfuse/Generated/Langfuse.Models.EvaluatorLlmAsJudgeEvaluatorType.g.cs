
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorLlmAsJudgeEvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorLlmAsJudgeEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorLlmAsJudgeEvaluatorType value)
        {
            return value switch
            {
                EvaluatorLlmAsJudgeEvaluatorType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorLlmAsJudgeEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => EvaluatorLlmAsJudgeEvaluatorType.LlmAsJudge,
                _ => null,
            };
        }
    }
}