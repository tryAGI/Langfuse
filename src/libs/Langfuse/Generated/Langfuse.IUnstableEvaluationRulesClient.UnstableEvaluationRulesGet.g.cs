#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// Get one evaluation rule by its identifier.<br/>
        /// Use this endpoint to inspect the current evaluator, target, mapping, filters, execution timing, and effective runtime status. Legacy `trace` and `dataset` rules are returned for migration and are read-only through this API.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableReadableEvaluationRule> UnstableEvaluationRulesGetAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get one evaluation rule by its identifier.<br/>
        /// Use this endpoint to inspect the current evaluator, target, mapping, filters, execution timing, and effective runtime status. Legacy `trace` and `dataset` rules are returned for migration and are read-only through this API.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableReadableEvaluationRule>> UnstableEvaluationRulesGetAsResponseAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}