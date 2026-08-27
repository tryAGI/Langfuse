
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3Variant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3Variant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3Variant1Kind value)
        {
            return value switch
            {
                ScoreSubjectV3Variant1Kind.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3Variant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "trace" => ScoreSubjectV3Variant1Kind.Trace,
                _ => null,
            };
        }
    }
}