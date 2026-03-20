#nullable enable

namespace Langfuse
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Get a dataset item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DatasetItem> DatasetItemsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}