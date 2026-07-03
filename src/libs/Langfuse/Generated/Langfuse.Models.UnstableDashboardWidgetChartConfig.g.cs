
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Chart-specific widget configuration.<br/>
    /// `type` must match the top-level `chartType`.<br/>
    /// `row_limit` applies to total-value charts and pivot tables.<br/>
    /// `bins` applies to histograms.<br/>
    /// `defaultSort` applies to pivot tables.
    /// </summary>
    public sealed partial class UnstableDashboardWidgetChartConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetChartType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_limit")]
        public int? RowLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_value_labels")]
        public bool? ShowValueLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        public int? Bins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSort")]
        public global::Langfuse.UnstableDashboardWidgetDefaultSort? DefaultSort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetChartConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="rowLimit"></param>
        /// <param name="showValueLabels"></param>
        /// <param name="bins"></param>
        /// <param name="defaultSort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidgetChartConfig(
            global::Langfuse.UnstableDashboardWidgetChartType type,
            int? rowLimit,
            bool? showValueLabels,
            int? bins,
            global::Langfuse.UnstableDashboardWidgetDefaultSort? defaultSort)
        {
            this.Type = type;
            this.RowLimit = rowLimit;
            this.ShowValueLabels = showValueLabels;
            this.Bins = bins;
            this.DefaultSort = defaultSort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetChartConfig" /> class.
        /// </summary>
        public UnstableDashboardWidgetChartConfig()
        {
        }

    }
}