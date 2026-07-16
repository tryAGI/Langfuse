#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardWidgetsClient
    {
        /// <summary>
        /// Create a dashboard widget (a standalone chart definition you place on<br/>
        /// any dashboard).<br/>
        /// This endpoint creates the widget only; place it on a dashboard via<br/>
        /// `POST /dashboards/{dashboardId}/placements`.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API.<br/>
        /// Widgets are created as v2 internally.<br/>
        /// `chartConfig` is optional and defaults to the plain config for<br/>
        /// `chartType`; when `chartConfig.type` is given it must match<br/>
        /// `chartType`.<br/>
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
        /// Create a dashboard widget (a standalone chart definition you place on<br/>
        /// any dashboard).<br/>
        /// This endpoint creates the widget only; place it on a dashboard via<br/>
        /// `POST /dashboards/{dashboardId}/placements`.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API.<br/>
        /// Widgets are created as v2 internally.<br/>
        /// `chartConfig` is optional and defaults to the plain config for<br/>
        /// `chartType`; when `chartConfig.type` is given it must match<br/>
        /// `chartType`.<br/>
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
        /// Create a dashboard widget (a standalone chart definition you place on<br/>
        /// any dashboard).<br/>
        /// This endpoint creates the widget only; place it on a dashboard via<br/>
        /// `POST /dashboards/{dashboardId}/placements`.<br/>
        /// Supported views are `observations`, `scores-numeric`, and `scores-categorical`.<br/>
        /// The legacy `traces` view is not supported by this unstable API.<br/>
        /// Widgets are created as v2 internally.<br/>
        /// `chartConfig` is optional and defaults to the plain config for<br/>
        /// `chartType`; when `chartConfig.type` is given it must match<br/>
        /// `chartType`.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while dashboard/widget APIs are being finalized.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Defaults to an empty string.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsCreateAsync(
            string name,
            global::Langfuse.UnstableDashboardWidgetView view,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension> dimensions,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric> metrics,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter> filters,
            global::Langfuse.UnstableDashboardWidgetChartType chartType,
            string? description = default,
            global::Langfuse.UnstableDashboardWidgetChartConfigInput? chartConfig = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}