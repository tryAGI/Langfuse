#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// List evaluation rules in the authenticated project.<br/>
        /// Each item describes one live evaluation rule and its effective runtime status.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRules> UnstableEvaluationRulesListAsync(
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}