#nullable enable

namespace Langfuse
{
    public partial interface IUnstableSkillsClient
    {
        /// <summary>
        /// Delete one immutable skill version. Unreferenced blobs are retained for asynchronous cleanup.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableDeleteSkillVersionResponse> UnstableSkillsDeleteVersionAsync(
            string skillName,
            int skillVersion,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete one immutable skill version. Unreferenced blobs are retained for asynchronous cleanup.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableDeleteSkillVersionResponse>> UnstableSkillsDeleteVersionAsResponseAsync(
            string skillName,
            int skillVersion,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}