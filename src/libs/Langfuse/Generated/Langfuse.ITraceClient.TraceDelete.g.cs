#nullable enable

namespace Langfuse
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Delete a specific trace
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteTraceResponse> TraceDeleteAsync(
            string traceId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}