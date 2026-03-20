#nullable enable

namespace Langfuse
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project by ID (requires organization-scoped API key). Project deletion is processed asynchronously.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ProjectDeletionResponse> ProjectsDeleteAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}