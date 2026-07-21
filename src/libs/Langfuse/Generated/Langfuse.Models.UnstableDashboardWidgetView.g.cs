
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableDashboardWidgetView
    {
        /// <summary>
        /// 
        /// </summary>
        Observations,
        /// <summary>
        /// 
        /// </summary>
        ScoresBoolean,
        /// <summary>
        /// 
        /// </summary>
        ScoresCategorical,
        /// <summary>
        /// 
        /// </summary>
        ScoresNumeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardWidgetViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardWidgetView value)
        {
            return value switch
            {
                UnstableDashboardWidgetView.Observations => "observations",
                UnstableDashboardWidgetView.ScoresBoolean => "scores-boolean",
                UnstableDashboardWidgetView.ScoresCategorical => "scores-categorical",
                UnstableDashboardWidgetView.ScoresNumeric => "scores-numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardWidgetView? ToEnum(string value)
        {
            return value switch
            {
                "observations" => UnstableDashboardWidgetView.Observations,
                "scores-boolean" => UnstableDashboardWidgetView.ScoresBoolean,
                "scores-categorical" => UnstableDashboardWidgetView.ScoresCategorical,
                "scores-numeric" => UnstableDashboardWidgetView.ScoresNumeric,
                _ => null,
            };
        }
    }
}