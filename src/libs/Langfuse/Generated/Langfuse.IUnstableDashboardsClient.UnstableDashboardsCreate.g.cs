#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardsClient
    {
        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboard> UnstableDashboardsCreateAsync(

            global::Langfuse.UnstableCreateDashboardRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboard>> UnstableDashboardsCreateAsResponseAsync(

            global::Langfuse.UnstableCreateDashboardRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="definition"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboard> UnstableDashboardsCreateAsync(
            string name,
            string? description = default,
            global::Langfuse.UnstableDashboardDefinition? definition = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? filters = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}