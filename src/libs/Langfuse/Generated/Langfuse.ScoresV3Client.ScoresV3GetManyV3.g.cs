
#nullable enable

namespace Langfuse
{
    public partial class ScoresV3Client
    {


        private static readonly global::Langfuse.EndPointSecurityRequirement s_ScoresV3GetManyV3SecurityRequirement0 =
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
        private static readonly global::Langfuse.EndPointSecurityRequirement[] s_ScoresV3GetManyV3SecurityRequirements =
            new global::Langfuse.EndPointSecurityRequirement[]
            {                s_ScoresV3GetManyV3SecurityRequirement0,
            };
        partial void PrepareScoresV3GetManyV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? cursor,
            ref string? fields,
            ref string? id,
            ref string? name,
            ref string? source,
            ref string? dataType,
            ref string? environment,
            ref string? configId,
            ref string? queueId,
            ref string? authorUserId,
            ref string? value,
            ref double? valueMin,
            ref double? valueMax,
            ref string? traceId,
            ref string? sessionId,
            ref string? observationId,
            ref string? experimentId,
            ref global::System.DateTime? fromTimestamp,
            ref global::System.DateTime? toTimestamp);
        partial void PrepareScoresV3GetManyV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? cursor,
            string? fields,
            string? id,
            string? name,
            string? source,
            string? dataType,
            string? environment,
            string? configId,
            string? queueId,
            string? authorUserId,
            string? value,
            double? valueMin,
            double? valueMax,
            string? traceId,
            string? sessionId,
            string? observationId,
            string? experimentId,
            global::System.DateTime? fromTimestamp,
            global::System.DateTime? toTimestamp);
        partial void ProcessScoresV3GetManyV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessScoresV3GetManyV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Langfuse.GetScoresV3Response> ScoresV3GetManyV3Async(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ScoresV3GetManyV3AsResponseAsync(
                limit: limit,
                cursor: cursor,
                fields: fields,
                id: id,
                name: name,
                source: source,
                dataType: dataType,
                environment: environment,
                configId: configId,
                queueId: queueId,
                authorUserId: authorUserId,
                value: value,
                valueMin: valueMin,
                valueMax: valueMax,
                traceId: traceId,
                sessionId: sessionId,
                observationId: observationId,
                experimentId: experimentId,
                fromTimestamp: fromTimestamp,
                toTimestamp: toTimestamp,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetScoresV3Response>> ScoresV3GetManyV3AsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareScoresV3GetManyV3Arguments(
                httpClient: HttpClient,
                limit: ref limit,
                cursor: ref cursor,
                fields: ref fields,
                id: ref id,
                name: ref name,
                source: ref source,
                dataType: ref dataType,
                environment: ref environment,
                configId: ref configId,
                queueId: ref queueId,
                authorUserId: ref authorUserId,
                value: ref value,
                valueMin: ref valueMin,
                valueMax: ref valueMax,
                traceId: ref traceId,
                sessionId: ref sessionId,
                observationId: ref observationId,
                experimentId: ref experimentId,
                fromTimestamp: ref fromTimestamp,
                toTimestamp: ref toTimestamp);


            var __authorizations = global::Langfuse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ScoresV3GetManyV3SecurityRequirements,
                operationName: "ScoresV3GetManyV3Async");

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
                                path: "/api/public/v3/scores",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("fields", fields)
                                .AddOptionalParameter("id", id)
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("source", source)
                                .AddOptionalParameter("dataType", dataType)
                                .AddOptionalParameter("environment", environment)
                                .AddOptionalParameter("configId", configId)
                                .AddOptionalParameter("queueId", queueId)
                                .AddOptionalParameter("authorUserId", authorUserId)
                                .AddOptionalParameter("value", value)
                                .AddOptionalParameter("valueMin", valueMin?.ToString())
                                .AddOptionalParameter("valueMax", valueMax?.ToString())
                                .AddOptionalParameter("traceId", traceId)
                                .AddOptionalParameter("sessionId", sessionId)
                                .AddOptionalParameter("observationId", observationId)
                                .AddOptionalParameter("experimentId", experimentId)
                                .AddOptionalParameter("fromTimestamp", fromTimestamp?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("toTimestamp", toTimestamp?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Langfuse.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Langfuse.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareScoresV3GetManyV3Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    cursor: cursor,
                    fields: fields,
                    id: id,
                    name: name,
                    source: source,
                    dataType: dataType,
                    environment: environment,
                    configId: configId,
                    queueId: queueId,
                    authorUserId: authorUserId,
                    value: value,
                    valueMin: valueMin,
                    valueMax: valueMax,
                    traceId: traceId,
                    sessionId: sessionId,
                    observationId: observationId,
                    experimentId: experimentId,
                    fromTimestamp: fromTimestamp,
                    toTimestamp: toTimestamp);

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
                                operationId: "ScoresV3GetManyV3",
                                methodName: "ScoresV3GetManyV3Async",
                                pathTemplate: "\"/api/public/v3/scores\"",
                                httpMethod: "GET",
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
                                operationId: "ScoresV3GetManyV3",
                                methodName: "ScoresV3GetManyV3Async",
                                pathTemplate: "\"/api/public/v3/scores\"",
                                httpMethod: "GET",
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
                                operationId: "ScoresV3GetManyV3",
                                methodName: "ScoresV3GetManyV3Async",
                                pathTemplate: "\"/api/public/v3/scores\"",
                                httpMethod: "GET",
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
                ProcessScoresV3GetManyV3Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ScoresV3GetManyV3",
                                methodName: "ScoresV3GetManyV3Async",
                                pathTemplate: "\"/api/public/v3/scores\"",
                                httpMethod: "GET",
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
                                operationId: "ScoresV3GetManyV3",
                                methodName: "ScoresV3GetManyV3Async",
                                pathTemplate: "\"/api/public/v3/scores\"",
                                httpMethod: "GET",
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


                                throw global::Langfuse.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::Langfuse.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::Langfuse.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::Langfuse.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::Langfuse.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_405,
                                    responseBody: __content_405,
                                    responseObject: __value_405,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessScoresV3GetManyV3ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Langfuse.GetScoresV3Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetScoresV3Response>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Langfuse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Langfuse.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::Langfuse.GetScoresV3Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetScoresV3Response>(
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

                                    throw global::Langfuse.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}