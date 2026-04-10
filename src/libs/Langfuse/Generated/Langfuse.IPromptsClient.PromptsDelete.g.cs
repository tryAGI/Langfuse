#nullable enable

namespace Langfuse
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete prompt versions. If neither version nor label is specified, all versions of the prompt are deleted.
        /// </summary>
        /// <param name="promptName"></param>
        /// <param name="label"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task PromptsDeleteAsync(
            string promptName,
            string? label = default,
            int? version = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}