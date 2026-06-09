
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreSubjectVariant4Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectVariant4KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectVariant4Kind value)
        {
            return value switch
            {
                ScoreSubjectVariant4Kind.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectVariant4Kind? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => ScoreSubjectVariant4Kind.Experiment,
                _ => null,
            };
        }
    }
}