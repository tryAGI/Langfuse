
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Role of an evaluator prompt message.
    /// </summary>
    public enum EvaluatorChatMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorChatMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorChatMessageRole value)
        {
            return value switch
            {
                EvaluatorChatMessageRole.Assistant => "assistant",
                EvaluatorChatMessageRole.System => "system",
                EvaluatorChatMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorChatMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EvaluatorChatMessageRole.Assistant,
                "system" => EvaluatorChatMessageRole.System,
                "user" => EvaluatorChatMessageRole.User,
                _ => null,
            };
        }
    }
}