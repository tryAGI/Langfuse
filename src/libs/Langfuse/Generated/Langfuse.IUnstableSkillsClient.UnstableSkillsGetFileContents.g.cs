#nullable enable

namespace Langfuse
{
    public partial interface IUnstableSkillsClient
    {
        /// <summary>
        /// Read a batch of text contents by canonical base64-encoded SHA-256 hashes.
        /// </summary>
        /// <param name="sha256Hashes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableSkillFileContentsResponse> UnstableSkillsGetFileContentsAsync(
            string sha256Hashes,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read a batch of text contents by canonical base64-encoded SHA-256 hashes.
        /// </summary>
        /// <param name="sha256Hashes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableSkillFileContentsResponse>> UnstableSkillsGetFileContentsAsResponseAsync(
            string sha256Hashes,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}