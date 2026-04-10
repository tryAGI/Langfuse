#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete a membership from a specific project (requires organization-scoped API key). The user must be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipDeletionResponse> OrganizationsDeleteProjectMembershipAsync(
            string projectId,

            global::Langfuse.DeleteMembershipRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a membership from a specific project (requires organization-scoped API key). The user must be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.MembershipDeletionResponse> OrganizationsDeleteProjectMembershipAsync(
            string projectId,
            string userId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}