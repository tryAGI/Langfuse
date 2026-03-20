#nullable enable

namespace Langfuse
{
    public partial interface IScoreConfigsClient
    {
        /// <summary>
        /// Get a score config
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ScoreConfig> ScoreConfigsGetByIdAsync(
            string configId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}