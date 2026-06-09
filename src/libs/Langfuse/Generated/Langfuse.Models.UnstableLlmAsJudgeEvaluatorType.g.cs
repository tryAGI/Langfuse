
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableLlmAsJudgeEvaluatorType
    {
        /// <summary>
        /// 
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableLlmAsJudgeEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableLlmAsJudgeEvaluatorType value)
        {
            return value switch
            {
                UnstableLlmAsJudgeEvaluatorType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableLlmAsJudgeEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => UnstableLlmAsJudgeEvaluatorType.LlmAsJudge,
                _ => null,
            };
        }
    }
}