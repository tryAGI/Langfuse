#nullable enable

namespace Langfuse
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Dataset> DatasetsGetAsync(
            string datasetName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}