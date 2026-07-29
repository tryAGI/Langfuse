
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Source values accepted when creating a score via the public REST API.<br/>
    /// EVAL is reserved for internal evaluator outputs and is intentionally not<br/>
    /// exposed here — use commons.ScoreSource when reading scores.
    /// </summary>
    public enum CreateScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScoreSource value)
        {
            return value switch
            {
                CreateScoreSource.Annotation => "ANNOTATION",
                CreateScoreSource.Api => "API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATION" => CreateScoreSource.Annotation,
                "API" => CreateScoreSource.Api,
                _ => null,
            };
        }
    }
}