#nullable enable

namespace Langfuse
{
    public partial interface IEvaluationRulesClient
    {
        /// <summary>
        /// List evaluation rules in newest-first creation order.<br/>
        /// This includes legacy trace and dataset rules so they can be inspected and migrated. Treat the cursor as opaque and return it unchanged.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRulesPage> EvaluationRulesListAsync(
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List evaluation rules in newest-first creation order.<br/>
        /// This includes legacy trace and dataset rules so they can be inspected and migrated. Treat the cursor as opaque and return it unchanged.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluationRulesPage>> EvaluationRulesListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}