#nullable enable

namespace Langfuse
{
    public partial interface IUnstableSkillsClient
    {
        /// <summary>
        /// Resolve a skill's metadata and file manifest by version or label. Defaults to the production label. Use each file's id with getFileContent to read its text content.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableSkillVersion> UnstableSkillsGetAsync(
            string skillName,
            int? version = default,
            string? label = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a skill's metadata and file manifest by version or label. Defaults to the production label. Use each file's id with getFileContent to read its text content.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableSkillVersion>> UnstableSkillsGetAsResponseAsync(
            string skillName,
            int? version = default,
            string? label = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}