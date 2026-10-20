#nullable enable

namespace Langfuse
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Resolve a skill's metadata and file manifest by version or label. Defaults to the production label. Set includeContent to return file contents inline, or use each file's sha256Hash with getFileContents.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="includeContent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SkillVersion> SkillsGetAsync(
            string skillName,
            int? version = default,
            string? label = default,
            bool? includeContent = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a skill's metadata and file manifest by version or label. Defaults to the production label. Set includeContent to return file contents inline, or use each file's sha256Hash with getFileContents.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="includeContent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.SkillVersion>> SkillsGetAsResponseAsync(
            string skillName,
            int? version = default,
            string? label = default,
            bool? includeContent = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}