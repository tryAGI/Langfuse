
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The evaluator engine type.<br/>
    /// The unstable public API currently supports only LLM-as-a-judge evaluators.
    /// </summary>
    public enum UnstableEvaluatorType
    {
        /// <summary>
        /// 
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorType value)
        {
            return value switch
            {
                UnstableEvaluatorType.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => UnstableEvaluatorType.LlmAsJudge,
                _ => null,
            };
        }
    }
}