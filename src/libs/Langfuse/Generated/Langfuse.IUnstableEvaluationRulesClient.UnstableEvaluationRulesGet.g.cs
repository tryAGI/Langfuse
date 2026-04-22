#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// Get one evaluation rule by its identifier.<br/>
        /// Use this endpoint to inspect the current evaluator, target, mapping, filters, and effective runtime status.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesGetAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}