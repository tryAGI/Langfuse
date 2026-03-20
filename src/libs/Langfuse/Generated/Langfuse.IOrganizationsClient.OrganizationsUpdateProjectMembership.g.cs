#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or update a membership for a specific project (requires organization-scoped API key). The user must already be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipResponse> OrganizationsUpdateProjectMembershipAsync(
            string projectId,

            global::Langfuse.MembershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a membership for a specific project (requires organization-scoped API key). The user must already be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipResponse> OrganizationsUpdateProjectMembershipAsync(
            string projectId,
            string userId,
            global::Langfuse.MembershipRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}