
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableEvaluatorVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorVariant1Type value)
        {
            return value switch
            {
                UnstableEvaluatorVariant1Type.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => UnstableEvaluatorVariant1Type.LlmAsJudge,
                _ => null,
            };
        }
    }
}