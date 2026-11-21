#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the project's Topics rules. A rule selects traces with an<br/>
        /// observation filter and a sampling rate, runs the facets in `facetIds`<br/>
        /// and keeps its own live topic map.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `id` (stringOptions),<br/>
        /// `name` (string, stringOptions).
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicRuleList> UnstableTopicsListRulesAsync(
            string? filter = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the project's Topics rules. A rule selects traces with an<br/>
        /// observation filter and a sampling rate, runs the facets in `facetIds`<br/>
        /// and keeps its own live topic map.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `id` (stringOptions),<br/>
        /// `name` (string, stringOptions).
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicRuleList>> UnstableTopicsListRulesAsResponseAsync(
            string? filter = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}