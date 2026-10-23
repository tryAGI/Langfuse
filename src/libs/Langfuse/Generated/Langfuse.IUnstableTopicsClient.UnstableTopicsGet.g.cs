#nullable enable

namespace Langfuse
{
    public partial interface IUnstableTopicsClient
    {
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// Get one topic by its stable id. Topics on the current map are always<br/>
        /// found. A retired topic is found while traces in the window are still<br/>
        /// assigned to it, with `inCurrentMap: false`.
        /// </summary>
        /// <param name="topicId"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableTopicWithStatus> UnstableTopicsGetAsync(
            string topicId,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unstable: Topics is in closed beta. The shape may change without notice.<br/>
        /// Get one topic by its stable id. Topics on the current map are always<br/>
        /// found. A retired topic is found while traces in the window are still<br/>
        /// assigned to it, with `inCurrentMap: false`.
        /// </summary>
        /// <param name="topicId"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableTopicWithStatus>> UnstableTopicsGetAsResponseAsync(
            string topicId,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}