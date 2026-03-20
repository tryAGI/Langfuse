#nullable enable

namespace Langfuse
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset runs
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.PaginatedDatasetRuns> DatasetsGetRunsAsync(
            string datasetName,
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}