#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluatorsClient
    {
        /// <summary>
        /// Delete an evaluator.<br/>
        /// Important behavior:<br/>
        /// - This deletes the evaluator including all of its stored versions.<br/>
        /// - Evaluation rule assignments referencing the evaluator are also deleted.<br/>
        /// - Scores already produced by the evaluator are not deleted.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDeleteEvaluatorResponse> UnstableEvaluatorsDeleteAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an evaluator.<br/>
        /// Important behavior:<br/>
        /// - This deletes the evaluator including all of its stored versions.<br/>
        /// - Evaluation rule assignments referencing the evaluator are also deleted.<br/>
        /// - Scores already produced by the evaluator are not deleted.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDeleteEvaluatorResponse>> UnstableEvaluatorsDeleteAsResponseAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}