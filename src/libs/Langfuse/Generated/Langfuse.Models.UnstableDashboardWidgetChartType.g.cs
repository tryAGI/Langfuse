
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableDashboardWidgetChartType
    {
        /// <summary>
        /// 
        /// </summary>
        AreaTimeSeries,
        /// <summary>
        /// 
        /// </summary>
        BarTimeSeries,
        /// <summary>
        /// 
        /// </summary>
        Histogram,
        /// <summary>
        /// 
        /// </summary>
        HorizontalBar,
        /// <summary>
        /// 
        /// </summary>
        LineTimeSeries,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Pie,
        /// <summary>
        /// 
        /// </summary>
        PivotTable,
        /// <summary>
        /// 
        /// </summary>
        VerticalBar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardWidgetChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardWidgetChartType value)
        {
            return value switch
            {
                UnstableDashboardWidgetChartType.AreaTimeSeries => "AREA_TIME_SERIES",
                UnstableDashboardWidgetChartType.BarTimeSeries => "BAR_TIME_SERIES",
                UnstableDashboardWidgetChartType.Histogram => "HISTOGRAM",
                UnstableDashboardWidgetChartType.HorizontalBar => "HORIZONTAL_BAR",
                UnstableDashboardWidgetChartType.LineTimeSeries => "LINE_TIME_SERIES",
                UnstableDashboardWidgetChartType.Number => "NUMBER",
                UnstableDashboardWidgetChartType.Pie => "PIE",
                UnstableDashboardWidgetChartType.PivotTable => "PIVOT_TABLE",
                UnstableDashboardWidgetChartType.VerticalBar => "VERTICAL_BAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardWidgetChartType? ToEnum(string value)
        {
            return value switch
            {
                "AREA_TIME_SERIES" => UnstableDashboardWidgetChartType.AreaTimeSeries,
                "BAR_TIME_SERIES" => UnstableDashboardWidgetChartType.BarTimeSeries,
                "HISTOGRAM" => UnstableDashboardWidgetChartType.Histogram,
                "HORIZONTAL_BAR" => UnstableDashboardWidgetChartType.HorizontalBar,
                "LINE_TIME_SERIES" => UnstableDashboardWidgetChartType.LineTimeSeries,
                "NUMBER" => UnstableDashboardWidgetChartType.Number,
                "PIE" => UnstableDashboardWidgetChartType.Pie,
                "PIVOT_TABLE" => UnstableDashboardWidgetChartType.PivotTable,
                "VERTICAL_BAR" => UnstableDashboardWidgetChartType.VerticalBar,
                _ => null,
            };
        }
    }
}