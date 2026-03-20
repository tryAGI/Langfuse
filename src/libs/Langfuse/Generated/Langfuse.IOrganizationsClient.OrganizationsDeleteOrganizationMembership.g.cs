#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete a membership from the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipDeletionResponse> OrganizationsDeleteOrganizationMembershipAsync(

            global::Langfuse.DeleteMembershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a membership from the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipDeletionResponse> OrganizationsDeleteOrganizationMembershipAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}