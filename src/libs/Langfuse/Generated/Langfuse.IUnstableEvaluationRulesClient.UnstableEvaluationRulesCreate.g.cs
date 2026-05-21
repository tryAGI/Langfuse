#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluationRulesClient
    {
        /// <summary>
        /// Create an evaluation rule.<br/>
        /// An evaluation rule defines **what** incoming data should be evaluated and **how prompt variables should be populated** from that data.<br/>
        /// Use this resource after choosing an evaluator from the evaluator endpoints.<br/>
        /// Key rules:<br/>
        /// - `name` must be unique within the project for public evaluation rules<br/>
        /// - `target` must be `observation` or `experiment`<br/>
        /// - `evaluator.name` + `evaluator.scope` must identify an existing evaluator family returned by the evaluator endpoints<br/>
        /// - Langfuse resolves that family to its latest version before saving the evaluation rule<br/>
        /// - for `target=experiment`, use dataset `id` values from `GET /api/public/v2/datasets` when filtering by `datasetId`<br/>
        /// - every evaluator prompt variable must be mapped exactly once<br/>
        /// - `expected_output` and `experiment_item_metadata` mappings are only valid for `target=experiment`<br/>
        /// - if `enabled=true`, Langfuse validates that the referenced evaluator can currently run<br/>
        /// - at most 50 evaluation rules can be effectively active in one project at the same time<br/>
        /// If an evaluation rule with the same `name` already exists in the project, the API returns `409`.<br/>
        /// In that case, update the existing resource with `PATCH /api/public/unstable/evaluation-rules/{evaluationRuleId}` instead of creating a second one.<br/>
        /// If enabling this resource would exceed the 50-active limit, the API also returns `409`.<br/>
        /// In that case, disable or pause another active evaluation rule before enabling a new one.<br/>
        /// Current scope:<br/>
        /// - evaluation rules are live-ingestion rules only<br/>
        /// - they do not trigger historical backfills<br/>
        /// Recovery guidance:<br/>
        /// - `400 invalid_filter_value`: fix the filter `column` or `value` using `details.column`, `details.invalidValues`, and `details.allowedValues`<br/>
        /// - `400 invalid_filter_value` with `details.column=datasetId`: call `GET /api/public/v2/datasets`, then retry with dataset `id` values from that response<br/>
        /// - `400 missing_variable_mapping`: fetch the evaluator again and make sure every variable in `variables` appears exactly once in `mapping`<br/>
        /// - `400 duplicate_variable_mapping`: remove repeated mappings for the same variable<br/>
        /// - `400 invalid_variable_mapping`: switch to a valid `source` for the selected `target`, or fix the variable name<br/>
        /// - `400 invalid_json_path`: remove or correct the `jsonPath`<br/>
        /// - `422 evaluator_preflight_failed`: the selected evaluator cannot run with the resolved model configuration. Fix the evaluator/default model setup, then retry the create request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesCreateAsync(

            global::Langfuse.UnstableCreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation rule.<br/>
        /// An evaluation rule defines **what** incoming data should be evaluated and **how prompt variables should be populated** from that data.<br/>
        /// Use this resource after choosing an evaluator from the evaluator endpoints.<br/>
        /// Key rules:<br/>
        /// - `name` must be unique within the project for public evaluation rules<br/>
        /// - `target` must be `observation` or `experiment`<br/>
        /// - `evaluator.name` + `evaluator.scope` must identify an existing evaluator family returned by the evaluator endpoints<br/>
        /// - Langfuse resolves that family to its latest version before saving the evaluation rule<br/>
        /// - for `target=experiment`, use dataset `id` values from `GET /api/public/v2/datasets` when filtering by `datasetId`<br/>
        /// - every evaluator prompt variable must be mapped exactly once<br/>
        /// - `expected_output` and `experiment_item_metadata` mappings are only valid for `target=experiment`<br/>
        /// - if `enabled=true`, Langfuse validates that the referenced evaluator can currently run<br/>
        /// - at most 50 evaluation rules can be effectively active in one project at the same time<br/>
        /// If an evaluation rule with the same `name` already exists in the project, the API returns `409`.<br/>
        /// In that case, update the existing resource with `PATCH /api/public/unstable/evaluation-rules/{evaluationRuleId}` instead of creating a second one.<br/>
        /// If enabling this resource would exceed the 50-active limit, the API also returns `409`.<br/>
        /// In that case, disable or pause another active evaluation rule before enabling a new one.<br/>
        /// Current scope:<br/>
        /// - evaluation rules are live-ingestion rules only<br/>
        /// - they do not trigger historical backfills<br/>
        /// Recovery guidance:<br/>
        /// - `400 invalid_filter_value`: fix the filter `column` or `value` using `details.column`, `details.invalidValues`, and `details.allowedValues`<br/>
        /// - `400 invalid_filter_value` with `details.column=datasetId`: call `GET /api/public/v2/datasets`, then retry with dataset `id` values from that response<br/>
        /// - `400 missing_variable_mapping`: fetch the evaluator again and make sure every variable in `variables` appears exactly once in `mapping`<br/>
        /// - `400 duplicate_variable_mapping`: remove repeated mappings for the same variable<br/>
        /// - `400 invalid_variable_mapping`: switch to a valid `source` for the selected `target`, or fix the variable name<br/>
        /// - `400 invalid_json_path`: remove or correct the `jsonPath`<br/>
        /// - `422 evaluator_preflight_failed`: the selected evaluator cannot run with the resolved model configuration. Fix the evaluator/default model setup, then retry the create request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluationRule>> UnstableEvaluationRulesCreateAsResponseAsync(

            global::Langfuse.UnstableCreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation rule.<br/>
        /// An evaluation rule defines **what** incoming data should be evaluated and **how prompt variables should be populated** from that data.<br/>
        /// Use this resource after choosing an evaluator from the evaluator endpoints.<br/>
        /// Key rules:<br/>
        /// - `name` must be unique within the project for public evaluation rules<br/>
        /// - `target` must be `observation` or `experiment`<br/>
        /// - `evaluator.name` + `evaluator.scope` must identify an existing evaluator family returned by the evaluator endpoints<br/>
        /// - Langfuse resolves that family to its latest version before saving the evaluation rule<br/>
        /// - for `target=experiment`, use dataset `id` values from `GET /api/public/v2/datasets` when filtering by `datasetId`<br/>
        /// - every evaluator prompt variable must be mapped exactly once<br/>
        /// - `expected_output` and `experiment_item_metadata` mappings are only valid for `target=experiment`<br/>
        /// - if `enabled=true`, Langfuse validates that the referenced evaluator can currently run<br/>
        /// - at most 50 evaluation rules can be effectively active in one project at the same time<br/>
        /// If an evaluation rule with the same `name` already exists in the project, the API returns `409`.<br/>
        /// In that case, update the existing resource with `PATCH /api/public/unstable/evaluation-rules/{evaluationRuleId}` instead of creating a second one.<br/>
        /// If enabling this resource would exceed the 50-active limit, the API also returns `409`.<br/>
        /// In that case, disable or pause another active evaluation rule before enabling a new one.<br/>
        /// Current scope:<br/>
        /// - evaluation rules are live-ingestion rules only<br/>
        /// - they do not trigger historical backfills<br/>
        /// Recovery guidance:<br/>
        /// - `400 invalid_filter_value`: fix the filter `column` or `value` using `details.column`, `details.invalidValues`, and `details.allowedValues`<br/>
        /// - `400 invalid_filter_value` with `details.column=datasetId`: call `GET /api/public/v2/datasets`, then retry with dataset `id` values from that response<br/>
        /// - `400 missing_variable_mapping`: fetch the evaluator again and make sure every variable in `variables` appears exactly once in `mapping`<br/>
        /// - `400 duplicate_variable_mapping`: remove repeated mappings for the same variable<br/>
        /// - `400 invalid_variable_mapping`: switch to a valid `source` for the selected `target`, or fix the variable name<br/>
        /// - `400 invalid_json_path`: remove or correct the `jsonPath`<br/>
        /// - `422 evaluator_preflight_failed`: the selected evaluator cannot run with the resolved model configuration. Fix the evaluator/default model setup, then retry the create request.
        /// </summary>
        /// <param name="name">
        /// Human-readable deployment name.<br/>
        /// Example: answer-correctness-live
        /// </param>
        /// <param name="evaluator">
        /// Evaluator family reference used when creating or updating an evaluation rule.<br/>
        /// `name` and `scope` are enough to identify the evaluator family in the authenticated project context.
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
        /// Whether the deployment should be active immediately after creation.<br/>
        /// Example: true
        /// </param>
        /// <param name="sampling">
        /// Optional sampling fraction. Defaults to `1`.
        /// </param>
        /// <param name="filter">
        /// Optional filter list.<br/>
        /// Omit or pass an empty list to evaluate all matching targets for the selected `target`.<br/>
        /// Each filter object must use a column that is valid for that `target`.<br/>
        /// For `target=experiment`, `column=datasetId` expects dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
        /// </param>
        /// <param name="mapping">
        /// Required variable mappings.<br/>
        /// Every evaluator variable must appear exactly once.<br/>
        /// Build this list from the evaluator `variables` array returned by the evaluator endpoints.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesCreateAsync(
            string name,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> mapping,
            double? sampling = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}