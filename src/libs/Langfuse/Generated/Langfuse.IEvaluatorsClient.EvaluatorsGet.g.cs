#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Get one evaluator by its stable identifier.<br/>
        /// The response includes the evaluator's latest definition and version metadata flattened into the evaluator object, plus associated evaluation rules. Use the version-history endpoint when older definitions are needed.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Evaluator> EvaluatorsGetAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get one evaluator by its stable identifier.<br/>
        /// The response includes the evaluator's latest definition and version metadata flattened into the evaluator object, plus associated evaluation rules. Use the version-history endpoint when older definitions are needed.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.Evaluator>> EvaluatorsGetAsResponseAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}