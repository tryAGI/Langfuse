
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorVersionLlmAsJudgeEvaluatorVersionType
    {
        /// <summary>
        ///
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorVersionLlmAsJudgeEvaluatorVersionType value)
        {
            return value switch
            {
                EvaluatorVersionLlmAsJudgeEvaluatorVersionType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorVersionLlmAsJudgeEvaluatorVersionType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => EvaluatorVersionLlmAsJudgeEvaluatorVersionType.LlmAsJudge,
                _ => null,
            };
        }
    }
}