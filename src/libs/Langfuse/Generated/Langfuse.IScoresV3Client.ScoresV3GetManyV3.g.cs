#nullable enable

namespace Langfuse
{
    public partial interface IScoresV3Client
    {
        /// <summary>
        /// Get a list of scores with a polymorphic `value` field (v3).<br/>
        /// The `value` field type depends on `dataType`:<br/>
        /// - `NUMERIC` → number<br/>
        /// - `BOOLEAN` → boolean<br/>
        /// - `CATEGORICAL`, `TEXT`, `CORRECTION` → string<br/>
        /// The response always includes the core fields: id, projectId, name,<br/>
        /// value, dataType, source, timestamp, environment, createdAt, updatedAt.<br/>
        /// Additional field groups can be requested via the `fields` parameter:<br/>
        /// - `details` — adds comment, configId, metadata<br/>
        /// - `subject` — adds the subject object describing the entity the score<br/>
        ///   is attached to: kind (trace, observation, session, or experiment),<br/>
        ///   id, and traceId for observation-level scores<br/>
        /// - `annotation` — adds authorUserId, queueId<br/>
        /// Unknown group names return HTTP 400.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="fields"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="dataType"></param>
        /// <param name="environment"></param>
        /// <param name="configId"></param>
        /// <param name="queueId"></param>
        /// <param name="authorUserId"></param>
        /// <param name="value"></param>
        /// <param name="valueMin"></param>
        /// <param name="valueMax"></param>
        /// <param name="traceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="observationId"></param>
        /// <param name="experimentId"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetScoresV3Response> ScoresV3GetManyV3Async(
            int? limit = default,
            string? cursor = default,
            string? fields = default,
            string? id = default,
            string? name = default,
            string? source = default,
            string? dataType = default,
            string? environment = default,
            string? configId = default,
            string? queueId = default,
            string? authorUserId = default,
            string? value = default,
            double? valueMin = default,
            double? valueMax = default,
            string? traceId = default,
            string? sessionId = default,
            string? observationId = default,
            string? experimentId = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a list of scores with a polymorphic `value` field (v3).<br/>
        /// The `value` field type depends on `dataType`:<br/>
        /// - `NUMERIC` → number<br/>
        /// - `BOOLEAN` → boolean<br/>
        /// - `CATEGORICAL`, `TEXT`, `CORRECTION` → string<br/>
        /// The response always includes the core fields: id, projectId, name,<br/>
        /// value, dataType, source, timestamp, environment, createdAt, updatedAt.<br/>
        /// Additional field groups can be requested via the `fields` parameter:<br/>
        /// - `details` — adds comment, configId, metadata<br/>
        /// - `subject` — adds the subject object describing the entity the score<br/>
        ///   is attached to: kind (trace, observation, session, or experiment),<br/>
        ///   id, and traceId for observation-level scores<br/>
        /// - `annotation` — adds authorUserId, queueId<br/>
        /// Unknown group names return HTTP 400.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="fields"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="dataType"></param>
        /// <param name="environment"></param>
        /// <param name="configId"></param>
        /// <param name="queueId"></param>
        /// <param name="authorUserId"></param>
        /// <param name="value"></param>
        /// <param name="valueMin"></param>
        /// <param name="valueMax"></param>
        /// <param name="traceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="observationId"></param>
        /// <param name="experimentId"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetScoresV3Response>> ScoresV3GetManyV3AsResponseAsync(
            int? limit = default,
            string? cursor = default,
            string? fields = default,
            string? id = default,
            string? name = default,
            string? source = default,
            string? dataType = default,
            string? environment = default,
            string? configId = default,
            string? queueId = default,
            string? authorUserId = default,
            string? value = default,
            double? valueMin = default,
            double? valueMax = default,
            string? traceId = default,
            string? sessionId = default,
            string? observationId = default,
            string? experimentId = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}