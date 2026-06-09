
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreSubjectVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Observation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectVariant2Kind value)
        {
            return value switch
            {
                ScoreSubjectVariant2Kind.Observation => "observation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "observation" => ScoreSubjectVariant2Kind.Observation,
                _ => null,
            };
        }
    }
}