#nullable enable

namespace Langfuse
{
    public partial interface IEvaluationRulesClient
    {
        /// <summary>
        /// Create an evaluation rule using stable evaluator identifiers.<br/>
        /// An evaluation rule defines **which** incoming observations should be evaluated and how prompt variables should be populated.<br/>
        /// Key behavior:<br/>
        /// - rule names are not identifiers and do not need to be unique<br/>
        /// - rules always use the latest version of each associated evaluator<br/>
        /// - an enabled rule requires at least one evaluator assignment<br/>
        /// - omit `sampling` to evaluate every matching observation<br/>
        /// - omit `filter` to match every incoming observation<br/>
        /// - `datasetId` is the public filter name for selecting experiment datasets
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRule> EvaluationRulesCreateAsync(

            global::Langfuse.CreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation rule using stable evaluator identifiers.<br/>
        /// An evaluation rule defines **which** incoming observations should be evaluated and how prompt variables should be populated.<br/>
        /// Key behavior:<br/>
        /// - rule names are not identifiers and do not need to be unique<br/>
        /// - rules always use the latest version of each associated evaluator<br/>
        /// - an enabled rule requires at least one evaluator assignment<br/>
        /// - omit `sampling` to evaluate every matching observation<br/>
        /// - omit `filter` to match every incoming observation<br/>
        /// - `datasetId` is the public filter name for selecting experiment datasets
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.EvaluationRule>> EvaluationRulesCreateAsResponseAsync(

            global::Langfuse.CreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation rule using stable evaluator identifiers.<br/>
        /// An evaluation rule defines **which** incoming observations should be evaluated and how prompt variables should be populated.<br/>
        /// Key behavior:<br/>
        /// - rule names are not identifiers and do not need to be unique<br/>
        /// - rules always use the latest version of each associated evaluator<br/>
        /// - an enabled rule requires at least one evaluator assignment<br/>
        /// - omit `sampling` to evaluate every matching observation<br/>
        /// - omit `filter` to match every incoming observation<br/>
        /// - `datasetId` is the public filter name for selecting experiment datasets
        /// </summary>
        /// <param name="name">
        /// Human-readable rule name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="enabled">
        /// Whether live execution should start immediately. Enabled rules require at least one evaluator assignment.
        /// </param>
        /// <param name="sampling">
        /// Fraction of matching observations to evaluate. Omit this field to use the default of `1`, which evaluates every match. `null` is not accepted.
        /// </param>
        /// <param name="filter">
        /// Conditions used to select observations. Defaults to an empty list, which matches every incoming observation.
        /// </param>
        /// <param name="evaluatorAssignments">
        /// Evaluators to attach to this rule. Disabled rules may use an empty list as a draft.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.EvaluationRule> EvaluationRulesCreateAsync(
            string name,
            bool enabled,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleEvaluatorAssignmentInput> evaluatorAssignments,
            double? sampling = default,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleFilter>? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}