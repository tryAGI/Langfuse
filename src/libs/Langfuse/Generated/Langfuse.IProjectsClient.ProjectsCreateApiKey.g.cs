#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ApiKeyResponse> ProjectsCreateApiKeyAsync(
            string projectId,

            global::Langfuse.ProjectsCreateApiKeyRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ApiKeyResponse>> ProjectsCreateApiKeyAsResponseAsync(
            string projectId,

            global::Langfuse.ProjectsCreateApiKeyRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Optional name for the API key. Cannot be provided together with note, even if either value is an empty string.
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration timestamp in ISO 8601 format. Must be in the future. Omit or set to null for a key that does not expire.
        /// </param>
        /// <param name="publicKey">
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </param>
        /// <param name="secretKey">
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ApiKeyResponse> ProjectsCreateApiKeyAsync(
            string projectId,
            string? name = default,
            global::System.DateTime? expiresAt = default,
            string? publicKey = default,
            string? secretKey = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}