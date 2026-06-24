#nullable enable

namespace Langfuse
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get a session.<br/>
        /// Please note that `traces` on this endpoint are not paginated. For large<br/>
        /// sessions or new data extraction workflows, use the v2 observations endpoint<br/>
        /// with a URL-encoded `sessionId` filter and a bounded time range:<br/>
        /// `GET /api/public/v2/observations?filter=&lt;sessionId filter&gt;&amp;fromStartTime=&lt;from&gt;&amp;toStartTime=&lt;to&gt;`.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SessionWithTraces> SessionsGetAsync(
            string sessionId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a session.<br/>
        /// Please note that `traces` on this endpoint are not paginated. For large<br/>
        /// sessions or new data extraction workflows, use the v2 observations endpoint<br/>
        /// with a URL-encoded `sessionId` filter and a bounded time range:<br/>
        /// `GET /api/public/v2/observations?filter=&lt;sessionId filter&gt;&amp;fromStartTime=&lt;from&gt;&amp;toStartTime=&lt;to&gt;`.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.SessionWithTraces>> SessionsGetAsResponseAsync(
            string sessionId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}