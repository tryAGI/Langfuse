#nullable enable

namespace Langfuse
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete a dataset run and all its run items. This action is irreversible.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="runName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteDatasetRunResponse> DatasetsDeleteRunAsync(
            string datasetName,
            string runName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}