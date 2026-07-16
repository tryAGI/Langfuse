#nullable enable

namespace Langfuse
{
    public partial interface IUnstableDashboardsClient
    {
        /// <summary>
        /// Add a placement to a dashboard grid (see `DashboardPlacement` for<br/>
        /// grid semantics).<br/>
        /// `id` and the position fields are optional: when omitted, the<br/>
        /// placement gets a server-generated id and is appended below all<br/>
        /// existing tiles as a 6x6 tile. Returns the created placement.<br/>
        /// The referenced widget must exist in the same project or be a<br/>
        /// Langfuse-managed widget. The API returns `409` if a placement with<br/>
        /// the same `id` already exists on the dashboard.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardPlacement> UnstableDashboardsAddPlacementAsync(
            string dashboardId,

            global::Langfuse.UnstableCreateDashboardPlacementRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a placement to a dashboard grid (see `DashboardPlacement` for<br/>
        /// grid semantics).<br/>
        /// `id` and the position fields are optional: when omitted, the<br/>
        /// placement gets a server-generated id and is appended below all<br/>
        /// existing tiles as a 6x6 tile. Returns the created placement.<br/>
        /// The referenced widget must exist in the same project or be a<br/>
        /// Langfuse-managed widget. The API returns `409` if a placement with<br/>
        /// the same `id` already exists on the dashboard.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDashboardPlacement>> UnstableDashboardsAddPlacementAsResponseAsync(
            string dashboardId,

            global::Langfuse.UnstableCreateDashboardPlacementRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a placement to a dashboard grid (see `DashboardPlacement` for<br/>
        /// grid semantics).<br/>
        /// `id` and the position fields are optional: when omitted, the<br/>
        /// placement gets a server-generated id and is appended below all<br/>
        /// existing tiles as a 6x6 tile. Returns the created placement.<br/>
        /// The referenced widget must exist in the same project or be a<br/>
        /// Langfuse-managed widget. The API returns `409` if a placement with<br/>
        /// the same `id` already exists on the dashboard.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDashboardPlacement> UnstableDashboardsAddPlacementAsync(
            string dashboardId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}