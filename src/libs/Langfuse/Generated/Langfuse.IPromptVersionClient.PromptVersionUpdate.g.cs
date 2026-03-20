#nullable enable

namespace Langfuse
{
    public partial interface IPromptVersionClient
    {
        /// <summary>
        /// Update labels for a specific prompt version
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Prompt> PromptVersionUpdateAsync(
            string name,
            int version,

            global::Langfuse.PromptVersionUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update labels for a specific prompt version
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="newLabels">
        /// New labels for the prompt version. Labels are unique across versions. The "latest" label is reserved and managed by Langfuse.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Prompt> PromptVersionUpdateAsync(
            string name,
            int version,
            global::System.Collections.Generic.IList<string> newLabels,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}