
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableCreateDashboardWidgetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Defaults to an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetViewJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetView View { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension> Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric> Metrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter> Filters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetChartType ChartType { get; set; }

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
        /// Initializes a new instance of the <see cref="UnstableCreateDashboardWidgetRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="view"></param>
        /// <param name="dimensions"></param>
        /// <param name="metrics"></param>
        /// <param name="filters"></param>
        /// <param name="chartType"></param>
        /// <param name="description">
        /// Defaults to an empty string.
        /// </param>
        /// <param name="chartConfig">
        /// Input-side chart config. `type` is optional and defaults to the<br/>
        /// widget's `chartType`; when given it must match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateDashboardWidgetRequest(
            string name,
            global::Langfuse.UnstableDashboardWidgetView view,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension> dimensions,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric> metrics,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter> filters,
            global::Langfuse.UnstableDashboardWidgetChartType chartType,
            string? description,
            global::Langfuse.UnstableDashboardWidgetChartConfigInput? chartConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.View = view;
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.ChartType = chartType;
            this.ChartConfig = chartConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateDashboardWidgetRequest" /> class.
        /// </summary>
        public UnstableCreateDashboardWidgetRequest()
        {
        }

    }
}