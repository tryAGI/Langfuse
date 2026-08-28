#nullable enable

namespace Langfuse
{
    public partial interface IEvaluationRulesClient
    {
        /// <summary>
        /// Update an evaluation rule by its stable identifier.<br/>
        /// Provide only the fields to change. Providing `evaluatorAssignments` replaces the complete assignment list. Replacing the list with an empty array disables the rule. Setting `enabled=true` is rejected when the resulting assignment list is empty, including when both fields are sent in the same request.<br/>
        /// Legacy trace and dataset rules follow the existing lifecycle restrictions: they can be deactivated with `enabled=false`, but their name, filters, sampling, and evaluator assignments cannot be changed.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRule> EvaluationRulesUpdateAsync(
            string evaluationRuleId,

            global::Langfuse.UpdateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluation rule by its stable identifier.<br/>
        /// Provide only the fields to change. Providing `evaluatorAssignments` replaces the complete assignment list. Replacing the list with an empty array disables the rule. Setting `enabled=true` is rejected when the resulting assignment list is empty, including when both fields are sent in the same request.<br/>
        /// Legacy trace and dataset rules follow the existing lifecycle restrictions: they can be deactivated with `enabled=false`, but their name, filters, sampling, and evaluator assignments cannot be changed.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluationRule>> EvaluationRulesUpdateAsResponseAsync(
            string evaluationRuleId,

            global::Langfuse.UpdateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluation rule by its stable identifier.<br/>
        /// Provide only the fields to change. Providing `evaluatorAssignments` replaces the complete assignment list. Replacing the list with an empty array disables the rule. Setting `enabled=true` is rejected when the resulting assignment list is empty, including when both fields are sent in the same request.<br/>
        /// Legacy trace and dataset rules follow the existing lifecycle restrictions: they can be deactivated with `enabled=false`, but their name, filters, sampling, and evaluator assignments cannot be changed.
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="name">
        /// New human-readable rule name.
        /// </param>
        /// <param name="enabled">
        /// New desired live-execution state.
        /// </param>
        /// <param name="sampling">
        /// New fraction of matching observations to evaluate. Omit to keep the current value.
        /// </param>
        /// <param name="filter">
        /// Complete replacement filter list. An empty list matches every incoming observation.
        /// </param>
        /// <param name="evaluatorAssignments">
        /// Complete replacement assignment list. An empty list disables the rule.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRule> EvaluationRulesUpdateAsync(
            string evaluationRuleId,
            string? name = default,
            bool? enabled = default,
            double? sampling = default,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? filter = default,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput>? evaluatorAssignments = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}