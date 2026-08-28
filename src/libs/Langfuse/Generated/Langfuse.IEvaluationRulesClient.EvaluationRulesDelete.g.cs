#nullable enable

namespace Langfuse
{
    public partial interface IEvaluationRulesClient
    {
        /// <summary>
        /// Delete an evaluation rule.<br/>
        /// This removes the live-ingestion rule only. It does not delete associated evaluators or scores already produced by them.<br/>
        /// Legacy trace and dataset rules can also be deleted. Their evaluators and previously produced scores are preserved.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeletedEvaluationRule> EvaluationRulesDeleteAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an evaluation rule.<br/>
        /// This removes the live-ingestion rule only. It does not delete associated evaluators or scores already produced by them.<br/>
        /// Legacy trace and dataset rules can also be deleted. Their evaluators and previously produced scores are preserved.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.DeletedEvaluationRule>> EvaluationRulesDeleteAsResponseAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}