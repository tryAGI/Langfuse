#nullable enable

namespace Langfuse
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get sessions
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="environment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.PaginatedSessions> SessionsListAsync(
            int? page = default,
            int? limit = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}