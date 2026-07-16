#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardWidgetsClient
    {
        /// <summary>
        /// Update a dashboard widget.<br/>
        /// All fields are optional; at least one field is required.<br/>
        /// Changing `chartType` without sending `chartConfig` resets the config<br/>
        /// to the new chart type's defaults. When `chartConfig.type` is given<br/>
        /// it must match the widget's (possibly updated) `chartType`.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsUpdateAsync(
            string widgetId,

            global::Langfuse.UnstableUpdateDashboardWidgetRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dashboard widget.<br/>
        /// All fields are optional; at least one field is required.<br/>
        /// Changing `chartType` without sending `chartConfig` resets the config<br/>
        /// to the new chart type's defaults. When `chartConfig.type` is given<br/>
        /// it must match the widget's (possibly updated) `chartType`.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboardWidget>> UnstableDashboardWidgetsUpdateAsResponseAsync(
            string widgetId,

            global::Langfuse.UnstableUpdateDashboardWidgetRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dashboard widget.<br/>
        /// All fields are optional; at least one field is required.<br/>
        /// Changing `chartType` without sending `chartConfig` resets the config<br/>
        /// to the new chart type's defaults. When `chartConfig.type` is given<br/>
        /// it must match the widget's (possibly updated) `chartType`.
        /// </summary>
        /// <param name="widgetId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsUpdateAsync(
            string widgetId,
            string? name = default,
            string? description = default,
            global::Langfuse.UnstableDashboardWidgetView? view = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>? dimensions = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>? metrics = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? filters = default,
            global::Langfuse.UnstableDashboardWidgetChartType? chartType = default,
            global::Langfuse.UnstableDashboardWidgetChartConfigInput? chartConfig = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}