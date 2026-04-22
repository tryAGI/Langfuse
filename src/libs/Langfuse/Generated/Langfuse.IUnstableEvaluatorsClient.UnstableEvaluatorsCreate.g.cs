#nullable enable

namespace Langfuse
{
    public partial interface IUnstableEvaluatorsClient
    {
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// Use evaluators to define **how** Langfuse should score data: the prompt, the expected structured output, and the optional model configuration.<br/>
        /// Naming behavior:<br/>
        /// - If this is a new evaluator name in your project, Langfuse creates version `1`.<br/>
        /// - If the name already exists in your project, Langfuse creates the next version and returns it.<br/>
        /// - When a new project version is created, existing evaluation rules in that project automatically move to the newest version for that evaluator name.<br/>
        /// Recommended workflow:<br/>
        /// 1. Create the evaluator.<br/>
        /// 2. Read the returned `variables` array.<br/>
        /// 3. Read the returned `outputDefinition.dataType` so the client knows whether future scores will be numeric, boolean, or categorical.<br/>
        /// 4. Create one or more evaluation rules that reference the returned evaluator family using `name` and `scope`.<br/>
        /// Recovery guidance:<br/>
        /// - `422` with `code=evaluator_preflight_failed`: the evaluator cannot run with the resolved model configuration. Add a valid explicit `modelConfig`, or configure the project's default evaluation model, then retry the same request.<br/>
        /// - `400` with `code=invalid_body`: the request shape is malformed. Use the structured `details.issues` array to fix the specific fields and retry.<br/>
        /// - `400` with `code=invalid_body` on `outputDefinition`: send `dataType`, `reasoning.description`, and `score.description`. Do not send `version`; it is not part of the public request shape.<br/>
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
        /// Use evaluators to define **how** Langfuse should score data: the prompt, the expected structured output, and the optional model configuration.<br/>
        /// Naming behavior:<br/>
        /// - If this is a new evaluator name in your project, Langfuse creates version `1`.<br/>
        /// - If the name already exists in your project, Langfuse creates the next version and returns it.<br/>
        /// - When a new project version is created, existing evaluation rules in that project automatically move to the newest version for that evaluator name.<br/>
        /// Recommended workflow:<br/>
        /// 1. Create the evaluator.<br/>
        /// 2. Read the returned `variables` array.<br/>
        /// 3. Read the returned `outputDefinition.dataType` so the client knows whether future scores will be numeric, boolean, or categorical.<br/>
        /// 4. Create one or more evaluation rules that reference the returned evaluator family using `name` and `scope`.<br/>
        /// Recovery guidance:<br/>
        /// - `422` with `code=evaluator_preflight_failed`: the evaluator cannot run with the resolved model configuration. Add a valid explicit `modelConfig`, or configure the project's default evaluation model, then retry the same request.<br/>
        /// - `400` with `code=invalid_body`: the request shape is malformed. Use the structured `details.issues` array to fix the specific fields and retry.<br/>
        /// - `400` with `code=invalid_body` on `outputDefinition`: send `dataType`, `reasoning.description`, and `score.description`. Do not send `version`; it is not part of the public request shape.<br/>
        /// Unstable API note:<br/>
        /// - This surface may evolve while the underlying evaluation data model is being redesigned.
        /// </summary>
        /// <param name="name">
        /// Evaluator name within the authenticated project.<br/>
        /// Example: answer-correctness
        /// </param>
        /// <param name="prompt">
        /// Prompt template used by the evaluator.<br/>
        /// Example: You are grading an answer.<br/>
        /// Input:<br/>
        /// {{input}}<br/>
        /// Output:<br/>
        /// {{output}}<br/>
        /// Return a score between 0 and 1.
        /// </param>
        /// <param name="outputDefinition">
        /// Structured output definition to send when creating an evaluator.<br/>
        /// Agent guidance:<br/>
        /// - `dataType` is required.<br/>
        /// - Do not send `version`; that is an internal storage detail and is not part of the public request contract.<br/>
        /// - For `NUMERIC` and `BOOLEAN`, provide `reasoning.description` and `score.description`.<br/>
        /// - For `CATEGORICAL`, also provide `score.categories` and `score.shouldAllowMultipleMatches`.
        /// </param>
        /// <param name="modelConfig">
        /// Optional explicit model configuration for an evaluator.<br/>
        /// If omitted, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
        /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
        /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
        /// Recovery guidance:<br/>
        /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluator> UnstableEvaluatorsCreateAsync(
            string name,
            string prompt,
            global::Langfuse.UnstableEvaluatorOutputDefinition outputDefinition,
            global::Langfuse.UnstableEvaluatorModelConfig? modelConfig = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}