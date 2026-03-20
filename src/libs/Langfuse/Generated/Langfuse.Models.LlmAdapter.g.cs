
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAdapter
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertexAi,
        /// <summary>
        /// 
        /// </summary>
        GoogleAiStudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAdapterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAdapter value)
        {
            return value switch
            {
                LlmAdapter.Anthropic => "anthropic",
                LlmAdapter.Openai => "openai",
                LlmAdapter.Azure => "azure",
                LlmAdapter.Bedrock => "bedrock",
                LlmAdapter.GoogleVertexAi => "google-vertex-ai",
                LlmAdapter.GoogleAiStudio => "google-ai-studio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAdapter? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LlmAdapter.Anthropic,
                "openai" => LlmAdapter.Openai,
                "azure" => LlmAdapter.Azure,
                "bedrock" => LlmAdapter.Bedrock,
                "google-vertex-ai" => LlmAdapter.GoogleVertexAi,
                "google-ai-studio" => LlmAdapter.GoogleAiStudio,
                _ => null,
            };
        }
    }
}