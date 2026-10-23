#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the project's Topics facets. Only active facets (attached to the<br/>
        /// project's Topics rule, or all facets if the project has no rule) are<br/>
        /// returned unless `filter` contains an `active` condition.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `id` (stringOptions),<br/>
        /// `name` (string, stringOptions), `description` (string), `isBuiltIn`<br/>
        /// (boolean), `active` (boolean).
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicFacetList> UnstableTopicsListFacetsAsync(
            string? filter = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the project's Topics facets. Only active facets (attached to the<br/>
        /// project's Topics rule, or all facets if the project has no rule) are<br/>
        /// returned unless `filter` contains an `active` condition.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `id` (stringOptions),<br/>
        /// `name` (string, stringOptions), `description` (string), `isBuiltIn`<br/>
        /// (boolean), `active` (boolean).
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicFacetList>> UnstableTopicsListFacetsAsResponseAsync(
            string? filter = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}