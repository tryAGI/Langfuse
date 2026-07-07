#nullable enable

namespace Langfuse
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// List experiments with cursor-based pagination. Results are ordered by<br/>
        /// latest experiment activity descending.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="limit"></param>
        /// <param name="scoreLimit"></param>
        /// <param name="cursor"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ExperimentsResponse> ExperimentsListAsync(
            global::System.DateTime fromStartTime,
            string? fields = default,
            int? limit = default,
            int? scoreLimit = default,
            string? cursor = default,
            global::System.DateTime? toStartTime = default,
            string? id = default,
            string? name = default,
            string? datasetId = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List experiments with cursor-based pagination. Results are ordered by<br/>
        /// latest experiment activity descending.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="limit"></param>
        /// <param name="scoreLimit"></param>
        /// <param name="cursor"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ExperimentsResponse>> ExperimentsListAsResponseAsync(
            global::System.DateTime fromStartTime,
            string? fields = default,
            int? limit = default,
            int? scoreLimit = default,
            string? cursor = default,
            global::System.DateTime? toStartTime = default,
            string? id = default,
            string? name = default,
            string? datasetId = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}