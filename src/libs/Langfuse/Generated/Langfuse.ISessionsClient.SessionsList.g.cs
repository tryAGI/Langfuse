#nullable enable

namespace Langfuse
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get sessions.<br/>
        /// This legacy endpoint is not recommended for new data extraction workflows.<br/>
        /// Use the v2 observations endpoint with a bounded time range and group rows by<br/>
        /// `sessionId` instead:<br/>
        /// `GET /api/public/v2/observations?fromStartTime=&lt;from&gt;&amp;toStartTime=&lt;to&gt;`.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.PaginatedSessions> SessionsListAsync(
            int? page = default,
            int? limit = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sessions.<br/>
        /// This legacy endpoint is not recommended for new data extraction workflows.<br/>
        /// Use the v2 observations endpoint with a bounded time range and group rows by<br/>
        /// `sessionId` instead:<br/>
        /// `GET /api/public/v2/observations?fromStartTime=&lt;from&gt;&amp;toStartTime=&lt;to&gt;`.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.PaginatedSessions>> SessionsListAsResponseAsync(
            int? page = default,
            int? limit = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}