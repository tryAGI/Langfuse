#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardWidgetsClient
    {
        /// <summary>
        /// Delete a dashboard widget.<br/>
        /// The API returns `409` while the widget is still placed on a dashboard.<br/>
        /// Remove those placements first.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDeleteDashboardWidgetResponse> UnstableDashboardWidgetsDeleteAsync(
            string widgetId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a dashboard widget.<br/>
        /// The API returns `409` while the widget is still placed on a dashboard.<br/>
        /// Remove those placements first.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDeleteDashboardWidgetResponse>> UnstableDashboardWidgetsDeleteAsResponseAsync(
            string widgetId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}