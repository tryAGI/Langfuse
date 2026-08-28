#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// List an evaluator's version history in newest-first order.<br/>
        /// This endpoint is intended for history and audit use cases. Ordinary clients can use the flattened `version` and definition fields on the evaluator response.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluatorVersionsPage> EvaluatorsListVersionsAsync(
            string evaluatorId,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List an evaluator's version history in newest-first order.<br/>
        /// This endpoint is intended for history and audit use cases. Ordinary clients can use the flattened `version` and definition fields on the evaluator response.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluatorVersionsPage>> EvaluatorsListVersionsAsResponseAsync(
            string evaluatorId,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}