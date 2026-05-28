#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluatorsClient
    {
        /// <summary>
        /// List the evaluators available to the authenticated project.<br/>
        /// Important behavior:<br/>
        /// - This endpoint returns the latest version of each available evaluator.<br/>
        /// - Results can include evaluators from your project and Langfuse-managed evaluators.<br/>
        /// - If the same evaluator name exists in both places, both are returned as separate items with different `scope` values.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluators> UnstableEvaluatorsListAsync(
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the evaluators available to the authenticated project.<br/>
        /// Important behavior:<br/>
        /// - This endpoint returns the latest version of each available evaluator.<br/>
        /// - Results can include evaluators from your project and Langfuse-managed evaluators.<br/>
        /// - If the same evaluator name exists in both places, both are returned as separate items with different `scope` values.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluators>> UnstableEvaluatorsListAsResponseAsync(
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}