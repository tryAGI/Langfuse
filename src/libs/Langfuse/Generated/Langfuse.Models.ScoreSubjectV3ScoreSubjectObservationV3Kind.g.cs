
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreSubjectV3ScoreSubjectObservationV3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Observation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSubjectV3ScoreSubjectObservationV3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSubjectV3ScoreSubjectObservationV3Kind value)
        {
            return value switch
            {
                ScoreSubjectV3ScoreSubjectObservationV3Kind.Observation => "observation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSubjectV3ScoreSubjectObservationV3Kind? ToEnum(string value)
        {
            return value switch
            {
                "observation" => ScoreSubjectV3ScoreSubjectObservationV3Kind.Observation,
                _ => null,
            };
        }
    }
}