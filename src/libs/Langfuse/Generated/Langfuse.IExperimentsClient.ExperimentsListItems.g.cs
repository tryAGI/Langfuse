#nullable enable

namespace Langfuse
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// List experiment items with cursor-based pagination. Use this endpoint<br/>
        /// to export experiment item inputs, outputs, expected outputs, metadata,<br/>
        /// and optionally item/trace scores. Results are ordered by time<br/>
        /// descending.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="limit"></param>
        /// <param name="scoreLimit"></param>
        /// <param name="cursor"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="experimentId"></param>
        /// <param name="experimentName"></param>
        /// <param name="experimentItemId"></param>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ExperimentItemsResponse> ExperimentsListItemsAsync(
            global::System.DateTime fromStartTime,
            string? fields = default,
            int? limit = default,
            int? scoreLimit = default,
            string? cursor = default,
            global::System.DateTime? toStartTime = default,
            string? experimentId = default,
            string? experimentName = default,
            string? experimentItemId = default,
            string? datasetId = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List experiment items with cursor-based pagination. Use this endpoint<br/>
        /// to export experiment item inputs, outputs, expected outputs, metadata,<br/>
        /// and optionally item/trace scores. Results are ordered by time<br/>
        /// descending.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="limit"></param>
        /// <param name="scoreLimit"></param>
        /// <param name="cursor"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="experimentId"></param>
        /// <param name="experimentName"></param>
        /// <param name="experimentItemId"></param>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ExperimentItemsResponse>> ExperimentsListItemsAsResponseAsync(
            global::System.DateTime fromStartTime,
            string? fields = default,
            int? limit = default,
            int? scoreLimit = default,
            string? cursor = default,
            global::System.DateTime? toStartTime = default,
            string? experimentId = default,
            string? experimentName = default,
            string? experimentItemId = default,
            string? datasetId = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}