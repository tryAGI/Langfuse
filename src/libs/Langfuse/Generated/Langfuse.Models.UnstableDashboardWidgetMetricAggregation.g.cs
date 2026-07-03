
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableDashboardWidgetMetricAggregation
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Histogram,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        P50,
        /// <summary>
        /// 
        /// </summary>
        P75,
        /// <summary>
        /// 
        /// </summary>
        P90,
        /// <summary>
        /// 
        /// </summary>
        P95,
        /// <summary>
        /// 
        /// </summary>
        P99,
        /// <summary>
        /// 
        /// </summary>
        Sum,
        /// <summary>
        /// 
        /// </summary>
        Uniq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardWidgetMetricAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardWidgetMetricAggregation value)
        {
            return value switch
            {
                UnstableDashboardWidgetMetricAggregation.Avg => "avg",
                UnstableDashboardWidgetMetricAggregation.Count => "count",
                UnstableDashboardWidgetMetricAggregation.Histogram => "histogram",
                UnstableDashboardWidgetMetricAggregation.Max => "max",
                UnstableDashboardWidgetMetricAggregation.Min => "min",
                UnstableDashboardWidgetMetricAggregation.P50 => "p50",
                UnstableDashboardWidgetMetricAggregation.P75 => "p75",
                UnstableDashboardWidgetMetricAggregation.P90 => "p90",
                UnstableDashboardWidgetMetricAggregation.P95 => "p95",
                UnstableDashboardWidgetMetricAggregation.P99 => "p99",
                UnstableDashboardWidgetMetricAggregation.Sum => "sum",
                UnstableDashboardWidgetMetricAggregation.Uniq => "uniq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardWidgetMetricAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => UnstableDashboardWidgetMetricAggregation.Avg,
                "count" => UnstableDashboardWidgetMetricAggregation.Count,
                "histogram" => UnstableDashboardWidgetMetricAggregation.Histogram,
                "max" => UnstableDashboardWidgetMetricAggregation.Max,
                "min" => UnstableDashboardWidgetMetricAggregation.Min,
                "p50" => UnstableDashboardWidgetMetricAggregation.P50,
                "p75" => UnstableDashboardWidgetMetricAggregation.P75,
                "p90" => UnstableDashboardWidgetMetricAggregation.P90,
                "p95" => UnstableDashboardWidgetMetricAggregation.P95,
                "p99" => UnstableDashboardWidgetMetricAggregation.P99,
                "sum" => UnstableDashboardWidgetMetricAggregation.Sum,
                "uniq" => UnstableDashboardWidgetMetricAggregation.Uniq,
                _ => null,
            };
        }
    }
}