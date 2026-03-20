#nullable enable

namespace Langfuse
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Get the sync status of a blob storage integration by integration ID (requires organization-scoped API key)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.BlobStorageIntegrationStatusResponse> BlobStorageIntegrationsGetBlobStorageIntegrationStatusAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}