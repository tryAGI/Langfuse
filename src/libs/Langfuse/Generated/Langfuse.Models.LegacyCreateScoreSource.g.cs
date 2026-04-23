
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Source values accepted when creating a score via the public REST API.<br/>
    /// EVAL is reserved for internal evaluator outputs and is intentionally not<br/>
    /// exposed here — use commons.ScoreSource when reading scores.
    /// </summary>
    public enum LegacyCreateScoreSource
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
    public static class LegacyCreateScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyCreateScoreSource value)
        {
            return value switch
            {
                LegacyCreateScoreSource.Annotation => "ANNOTATION",
                LegacyCreateScoreSource.Api => "API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyCreateScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATION" => LegacyCreateScoreSource.Annotation,
                "API" => LegacyCreateScoreSource.Api,
                _ => null,
            };
        }
    }
}