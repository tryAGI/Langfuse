#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardWidgetsClient
    {
        /// <summary>
        /// Create a reusable dashboard widget.<br/>
        /// This endpoint creates the widget. It does not place the widget on a dashboard grid, this has to be done in the UI.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API, `minVersion` defaults to `2`; values below `2` are rejected.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while dashboard/widget APIs are being finalized.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsCreateAsync(

            global::Langfuse.UnstableCreateDashboardWidgetRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a reusable dashboard widget.<br/>
        /// This endpoint creates the widget. It does not place the widget on a dashboard grid, this has to be done in the UI.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API, `minVersion` defaults to `2`; values below `2` are rejected.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while dashboard/widget APIs are being finalized.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboardWidget>> UnstableDashboardWidgetsCreateAsResponseAsync(

            global::Langfuse.UnstableCreateDashboardWidgetRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a reusable dashboard widget.<br/>
        /// This endpoint creates the widget. It does not place the widget on a dashboard grid, this has to be done in the UI.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API, `minVersion` defaults to `2`; values below `2` are rejected.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while dashboard/widget APIs are being finalized.
        /// </summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsCreateAsync(
            string name,
            string description,
            global::Langfuse.UnstableDashboardWidgetView view,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension> dimensions,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric> metrics,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter> filters,
            global::Langfuse.UnstableDashboardWidgetChartType chartType,
            global::Langfuse.UnstableDashboardWidgetChartConfig chartConfig,
            int? minVersion = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}