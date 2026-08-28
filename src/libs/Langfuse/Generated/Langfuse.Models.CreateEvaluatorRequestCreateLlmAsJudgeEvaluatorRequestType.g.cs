
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType
    {
        /// <summary>
        ///
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType value)
        {
            return value switch
            {
                CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequestType.LlmAsJudge,
                _ => null,
            };
        }
    }
}