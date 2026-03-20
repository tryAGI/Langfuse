#nullable enable

namespace Langfuse
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Get a specific trace
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.TraceWithFullDetails> TraceGetAsync(
            string traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}