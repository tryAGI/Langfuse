#nullable enable

namespace Langfuse
{
    public partial interface IEvaluationRulesClient
    {
        /// <summary>
        /// Get one evaluation rule, including a legacy trace or dataset rule, by its stable identifier.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRule> EvaluationRulesGetAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get one evaluation rule, including a legacy trace or dataset rule, by its stable identifier.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluationRule>> EvaluationRulesGetAsResponseAsync(
            string evaluationRuleId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}