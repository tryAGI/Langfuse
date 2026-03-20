#nullable enable

namespace Langfuse
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List users in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ScimUsersListResponse> ScimListUsersAsync(
            string? filter = default,
            int? startIndex = default,
            int? count = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}