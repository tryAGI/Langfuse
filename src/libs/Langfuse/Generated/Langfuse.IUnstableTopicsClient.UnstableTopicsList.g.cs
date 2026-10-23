#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the topics of each active facet's current published map, with<br/>
        /// the number of traces currently assigned to each topic in the window.<br/>
        /// Retired topics are not listed. `facets` holds per-facet trace counts<br/>
        /// by topic status.<br/>
        /// The window applies to the trace start time. It defaults to the last<br/>
        /// 7 days and can span at most 93 days.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `facetId`<br/>
        /// (stringOptions), `facetName` (string, stringOptions), `id`<br/>
        /// (stringOptions), `name` (string, stringOptions). Facet conditions also<br/>
        /// restrict `facets`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicList> UnstableTopicsListAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            global::Langfuse.UnstableTopicsOrderBy? orderBy = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the topics of each active facet's current published map, with<br/>
        /// the number of traces currently assigned to each topic in the window.<br/>
        /// Retired topics are not listed. `facets` holds per-facet trace counts<br/>
        /// by topic status.<br/>
        /// The window applies to the trace start time. It defaults to the last<br/>
        /// 7 days and can span at most 93 days.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND.<br/>
        /// String matching is case-insensitive. Columns: `facetId`<br/>
        /// (stringOptions), `facetName` (string, stringOptions), `id`<br/>
        /// (stringOptions), `name` (string, stringOptions). Facet conditions also<br/>
        /// restrict `facets`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicList>> UnstableTopicsListAsResponseAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            global::Langfuse.UnstableTopicsOrderBy? orderBy = default,
            int? page = default,
            int? limit = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}