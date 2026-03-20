#nullable enable

namespace Langfuse
{
    public partial interface ILegacyObservationsV1Client
    {
        /// <summary>
        /// Get a observation
        /// </summary>
        /// <param name="observationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ObservationsView> LegacyObservationsV1GetAsync(
            string observationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}