#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardsClient
    {
        /// <summary>
        /// Move or resize a placement. All fields are optional; at least one is<br/>
        /// required. Omitted fields keep their current value. The placement's<br/>
        /// content (widget/preset reference) and id cannot change — delete and<br/>
        /// re-add the placement to swap content. Returns the updated placement.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="placementId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardPlacement> UnstableDashboardsUpdatePlacementAsync(
            string dashboardId,
            string placementId,

            global::Langfuse.UnstableUpdateDashboardPlacementRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move or resize a placement. All fields are optional; at least one is<br/>
        /// required. Omitted fields keep their current value. The placement's<br/>
        /// content (widget/preset reference) and id cannot change — delete and<br/>
        /// re-add the placement to swap content. Returns the updated placement.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="placementId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboardPlacement>> UnstableDashboardsUpdatePlacementAsResponseAsync(
            string dashboardId,
            string placementId,

            global::Langfuse.UnstableUpdateDashboardPlacementRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move or resize a placement. All fields are optional; at least one is<br/>
        /// required. Omitted fields keep their current value. The placement's<br/>
        /// content (widget/preset reference) and id cannot change — delete and<br/>
        /// re-add the placement to swap content. Returns the updated placement.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="placementId"></param>
        /// <param name="x">
        /// Grid column (12-column grid).
        /// </param>
        /// <param name="y">
        /// Grid row.
        /// </param>
        /// <param name="width">
        /// Width in grid columns.
        /// </param>
        /// <param name="height">
        /// Height in grid rows.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardPlacement> UnstableDashboardsUpdatePlacementAsync(
            string dashboardId,
            string placementId,
            int? x = default,
            int? y = default,
            int? width = default,
            int? height = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}