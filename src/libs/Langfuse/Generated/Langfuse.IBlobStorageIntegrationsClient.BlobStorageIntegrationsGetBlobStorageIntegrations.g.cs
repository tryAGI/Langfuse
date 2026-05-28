#nullable enable

namespace Langfuse
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Get all blob storage integrations for the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.BlobStorageIntegrationsResponse> BlobStorageIntegrationsGetBlobStorageIntegrationsAsync(
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all blob storage integrations for the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.BlobStorageIntegrationsResponse>> BlobStorageIntegrationsGetBlobStorageIntegrationsAsResponseAsync(
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}