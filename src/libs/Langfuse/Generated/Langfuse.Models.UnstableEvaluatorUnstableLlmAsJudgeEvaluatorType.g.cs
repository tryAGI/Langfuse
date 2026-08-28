
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorUnstableLlmAsJudgeEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType value)
        {
            return value switch
            {
                UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType.LlmAsJudge,
                _ => null,
            };
        }
    }
}