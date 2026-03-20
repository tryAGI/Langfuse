#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all memberships for a specific project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipsResponse> OrganizationsGetProjectMembershipsAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}