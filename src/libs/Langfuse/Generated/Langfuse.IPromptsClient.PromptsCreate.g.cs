#nullable enable

namespace Langfuse
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a new version for the prompt with the given `name`
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Prompt> PromptsCreateAsync(

            global::Langfuse.CreatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new version for the prompt with the given `name`
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Prompt> PromptsCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}