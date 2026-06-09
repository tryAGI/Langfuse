
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreSubjectVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectVariant3Kind value)
        {
            return value switch
            {
                ScoreSubjectVariant3Kind.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "session" => ScoreSubjectVariant3Kind.Session,
                _ => null,
            };
        }
    }
}