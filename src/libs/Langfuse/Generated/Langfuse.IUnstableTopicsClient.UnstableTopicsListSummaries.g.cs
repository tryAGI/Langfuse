#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the current Topics summary per trace and facet: what the trace<br/>
        /// is about from the facet's perspective. Summaries are shared by all<br/>
        /// rules. A trace that was re-summarized lists only its latest summary.<br/>
        /// The window applies to the trace start time. It defaults to the last<br/>
        /// 7 days and can span at most 30 days, starting no earlier than the<br/>
        /// plan's data access window. Without `fromTimestamp` and `toTimestamp`,<br/>
        /// a `traceId` `any of` filter reads the listed traces at their own start<br/>
        /// time within the last 93 days. Rows are ordered by trace start time.<br/>
        /// Each request scans a bounded number of candidate rows. A page shorter<br/>
        /// than `limit` (even an empty one) with a `meta.cursor` does not<br/>
        /// indicate completion; continue with the cursor until it is null.<br/>
        /// Only active facets (attached to a Topics rule, or all facets if the<br/>
        /// project has no rule) are read. Traces Topics never processed are not<br/>
        /// listed.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND, with<br/>
        /// at most 100 `traceId` values. Columns: `traceId`, `facetId`, `facetName`, `ruleId`, `environment`<br/>
        /// (stringOptions), `timestamp`, `processedAt` (datetime), `state`,<br/>
        /// `topicId`, `topicName` (stringOptions), `assignmentStatus`<br/>
        /// (stringOptions, `any of` only). An unknown `topicName` matches nothing under `any of`<br/>
        /// and is ignored under `none of`.<br/>
        /// `state` values: `complete` (summarized), `not_applicable` (the facet<br/>
        /// does not apply to the trace), `insufficient_input` (too little input<br/>
        /// to summarize). `assignmentStatus` values: `assigned`, `outlier` (no<br/>
        /// topic fits), `awaiting_map` (summarized, not yet assigned).<br/>
        /// Common questions:<br/>
        /// - Summaries of specific traces: `traceId` `any of` the trace ids.<br/>
        /// - Summaries of a topic's traces: `topicId` or `topicName`.<br/>
        /// - Traces without a topic yet: `assignmentStatus` `any of` `["awaiting_map", "outlier"]`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="truncateSummaries"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicSummaryList> UnstableTopicsListSummariesAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            bool? truncateSummaries = default,
            global::Langfuse.UnstableTopicResultsOrderBy? orderBy = default,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the current Topics summary per trace and facet: what the trace<br/>
        /// is about from the facet's perspective. Summaries are shared by all<br/>
        /// rules. A trace that was re-summarized lists only its latest summary.<br/>
        /// The window applies to the trace start time. It defaults to the last<br/>
        /// 7 days and can span at most 30 days, starting no earlier than the<br/>
        /// plan's data access window. Without `fromTimestamp` and `toTimestamp`,<br/>
        /// a `traceId` `any of` filter reads the listed traces at their own start<br/>
        /// time within the last 93 days. Rows are ordered by trace start time.<br/>
        /// Each request scans a bounded number of candidate rows. A page shorter<br/>
        /// than `limit` (even an empty one) with a `meta.cursor` does not<br/>
        /// indicate completion; continue with the cursor until it is null.<br/>
        /// Only active facets (attached to a Topics rule, or all facets if the<br/>
        /// project has no rule) are read. Traces Topics never processed are not<br/>
        /// listed.<br/>
        /// `filter` is a JSON array of filter conditions combined with AND, with<br/>
        /// at most 100 `traceId` values. Columns: `traceId`, `facetId`, `facetName`, `ruleId`, `environment`<br/>
        /// (stringOptions), `timestamp`, `processedAt` (datetime), `state`,<br/>
        /// `topicId`, `topicName` (stringOptions), `assignmentStatus`<br/>
        /// (stringOptions, `any of` only). An unknown `topicName` matches nothing under `any of`<br/>
        /// and is ignored under `none of`.<br/>
        /// `state` values: `complete` (summarized), `not_applicable` (the facet<br/>
        /// does not apply to the trace), `insufficient_input` (too little input<br/>
        /// to summarize). `assignmentStatus` values: `assigned`, `outlier` (no<br/>
        /// topic fits), `awaiting_map` (summarized, not yet assigned).<br/>
        /// Common questions:<br/>
        /// - Summaries of specific traces: `traceId` `any of` the trace ids.<br/>
        /// - Summaries of a topic's traces: `topicId` or `topicName`.<br/>
        /// - Traces without a topic yet: `assignmentStatus` `any of` `["awaiting_map", "outlier"]`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="truncateSummaries"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicSummaryList>> UnstableTopicsListSummariesAsResponseAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            bool? truncateSummaries = default,
            global::Langfuse.UnstableTopicResultsOrderBy? orderBy = default,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}