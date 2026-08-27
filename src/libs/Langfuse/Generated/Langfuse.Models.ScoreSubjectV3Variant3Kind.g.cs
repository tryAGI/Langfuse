
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3Variant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3Variant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3Variant3Kind value)
        {
            return value switch
            {
                ScoreSubjectV3Variant3Kind.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3Variant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "session" => ScoreSubjectV3Variant3Kind.Session,
                _ => null,
            };
        }
    }
}