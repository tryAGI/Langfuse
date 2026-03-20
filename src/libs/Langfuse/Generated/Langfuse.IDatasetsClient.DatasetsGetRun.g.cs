#nullable enable

namespace Langfuse
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset run and its items
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="runName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DatasetRunWithItems> DatasetsGetRunAsync(
            string datasetName,
            string runName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}