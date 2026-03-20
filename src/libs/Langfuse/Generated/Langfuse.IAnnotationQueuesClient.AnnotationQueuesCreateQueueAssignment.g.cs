#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.CreateAnnotationQueueAssignmentResponse> AnnotationQueuesCreateQueueAssignmentAsync(
            string queueId,

            global::Langfuse.AnnotationQueueAssignmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.CreateAnnotationQueueAssignmentResponse> AnnotationQueuesCreateQueueAssignmentAsync(
            string queueId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}