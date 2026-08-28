
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptTextPromptType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTextPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTextPromptType value)
        {
            return value switch
            {
                PromptTextPromptType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTextPromptType? ToEnum(string value)
        {
            return value switch
            {
                "text" => PromptTextPromptType.Text,
                _ => null,
            };
        }
    }
}