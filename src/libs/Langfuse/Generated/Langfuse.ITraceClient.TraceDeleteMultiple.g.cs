#nullable enable

namespace Langfuse
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Delete multiple traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteTraceResponse> TraceDeleteMultipleAsync(

            global::Langfuse.TraceDeleteMultipleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete multiple traces
        /// </summary>
        /// <param name="traceIds">
        /// List of trace IDs to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteTraceResponse> TraceDeleteMultipleAsync(
            global::System.Collections.Generic.IList<string> traceIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}