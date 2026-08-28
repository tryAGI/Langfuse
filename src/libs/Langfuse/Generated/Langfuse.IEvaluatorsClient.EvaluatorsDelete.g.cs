#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Delete an evaluator and all of its stored versions.<br/>
        /// Associated evaluation-rule assignments are also removed. Scores already produced by the evaluator are preserved.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeletedEvaluator> EvaluatorsDeleteAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an evaluator and all of its stored versions.<br/>
        /// Associated evaluation-rule assignments are also removed. Scores already produced by the evaluator are preserved.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.DeletedEvaluator>> EvaluatorsDeleteAsResponseAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}