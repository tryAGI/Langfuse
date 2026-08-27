
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Widget data view. Responses may include the legacy `traces` value for<br/>
    /// widgets created before this API existed.
    /// </summary>
    public enum UnstableDashboardWidgetViewWithLegacy
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
        /// <summary>
        ///
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardWidgetViewWithLegacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardWidgetViewWithLegacy value)
        {
            return value switch
            {
                UnstableDashboardWidgetViewWithLegacy.Observations => "observations",
                UnstableDashboardWidgetViewWithLegacy.ScoresBoolean => "scores-boolean",
                UnstableDashboardWidgetViewWithLegacy.ScoresCategorical => "scores-categorical",
                UnstableDashboardWidgetViewWithLegacy.ScoresNumeric => "scores-numeric",
                UnstableDashboardWidgetViewWithLegacy.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardWidgetViewWithLegacy? ToEnum(string value)
        {
            return value switch
            {
                "observations" => UnstableDashboardWidgetViewWithLegacy.Observations,
                "scores-boolean" => UnstableDashboardWidgetViewWithLegacy.ScoresBoolean,
                "scores-categorical" => UnstableDashboardWidgetViewWithLegacy.ScoresCategorical,
                "scores-numeric" => UnstableDashboardWidgetViewWithLegacy.ScoresNumeric,
                "traces" => UnstableDashboardWidgetViewWithLegacy.Traces,
                _ => null,
            };
        }
    }
}