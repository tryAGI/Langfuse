#nullable enable

namespace Langfuse
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// An evaluator defines **how** Langfuse should score data. LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration. Code evaluators define source code and a runtime language.<br/>
        /// This always creates a new evaluator with version `1`. Names are not identifiers and do not need to be unique.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Evaluator> EvaluatorsCreateAsync(

            global::Langfuse.CreateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// An evaluator defines **how** Langfuse should score data. LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration. Code evaluators define source code and a runtime language.<br/>
        /// This always creates a new evaluator with version `1`. Names are not identifiers and do not need to be unique.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.Evaluator>> EvaluatorsCreateAsResponseAsync(

            global::Langfuse.CreateEvaluatorRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluator in the authenticated project.<br/>
        /// An evaluator defines **how** Langfuse should score data. LLM-as-a-judge evaluators define a prompt, expected structured output, and optional model configuration. Code evaluators define source code and a runtime language.<br/>
        /// This always creates a new evaluator with version `1`. Names are not identifiers and do not need to be unique.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Evaluator> EvaluatorsCreateAsync(
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}