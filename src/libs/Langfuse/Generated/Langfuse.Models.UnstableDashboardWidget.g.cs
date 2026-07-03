
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableDashboardWidget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
        /// Chart-specific widget configuration.<br/>
        /// `type` must match the top-level `chartType`.<br/>
        /// `row_limit` applies to total-value charts and pivot tables.<br/>
        /// `bins` applies to histograms.<br/>
        /// `defaultSort` applies to pivot tables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetChartConfig ChartConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidget" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="view"></param>
        /// <param name="dimensions"></param>
        /// <param name="metrics"></param>
        /// <param name="filters"></param>
        /// <param name="chartType"></param>
        /// <param name="chartConfig">
        /// Chart-specific widget configuration.<br/>
        /// `type` must match the top-level `chartType`.<br/>
        /// `row_limit` applies to total-value charts and pivot tables.<br/>
        /// `bins` applies to histograms.<br/>
        /// `defaultSort` applies to pivot tables.
        /// </param>
        /// <param name="minVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidget(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            string description,
            global::Langfuse.UnstableDashboardWidgetView view,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension> dimensions,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric> metrics,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter> filters,
            global::Langfuse.UnstableDashboardWidgetChartType chartType,
            global::Langfuse.UnstableDashboardWidgetChartConfig chartConfig,
            int minVersion)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.View = view;
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.ChartType = chartType;
            this.ChartConfig = chartConfig ?? throw new global::System.ArgumentNullException(nameof(chartConfig));
            this.MinVersion = minVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidget" /> class.
        /// </summary>
        public UnstableDashboardWidget()
        {
        }

    }
}