#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardWidgetsClient
    {
        /// <summary>
        /// Get a dashboard widget by id.<br/>
        /// The response may use `view: traces` for legacy widgets.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardWidget> UnstableDashboardWidgetsGetAsync(
            string widgetId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a dashboard widget by id.<br/>
        /// The response may use `view: traces` for legacy widgets.
        /// </summary>
        /// <param name="widgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboardWidget>> UnstableDashboardWidgetsGetAsResponseAsync(
            string widgetId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}