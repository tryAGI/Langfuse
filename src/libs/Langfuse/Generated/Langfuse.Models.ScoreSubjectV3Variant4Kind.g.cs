
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3Variant4Kind
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3Variant4KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3Variant4Kind value)
        {
            return value switch
            {
                ScoreSubjectV3Variant4Kind.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3Variant4Kind? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => ScoreSubjectV3Variant4Kind.Experiment,
                _ => null,
            };
        }
    }
}