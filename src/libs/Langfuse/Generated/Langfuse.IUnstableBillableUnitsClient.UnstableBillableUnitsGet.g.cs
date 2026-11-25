#nullable enable

namespace Langfuse
{
    public partial interface IUnstableBillableUnitsClient
    {
        /// <summary>
        /// Unstable: the shape may change without notice.<br/>
        /// Billable units of the organization's projects, per UTC time bucket and<br/>
        /// project. These are the numbers of the organization's Usage settings<br/>
        /// tab. Requires an organization-scoped API key.<br/>
        /// Units are counted by ingestion time in `[fromTimestamp, toTimestamp)`<br/>
        /// as approximate distinct units per bucket (about 0.3% error on large<br/>
        /// counts, small counts are exact). A unit counts once in every bucket it<br/>
        /// appears in, so the counts stay close to, but are not exactly, what is<br/>
        /// billed. Deployments still in the v3 `legacy` write mode count the rows<br/>
        /// of the traces, observations and scores tables instead.<br/>
        /// Buckets start at UTC hour, day, Monday or month boundaries. The first<br/>
        /// and last bucket cover only the part inside the range, and a<br/>
        /// `toTimestamp` in the future is cut off at now. Buckets and projects<br/>
        /// without usage are left out, and so are deleted projects.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="granularity"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableBillableUnitsResponse> UnstableBillableUnitsGetAsync(
            global::System.DateTime fromTimestamp,
            global::System.DateTime toTimestamp,
            global::Langfuse.UnstableBillableUnitsGranularity? granularity = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: the shape may change without notice.<br/>
        /// Billable units of the organization's projects, per UTC time bucket and<br/>
        /// project. These are the numbers of the organization's Usage settings<br/>
        /// tab. Requires an organization-scoped API key.<br/>
        /// Units are counted by ingestion time in `[fromTimestamp, toTimestamp)`<br/>
        /// as approximate distinct units per bucket (about 0.3% error on large<br/>
        /// counts, small counts are exact). A unit counts once in every bucket it<br/>
        /// appears in, so the counts stay close to, but are not exactly, what is<br/>
        /// billed. Deployments still in the v3 `legacy` write mode count the rows<br/>
        /// of the traces, observations and scores tables instead.<br/>
        /// Buckets start at UTC hour, day, Monday or month boundaries. The first<br/>
        /// and last bucket cover only the part inside the range, and a<br/>
        /// `toTimestamp` in the future is cut off at now. Buckets and projects<br/>
        /// without usage are left out, and so are deleted projects.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="granularity"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableBillableUnitsResponse>> UnstableBillableUnitsGetAsResponseAsync(
            global::System.DateTime fromTimestamp,
            global::System.DateTime toTimestamp,
            global::Langfuse.UnstableBillableUnitsGranularity? granularity = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}