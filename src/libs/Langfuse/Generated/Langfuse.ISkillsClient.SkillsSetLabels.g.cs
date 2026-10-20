#nullable enable

namespace Langfuse
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Replace the labels on a skill version and atomically move them from other versions.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SkillVersion> SkillsSetLabelsAsync(
            string skillName,
            int skillVersion,

            global::Langfuse.UpdateSkillLabelsRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the labels on a skill version and atomically move them from other versions.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.SkillVersion>> SkillsSetLabelsAsResponseAsync(
            string skillName,
            int skillVersion,

            global::Langfuse.UpdateSkillLabelsRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the labels on a skill version and atomically move them from other versions.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillVersion"></param>
        /// <param name="labels"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SkillVersion> SkillsSetLabelsAsync(
            string skillName,
            int skillVersion,
            global::System.Collections.Generic.IList<string> labels,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}