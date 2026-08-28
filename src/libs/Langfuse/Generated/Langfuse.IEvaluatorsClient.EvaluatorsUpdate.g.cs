#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Update an evaluator by its stable identifier.<br/>
        /// Provide only the top-level fields to change. Metadata-only changes do not create a version. Evaluator type cannot change.<br/>
        /// Definition fields are flattened into the request. To replace a definition, include `type` and every definition field for that type. Definition fields are replaced as a complete unit rather than merged. For LLM-as-a-judge evaluators, omitting or setting `modelConfig` to `null` selects the project's default evaluation model.<br/>
        /// Replacing a definition automatically returns an evaluator paused by an invalid or missing model configuration to `active`, while preserving its id and evaluation-rule assignments. Pauses caused by provider authentication, billing, connectivity, account state, or an unknown legacy reason remain paused until the explicit reactivation check succeeds.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Evaluator> EvaluatorsUpdateAsync(
            string evaluatorId,

            global::Langfuse.UpdateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluator by its stable identifier.<br/>
        /// Provide only the top-level fields to change. Metadata-only changes do not create a version. Evaluator type cannot change.<br/>
        /// Definition fields are flattened into the request. To replace a definition, include `type` and every definition field for that type. Definition fields are replaced as a complete unit rather than merged. For LLM-as-a-judge evaluators, omitting or setting `modelConfig` to `null` selects the project's default evaluation model.<br/>
        /// Replacing a definition automatically returns an evaluator paused by an invalid or missing model configuration to `active`, while preserving its id and evaluation-rule assignments. Pauses caused by provider authentication, billing, connectivity, account state, or an unknown legacy reason remain paused until the explicit reactivation check succeeds.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.Evaluator>> EvaluatorsUpdateAsResponseAsync(
            string evaluatorId,

            global::Langfuse.UpdateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluator by its stable identifier.<br/>
        /// Provide only the top-level fields to change. Metadata-only changes do not create a version. Evaluator type cannot change.<br/>
        /// Definition fields are flattened into the request. To replace a definition, include `type` and every definition field for that type. Definition fields are replaced as a complete unit rather than merged. For LLM-as-a-judge evaluators, omitting or setting `modelConfig` to `null` selects the project's default evaluation model.<br/>
        /// Replacing a definition automatically returns an evaluator paused by an invalid or missing model configuration to `active`, while preserving its id and evaluation-rule assignments. Pauses caused by provider authentication, billing, connectivity, account state, or an unknown legacy reason remain paused until the explicit reactivation check succeeds.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Evaluator> EvaluatorsUpdateAsync(
            string evaluatorId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}