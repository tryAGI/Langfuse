#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or update a membership for the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipResponse> OrganizationsUpdateOrganizationMembershipAsync(

            global::Langfuse.MembershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update a membership for the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipResponse> OrganizationsUpdateOrganizationMembershipAsync(
            string userId,
            global::Langfuse.MembershipRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}