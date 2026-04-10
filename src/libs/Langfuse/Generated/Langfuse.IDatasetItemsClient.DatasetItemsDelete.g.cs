#nullable enable

namespace Langfuse
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Delete a dataset item and all its run items. This action is irreversible.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteDatasetItemResponse> DatasetItemsDeleteAsync(
            string id,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}