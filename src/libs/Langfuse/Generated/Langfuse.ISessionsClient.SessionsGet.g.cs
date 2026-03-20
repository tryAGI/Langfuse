#nullable enable

namespace Langfuse
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get a session. Please note that `traces` on this endpoint are not paginated, if you plan to fetch large sessions, consider `GET /api/public/traces?sessionId=&lt;sessionId&gt;`
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SessionWithTraces> SessionsGetAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}