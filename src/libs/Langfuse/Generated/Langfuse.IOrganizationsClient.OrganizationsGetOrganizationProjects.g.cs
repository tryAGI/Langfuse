#nullable enable

namespace Langfuse
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all projects for the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.OrganizationProjectsResponse> OrganizationsGetOrganizationProjectsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}