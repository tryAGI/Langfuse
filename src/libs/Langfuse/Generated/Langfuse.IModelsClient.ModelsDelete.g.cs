#nullable enable

namespace Langfuse
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a model. Cannot delete models managed by Langfuse. You can create your own definition with the same modelName to override the definition though.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task ModelsDeleteAsync(
            string id,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}