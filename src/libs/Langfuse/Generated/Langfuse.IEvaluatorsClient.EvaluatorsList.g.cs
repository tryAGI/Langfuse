#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// List evaluators in newest-first creation order.<br/>
        /// Every evaluator includes its latest definition and version metadata flattened into the evaluator object, plus associated evaluation rules. Treat the cursor as opaque and return it unchanged.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluatorsPage> EvaluatorsListAsync(
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List evaluators in newest-first creation order.<br/>
        /// Every evaluator includes its latest definition and version metadata flattened into the evaluator object, plus associated evaluation rules. Treat the cursor as opaque and return it unchanged.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluatorsPage>> EvaluatorsListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}