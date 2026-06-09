#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluatorsClient
    {
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// Use evaluators to define **how** Langfuse should score data.<br/>
        /// LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration.<br/>
        /// Code evaluators define source code and a runtime language.<br/>
        /// Naming behavior:<br/>
        /// - If this is a new evaluator name in your project, Langfuse creates version `1`.<br/>
        /// - If the name already exists in your project, Langfuse creates the next version and returns it.<br/>
        /// - When a new project version is created, existing evaluation rules in that project automatically move to the newest version for that evaluator name.<br/>
        /// Recommended workflow:<br/>
        /// 1. Create the evaluator.<br/>
        /// 2. Read the returned `variables` array.<br/>
        /// 3. Read the returned `outputDefinition.dataType` so the client knows whether future scores will be numeric, boolean, or categorical.<br/>
        /// 4. Create one or more evaluation rules that reference the returned evaluator family using `name` and `scope`.<br/>
        /// Code evaluator validation:<br/>
        /// - At creation, Langfuse only validates the request shape<br/>
        /// - The `sourceCode` itself is not executed here. It is first run (preflight-tested against a sample observation) when you link the evaluator to an evaluation rule, so runtime errors in the code surface at evaluation-rule creation, not at evaluator creation.<br/>
        /// Recovery guidance:<br/>
        /// - `422` with `code=evaluator_preflight_failed`: the evaluator cannot run with the resolved model configuration. Add a valid explicit `modelConfig`, or configure the project's default evaluation model, then retry the same request.<br/>
        /// - `400` with `code=invalid_body`: the request shape is malformed. Use the structured `details.issues` array to fix the specific fields and retry.<br/>
        /// - `400` with `code=invalid_body` on `outputDefinition`: for `type=llm_as_judge`, send `dataType`, `reasoning.description`, and `score.description`. Do not send `version`; it is not part of the public request shape.<br/>
        /// - If `type` is omitted, Langfuse treats the request as `type=llm_as_judge` for backwards compatibility. New clients should send `type` explicitly.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while the underlying evaluation data model is being redesigned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluator> UnstableEvaluatorsCreateAsync(

            global::Langfuse.UnstableCreateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// Use evaluators to define **how** Langfuse should score data.<br/>
        /// LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration.<br/>
        /// Code evaluators define source code and a runtime language.<br/>
        /// Naming behavior:<br/>
        /// - If this is a new evaluator name in your project, Langfuse creates version `1`.<br/>
        /// - If the name already exists in your project, Langfuse creates the next version and returns it.<br/>
        /// - When a new project version is created, existing evaluation rules in that project automatically move to the newest version for that evaluator name.<br/>
        /// Recommended workflow:<br/>
        /// 1. Create the evaluator.<br/>
        /// 2. Read the returned `variables` array.<br/>
        /// 3. Read the returned `outputDefinition.dataType` so the client knows whether future scores will be numeric, boolean, or categorical.<br/>
        /// 4. Create one or more evaluation rules that reference the returned evaluator family using `name` and `scope`.<br/>
        /// Code evaluator validation:<br/>
        /// - At creation, Langfuse only validates the request shape<br/>
        /// - The `sourceCode` itself is not executed here. It is first run (preflight-tested against a sample observation) when you link the evaluator to an evaluation rule, so runtime errors in the code surface at evaluation-rule creation, not at evaluator creation.<br/>
        /// Recovery guidance:<br/>
        /// - `422` with `code=evaluator_preflight_failed`: the evaluator cannot run with the resolved model configuration. Add a valid explicit `modelConfig`, or configure the project's default evaluation model, then retry the same request.<br/>
        /// - `400` with `code=invalid_body`: the request shape is malformed. Use the structured `details.issues` array to fix the specific fields and retry.<br/>
        /// - `400` with `code=invalid_body` on `outputDefinition`: for `type=llm_as_judge`, send `dataType`, `reasoning.description`, and `score.description`. Do not send `version`; it is not part of the public request shape.<br/>
        /// - If `type` is omitted, Langfuse treats the request as `type=llm_as_judge` for backwards compatibility. New clients should send `type` explicitly.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while the underlying evaluation data model is being redesigned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluator>> UnstableEvaluatorsCreateAsResponseAsync(

            global::Langfuse.UnstableCreateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// Use evaluators to define **how** Langfuse should score data.<br/>
        /// LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration.<br/>
        /// Code evaluators define source code and a runtime language.<br/>
        /// Naming behavior:<br/>
        /// - If this is a new evaluator name in your project, Langfuse creates version `1`.<br/>
        /// - If the name already exists in your project, Langfuse creates the next version and returns it.<br/>
        /// - When a new project version is created, existing evaluation rules in that project automatically move to the newest version for that evaluator name.<br/>
        /// Recommended workflow:<br/>
        /// 1. Create the evaluator.<br/>
        /// 2. Read the returned `variables` array.<br/>
        /// 3. Read the returned `outputDefinition.dataType` so the client knows whether future scores will be numeric, boolean, or categorical.<br/>
        /// 4. Create one or more evaluation rules that reference the returned evaluator family using `name` and `scope`.<br/>
        /// Code evaluator validation:<br/>
        /// - At creation, Langfuse only validates the request shape<br/>
        /// - The `sourceCode` itself is not executed here. It is first run (preflight-tested against a sample observation) when you link the evaluator to an evaluation rule, so runtime errors in the code surface at evaluation-rule creation, not at evaluator creation.<br/>
        /// Recovery guidance:<br/>
        /// - `422` with `code=evaluator_preflight_failed`: the evaluator cannot run with the resolved model configuration. Add a valid explicit `modelConfig`, or configure the project's default evaluation model, then retry the same request.<br/>
        /// - `400` with `code=invalid_body`: the request shape is malformed. Use the structured `details.issues` array to fix the specific fields and retry.<br/>
        /// - `400` with `code=invalid_body` on `outputDefinition`: for `type=llm_as_judge`, send `dataType`, `reasoning.description`, and `score.description`. Do not send `version`; it is not part of the public request shape.<br/>
        /// - If `type` is omitted, Langfuse treats the request as `type=llm_as_judge` for backwards compatibility. New clients should send `type` explicitly.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while the underlying evaluation data model is being redesigned.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluator> UnstableEvaluatorsCreateAsync(
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}