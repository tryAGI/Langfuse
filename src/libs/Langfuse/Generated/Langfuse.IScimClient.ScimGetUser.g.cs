#nullable enable

namespace Langfuse
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get a specific user by ID (requires organization-scoped API key)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ScimUser> ScimGetUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}