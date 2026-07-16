#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardsClient
    {
        /// <summary>
        /// Remove a placement from a dashboard grid without deleting the referenced widget.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="placementId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDeleteDashboardPlacementResponse> UnstableDashboardsDeletePlacementAsync(
            string dashboardId,
            string placementId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a placement from a dashboard grid without deleting the referenced widget.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="placementId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDeleteDashboardPlacementResponse>> UnstableDashboardsDeletePlacementAsResponseAsync(
            string dashboardId,
            string placementId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}