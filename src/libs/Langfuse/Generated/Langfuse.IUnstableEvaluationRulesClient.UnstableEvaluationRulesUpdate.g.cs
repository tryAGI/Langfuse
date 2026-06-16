#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// Update an evaluation rule.<br/>
        /// Typical uses:<br/>
        /// - enable or disable live execution<br/>
        /// - switch to another evaluator<br/>
        /// - adjust sampling<br/>
        /// - change filters<br/>
        /// - update LLM-as-judge variable mappings<br/>
        /// Important behavior:<br/>
        /// - provide only the fields you want to change<br/>
        /// - if you provide `evaluator`, Langfuse resolves that evaluator family to its latest version before saving<br/>
        /// - changing `target`, `filter`, or an LLM-as-judge `mapping` must still produce a valid target-specific configuration<br/>
        /// - if you change `target` for an LLM-as-judge rule, also send a compatible `filter` and `mapping` in the same request unless the existing ones are still valid for the new target<br/>
        /// - for `code` evaluator rules, omit `mapping`; Langfuse stores the fixed code runtime mapping automatically<br/>
        /// - if the resulting config is enabled, Langfuse re-validates that the selected evaluator can run<br/>
        /// - if the update would move a non-active evaluation rule into the active state and the project already has 50 active evaluation rules, the API returns `409`<br/>
        /// Recovery guidance:<br/>
        /// - if an LLM-as-judge update fails with `missing_variable_mapping` or `invalid_variable_mapping` after changing `evaluator` or `target`, resend the request with a complete new `mapping`<br/>
        /// - if the update fails with `invalid_filter_value` after changing `target`, resend the request with a target-compatible `filter`
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesUpdateAsync(
            string evaluationRuleId,

            global::Langfuse.UnstableUpdateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluation rule.<br/>
        /// Typical uses:<br/>
        /// - enable or disable live execution<br/>
        /// - switch to another evaluator<br/>
        /// - adjust sampling<br/>
        /// - change filters<br/>
        /// - update LLM-as-judge variable mappings<br/>
        /// Important behavior:<br/>
        /// - provide only the fields you want to change<br/>
        /// - if you provide `evaluator`, Langfuse resolves that evaluator family to its latest version before saving<br/>
        /// - changing `target`, `filter`, or an LLM-as-judge `mapping` must still produce a valid target-specific configuration<br/>
        /// - if you change `target` for an LLM-as-judge rule, also send a compatible `filter` and `mapping` in the same request unless the existing ones are still valid for the new target<br/>
        /// - for `code` evaluator rules, omit `mapping`; Langfuse stores the fixed code runtime mapping automatically<br/>
        /// - if the resulting config is enabled, Langfuse re-validates that the selected evaluator can run<br/>
        /// - if the update would move a non-active evaluation rule into the active state and the project already has 50 active evaluation rules, the API returns `409`<br/>
        /// Recovery guidance:<br/>
        /// - if an LLM-as-judge update fails with `missing_variable_mapping` or `invalid_variable_mapping` after changing `evaluator` or `target`, resend the request with a complete new `mapping`<br/>
        /// - if the update fails with `invalid_filter_value` after changing `target`, resend the request with a target-compatible `filter`
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluationRule>> UnstableEvaluationRulesUpdateAsResponseAsync(
            string evaluationRuleId,

            global::Langfuse.UnstableUpdateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an evaluation rule.<br/>
        /// Typical uses:<br/>
        /// - enable or disable live execution<br/>
        /// - switch to another evaluator<br/>
        /// - adjust sampling<br/>
        /// - change filters<br/>
        /// - update LLM-as-judge variable mappings<br/>
        /// Important behavior:<br/>
        /// - provide only the fields you want to change<br/>
        /// - if you provide `evaluator`, Langfuse resolves that evaluator family to its latest version before saving<br/>
        /// - changing `target`, `filter`, or an LLM-as-judge `mapping` must still produce a valid target-specific configuration<br/>
        /// - if you change `target` for an LLM-as-judge rule, also send a compatible `filter` and `mapping` in the same request unless the existing ones are still valid for the new target<br/>
        /// - for `code` evaluator rules, omit `mapping`; Langfuse stores the fixed code runtime mapping automatically<br/>
        /// - if the resulting config is enabled, Langfuse re-validates that the selected evaluator can run<br/>
        /// - if the update would move a non-active evaluation rule into the active state and the project already has 50 active evaluation rules, the API returns `409`<br/>
        /// Recovery guidance:<br/>
        /// - if an LLM-as-judge update fails with `missing_variable_mapping` or `invalid_variable_mapping` after changing `evaluator` or `target`, resend the request with a complete new `mapping`<br/>
        /// - if the update fails with `invalid_filter_value` after changing `target`, resend the request with a target-compatible `filter`
        /// </summary>
        /// <param name="evaluationRuleId"></param>
        /// <param name="name">
        /// Updated deployment name.
        /// </param>
        /// <param name="evaluator">
        /// Evaluator family reference used when updating an evaluation rule.<br/>
        /// `name` and `scope` identify the evaluator family in the authenticated project context.<br/>
        /// A rule's evaluator type cannot be changed, so this reference does not accept a `type`; the family must match the rule's current evaluator type.
        /// </param>
        /// <param name="target">
        /// The ingestion object type that should trigger evaluation runs.<br/>
        /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
        /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
        ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
        ///   It currently supports filtering by `datasetId`.<br/>
        ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
        /// </param>
        /// <param name="enabled">
        /// Updated desired enabled state.
        /// </param>
        /// <param name="sampling">
        /// Updated sampling fraction.
        /// </param>
        /// <param name="filter">
        /// Updated filter list.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </param>
        /// <param name="mapping">
        /// Updated LLM-as-judge variable mappings.<br/>
        /// Do not send this field for code evaluator rules. Langfuse stores the fixed code runtime mapping automatically and returns it in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesUpdateAsync(
            string evaluationRuleId,
            string? name = default,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference? evaluator = default,
            global::Langfuse.UnstableEvaluationRuleTarget? target = default,
            bool? enabled = default,
            double? sampling = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping>? mapping = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}