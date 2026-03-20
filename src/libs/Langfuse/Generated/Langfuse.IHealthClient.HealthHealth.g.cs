#nullable enable

namespace Langfuse
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check health of API and database
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.HealthResponse> HealthHealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}