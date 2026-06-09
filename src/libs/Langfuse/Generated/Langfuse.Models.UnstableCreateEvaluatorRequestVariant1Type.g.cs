
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableCreateEvaluatorRequestVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        LlmAsJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateEvaluatorRequestVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateEvaluatorRequestVariant1Type value)
        {
            return value switch
            {
                UnstableCreateEvaluatorRequestVariant1Type.LlmAsJudge => "llm_as_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateEvaluatorRequestVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => UnstableCreateEvaluatorRequestVariant1Type.LlmAsJudge,
                _ => null,
            };
        }
    }
}