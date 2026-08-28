
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3ScoreSubjectSessionV3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3ScoreSubjectSessionV3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3ScoreSubjectSessionV3Kind value)
        {
            return value switch
            {
                ScoreSubjectV3ScoreSubjectSessionV3Kind.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3ScoreSubjectSessionV3Kind? ToEnum(string value)
        {
            return value switch
            {
                "session" => ScoreSubjectV3ScoreSubjectSessionV3Kind.Session,
                _ => null,
            };
        }
    }
}