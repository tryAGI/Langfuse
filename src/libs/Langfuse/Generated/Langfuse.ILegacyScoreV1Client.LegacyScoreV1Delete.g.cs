#nullable enable

namespace Langfuse
{
    public partial interface ILegacyScoreV1Client
    {
        /// <summary>
        /// Delete a score (supports both trace and session scores)
        /// </summary>
        /// <param name="scoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task LegacyScoreV1DeleteAsync(
            string scoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}