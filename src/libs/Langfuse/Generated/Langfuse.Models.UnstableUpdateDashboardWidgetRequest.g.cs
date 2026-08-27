
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableUpdateDashboardWidgetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetViewJsonConverter))]
        public global::Langfuse.UnstableDashboardWidgetView? View { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? Metrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Filters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeJsonConverter))]
        public global::Langfuse.UnstableDashboardWidgetChartType? ChartType { get; set; }

        /// <summary>
        /// Input-side chart config. `type` is optional and defaults to the<br/>
        /// widget's `chartType`; when given it must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartConfig")]
        public global::Langfuse.UnstableDashboardWidgetChartConfigInput? ChartConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardWidgetRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="view"></param>
        /// <param name="dimensions"></param>
        /// <param name="metrics"></param>
        /// <param name="filters"></param>
        /// <param name="chartType"></param>
        /// <param name="chartConfig">
        /// Input-side chart config. `type` is optional and defaults to the<br/>
        /// widget's `chartType`; when given it must match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableUpdateDashboardWidgetRequest(
            string? name,
            string? description,
            global::Langfuse.UnstableDashboardWidgetView? view,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? dimensions,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? metrics,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? filters,
            global::Langfuse.UnstableDashboardWidgetChartType? chartType,
            global::Langfuse.UnstableDashboardWidgetChartConfigInput? chartConfig)
        {
            this.Name = name;
            this.Description = description;
            this.View = view;
            this.Dimensions = dimensions;
            this.Metrics = metrics;
            this.Filters = filters;
            this.ChartType = chartType;
            this.ChartConfig = chartConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardWidgetRequest" /> class.
        /// </summary>
        public UnstableUpdateDashboardWidgetRequest()
        {
        }

    }
}