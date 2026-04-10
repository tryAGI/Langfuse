#nullable enable

namespace Langfuse
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete an API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ApiKeyDeletionResponse> ProjectsDeleteApiKeyAsync(
            string projectId,
            string apiKeyId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}