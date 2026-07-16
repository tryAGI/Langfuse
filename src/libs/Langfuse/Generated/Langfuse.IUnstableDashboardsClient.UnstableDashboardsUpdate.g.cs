#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardsClient
    {
        /// <summary>
        /// Update a dashboard's name, description, definition, or filters.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboard> UnstableDashboardsUpdateAsync(
            string dashboardId,

            global::Langfuse.UnstableUpdateDashboardRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dashboard's name, description, definition, or filters.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboard>> UnstableDashboardsUpdateAsResponseAsync(
            string dashboardId,

            global::Langfuse.UnstableUpdateDashboardRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dashboard's name, description, definition, or filters.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="definition"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboard> UnstableDashboardsUpdateAsync(
            string dashboardId,
            string? name = default,
            string? description = default,
            global::Langfuse.UnstableDashboardDefinition? definition = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? filters = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}