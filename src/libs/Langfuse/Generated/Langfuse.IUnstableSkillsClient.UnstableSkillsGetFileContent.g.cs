#nullable enable

namespace Langfuse
{
    public partial interface IUnstableSkillsClient
    {
        /// <summary>
        /// Read one text file from a persisted skill version using its file id, not its blob id. Returns JSON containing the text content with Cache-Control no-store.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableSkillFileContentResponse> UnstableSkillsGetFileContentAsync(
            string fileId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read one text file from a persisted skill version using its file id, not its blob id. Returns JSON containing the text content with Cache-Control no-store.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableSkillFileContentResponse>> UnstableSkillsGetFileContentAsResponseAsync(
            string fileId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}