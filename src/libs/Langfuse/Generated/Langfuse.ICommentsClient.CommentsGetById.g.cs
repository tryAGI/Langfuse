#nullable enable

namespace Langfuse
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get a comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Comment> CommentsGetByIdAsync(
            string commentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}