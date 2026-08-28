
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The evaluator type.<br/>
    /// The public API supports LLM-as-a-judge and code evaluators.
    /// </summary>
    public enum EvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
        /// <summary>
        ///
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorType value)
        {
            return value switch
            {
                EvaluatorType.Code => "code",
                EvaluatorType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => EvaluatorType.Code,
                "llm_as_judge" => EvaluatorType.LlmAsJudge,
                _ => null,
            };
        }
    }
}