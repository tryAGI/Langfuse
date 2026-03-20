#nullable enable

namespace Langfuse
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Resource Types (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ResourceTypesResponse> ScimGetResourceTypesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}