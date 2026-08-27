
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Tokenizer supported by Langfuse for model usage inference.
    /// </summary>
    public enum ModelTokenizerId
    {
        /// <summary>
        ///
        /// </summary>
        Claude,
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelTokenizerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelTokenizerId value)
        {
            return value switch
            {
                ModelTokenizerId.Claude => "claude",
                ModelTokenizerId.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelTokenizerId? ToEnum(string value)
        {
            return value switch
            {
                "claude" => ModelTokenizerId.Claude,
                "openai" => ModelTokenizerId.Openai,
                _ => null,
            };
        }
    }
}