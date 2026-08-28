
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3ScoreSubjectExperimentV3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3ScoreSubjectExperimentV3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3ScoreSubjectExperimentV3Kind value)
        {
            return value switch
            {
                ScoreSubjectV3ScoreSubjectExperimentV3Kind.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3ScoreSubjectExperimentV3Kind? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => ScoreSubjectV3ScoreSubjectExperimentV3Kind.Experiment,
                _ => null,
            };
        }
    }
}