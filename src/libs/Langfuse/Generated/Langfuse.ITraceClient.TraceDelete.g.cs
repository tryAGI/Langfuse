#nullable enable

namespace Langfuse
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Delete a specific trace
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteTraceResponse> TraceDeleteAsync(
            string traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}