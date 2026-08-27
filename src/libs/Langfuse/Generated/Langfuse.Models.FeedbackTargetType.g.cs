
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum FeedbackTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        Docs,
        /// <summary>
        ///
        /// </summary>
        McpTool,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        PublicApi,
        /// <summary>
        ///
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackTargetType value)
        {
            return value switch
            {
                FeedbackTargetType.Cli => "cli",
                FeedbackTargetType.Docs => "docs",
                FeedbackTargetType.McpTool => "mcp-tool",
                FeedbackTargetType.Other => "other",
                FeedbackTargetType.PublicApi => "public-api",
                FeedbackTargetType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackTargetType? ToEnum(string value)
        {
            return value switch
            {
                "cli" => FeedbackTargetType.Cli,
                "docs" => FeedbackTargetType.Docs,
                "mcp-tool" => FeedbackTargetType.McpTool,
                "other" => FeedbackTargetType.Other,
                "public-api" => FeedbackTargetType.PublicApi,
                "skill" => FeedbackTargetType.Skill,
                _ => null,
            };
        }
    }
}