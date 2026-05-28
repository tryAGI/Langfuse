
#nullable enable

namespace Langfuse
{
    public partial class UnstableEvaluationRulesClient
    {


        private static readonly global::Langfuse.EndPointSecurityRequirement s_UnstableEvaluationRulesCreateSecurityRequirement0 =
            new global::Langfuse.EndPointSecurityRequirement
            {
                Authorizations = new global::Langfuse.EndPointAuthorizationRequirement[]
                {                    new global::Langfuse.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBasic",
                        Location = "Header",
                        Name = "Basic",
                        FriendlyName = "Basic",
                    },
                },
            };
        private static readonly global::Langfuse.EndPointSecurityRequirement[] s_UnstableEvaluationRulesCreateSecurityRequirements =
            new global::Langfuse.EndPointSecurityRequirement[]
            {                s_UnstableEvaluationRulesCreateSecurityRequirement0,
            };
        partial void PrepareUnstableEvaluationRulesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Langfuse.UnstableCreateEvaluationRuleRequest request);
        partial void PrepareUnstableEvaluationRulesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Langfuse.UnstableCreateEvaluationRuleRequest request);
        partial void ProcessUnstableEvaluationRulesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUnstableEvaluationRulesCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// - `expected_output` mappings are only valid for `target=experiment`<br/>
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
        public async global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesCreateAsync(

            global::Langfuse.UnstableCreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UnstableEvaluationRulesCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        /// - `expected_output` mappings are only valid for `target=experiment`<br/>
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
        public async global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluationRule>> UnstableEvaluationRulesCreateAsResponseAsync(

            global::Langfuse.UnstableCreateEvaluationRuleRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUnstableEvaluationRulesCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Langfuse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UnstableEvaluationRulesCreateSecurityRequirements,
                operationName: "UnstableEvaluationRulesCreateAsync");

            using var __timeoutCancellationTokenSource = global::Langfuse.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Langfuse.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Langfuse.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Langfuse.PathBuilder(
                                path: "/api/public/unstable/evaluation-rules",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Langfuse.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Langfuse.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUnstableEvaluationRulesCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Langfuse.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UnstableEvaluationRulesCreate",
                                methodName: "UnstableEvaluationRulesCreateAsync",
                                pathTemplate: "\"/api/public/unstable/evaluation-rules\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Langfuse.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UnstableEvaluationRulesCreate",
                                methodName: "UnstableEvaluationRulesCreateAsync",
                                pathTemplate: "\"/api/public/unstable/evaluation-rules\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Langfuse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Langfuse.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Langfuse.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UnstableEvaluationRulesCreate",
                                methodName: "UnstableEvaluationRulesCreateAsync",
                                pathTemplate: "\"/api/public/unstable/evaluation-rules\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Langfuse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessUnstableEvaluationRulesCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UnstableEvaluationRulesCreate",
                                methodName: "UnstableEvaluationRulesCreateAsync",
                                pathTemplate: "\"/api/public/unstable/evaluation-rules\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UnstableEvaluationRulesCreate",
                                methodName: "UnstableEvaluationRulesCreateAsync",
                                pathTemplate: "\"/api/public/unstable/evaluation-rules\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                string? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::Langfuse.ApiException<string>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                string? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::Langfuse.ApiException<string>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                string? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::Langfuse.ApiException<string>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                string? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::Langfuse.ApiException<string>(
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_404,
                                    ResponseObject = __value_404,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 405)
                            {
                                string? __content_405 = null;
                                global::System.Exception? __exception_405 = null;
                                string? __value_405 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_405 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_405, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_405 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_405, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_405 = __ex;
                                }

                                throw new global::Langfuse.ApiException<string>(
                                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_405,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_405,
                                    ResponseObject = __value_405,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::Langfuse.UnstablePublicApiError? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::Langfuse.UnstablePublicApiError.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::Langfuse.UnstablePublicApiError.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }

                                throw new global::Langfuse.ApiException<global::Langfuse.UnstablePublicApiError>(
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_409,
                                    ResponseObject = __value_409,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Langfuse.UnstablePublicApiError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Langfuse.UnstablePublicApiError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Langfuse.UnstablePublicApiError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Langfuse.ApiException<global::Langfuse.UnstablePublicApiError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Langfuse.UnstablePublicApiError? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Langfuse.UnstablePublicApiError.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Langfuse.UnstablePublicApiError.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::Langfuse.ApiException<global::Langfuse.UnstablePublicApiError>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Langfuse.UnstablePublicApiError? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Langfuse.UnstablePublicApiError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Langfuse.UnstablePublicApiError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::Langfuse.ApiException<global::Langfuse.UnstablePublicApiError>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessUnstableEvaluationRulesCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Langfuse.UnstableEvaluationRule.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluationRule>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Langfuse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Langfuse.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Langfuse.UnstableEvaluationRule.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.UnstableEvaluationRule>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Langfuse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Langfuse.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        /// - `expected_output` mappings are only valid for `target=experiment`<br/>
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
        /// - `experiment` evaluates live experiment executions and can additionally map `expected_output`.<br/>
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
        public async global::System.Threading.Tasks.Task<global::Langfuse.UnstableEvaluationRule> UnstableEvaluationRulesCreateAsync(
            string name,
            global::Langfuse.UnstableEvaluationRuleEvaluatorReference evaluator,
            global::Langfuse.UnstableEvaluationRuleTarget target,
            bool enabled,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleMapping> mapping,
            double? sampling = default,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableEvaluationRuleFilter>? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Langfuse.UnstableCreateEvaluationRuleRequest
            {
                Name = name,
                Evaluator = evaluator,
                Target = target,
                Enabled = enabled,
                Sampling = sampling,
                Filter = filter,
                Mapping = mapping,
            };

            return await UnstableEvaluationRulesCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}