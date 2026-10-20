#nullable enable

namespace Langfuse
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Replace the shared tags across all versions of a skill. An empty tags list clears all tags. Returns the latest skill version with the updated tags.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SkillVersion> SkillsUpdateAsync(
            string skillName,

            global::Langfuse.UpdateSkillRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the shared tags across all versions of a skill. An empty tags list clears all tags. Returns the latest skill version with the updated tags.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.SkillVersion>> SkillsUpdateAsResponseAsync(
            string skillName,

            global::Langfuse.UpdateSkillRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the shared tags across all versions of a skill. An empty tags list clears all tags. Returns the latest skill version with the updated tags.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="tags">
        /// The complete set of tags to apply to every version of the skill. Pass an empty list to clear all tags.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SkillVersion> SkillsUpdateAsync(
            string skillName,
            global::System.Collections.Generic.IList<string> tags,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}