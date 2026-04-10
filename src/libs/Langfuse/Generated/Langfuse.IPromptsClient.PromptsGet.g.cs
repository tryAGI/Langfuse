#nullable enable

namespace Langfuse
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a prompt
        /// </summary>
        /// <param name="promptName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="resolve"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Prompt> PromptsGetAsync(
            string promptName,
            int? version = default,
            string? label = default,
            bool? resolve = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}