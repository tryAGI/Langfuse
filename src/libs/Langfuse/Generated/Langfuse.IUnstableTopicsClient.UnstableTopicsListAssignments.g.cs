#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the current topic per trace, facet and rule on each rule's live<br/>
        /// map: `assigned` with its topic, or `outlier` when no topic fits.<br/>
        /// Summarized traces that are not assigned yet are not listed; find<br/>
        /// them through `GET /topic-summaries` with `assignmentStatus`.<br/>
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
        /// at most 100 `traceId` values. Columns: `traceId`, `facetId`, `facetName`, `ruleId`, `environment`,<br/>
        /// `topicId`, `topicName` (stringOptions), `status` (stringOptions,<br/>
        /// `any of` only: `assigned`, `outlier`), `timestamp` (datetime). An<br/>
        /// unknown `topicName` matches nothing under `any of` and is ignored<br/>
        /// under `none of`.<br/>
        /// Common questions:<br/>
        /// - Topics of specific traces: `traceId` `any of` the trace ids.<br/>
        /// - Traces in a topic: `topicId` or `topicName`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicAssignmentList> UnstableTopicsListAssignmentsAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            global::Langfuse.UnstableTopicResultsOrderBy? orderBy = default,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// List the current topic per trace, facet and rule on each rule's live<br/>
        /// map: `assigned` with its topic, or `outlier` when no topic fits.<br/>
        /// Summarized traces that are not assigned yet are not listed; find<br/>
        /// them through `GET /topic-summaries` with `assignmentStatus`.<br/>
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
        /// at most 100 `traceId` values. Columns: `traceId`, `facetId`, `facetName`, `ruleId`, `environment`,<br/>
        /// `topicId`, `topicName` (stringOptions), `status` (stringOptions,<br/>
        /// `any of` only: `assigned`, `outlier`), `timestamp` (datetime). An<br/>
        /// unknown `topicName` matches nothing under `any of` and is ignored<br/>
        /// under `none of`.<br/>
        /// Common questions:<br/>
        /// - Topics of specific traces: `traceId` `any of` the trace ids.<br/>
        /// - Traces in a topic: `topicId` or `topicName`.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicAssignmentList>> UnstableTopicsListAssignmentsAsResponseAsync(
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? filter = default,
            global::Langfuse.UnstableTopicResultsOrderBy? orderBy = default,
            int? limit = default,
            string? cursor = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}