#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// Delete an evaluation rule.<br/>
        /// This removes the live-ingestion rule only. It does not delete the referenced evaluator.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDeleteEvaluationRuleResponse> UnstableEvaluationRulesDeleteAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}