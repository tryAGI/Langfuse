
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreSubjectVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectVariant1Kind value)
        {
            return value switch
            {
                ScoreSubjectVariant1Kind.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "trace" => ScoreSubjectVariant1Kind.Trace,
                _ => null,
            };
        }
    }
}