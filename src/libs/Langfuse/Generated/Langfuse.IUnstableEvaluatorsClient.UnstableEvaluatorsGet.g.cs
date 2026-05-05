#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluatorsClient
    {
        /// <summary>
        /// Get one evaluator by `id`.<br/>
        /// Use this endpoint when you want the prompt, output definition, model configuration, and derived variables for the evaluator you plan to use in an evaluation rule.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluator> UnstableEvaluatorsGetAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get one evaluator by `id`.<br/>
        /// Use this endpoint when you want the prompt, output definition, model configuration, and derived variables for the evaluator you plan to use in an evaluation rule.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluator>> UnstableEvaluatorsGetAsResponseAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}