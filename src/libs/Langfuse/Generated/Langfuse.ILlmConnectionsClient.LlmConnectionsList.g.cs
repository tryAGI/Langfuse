#nullable enable

namespace Langfuse
{
    public partial interface ILlmConnectionsClient
    {
        /// <summary>
        /// Get all LLM connections in a project
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.PaginatedLlmConnections> LlmConnectionsListAsync(
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}