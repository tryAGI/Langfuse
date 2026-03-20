
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum CommentObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Trace,
        /// <summary>
        /// 
        /// </summary>
        Observation,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommentObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentObjectType value)
        {
            return value switch
            {
                CommentObjectType.Trace => "TRACE",
                CommentObjectType.Observation => "OBSERVATION",
                CommentObjectType.Session => "SESSION",
                CommentObjectType.Prompt => "PROMPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentObjectType? ToEnum(string value)
        {
            return value switch
            {
                "TRACE" => CommentObjectType.Trace,
                "OBSERVATION" => CommentObjectType.Observation,
                "SESSION" => CommentObjectType.Session,
                "PROMPT" => CommentObjectType.Prompt,
                _ => null,
            };
        }
    }
}