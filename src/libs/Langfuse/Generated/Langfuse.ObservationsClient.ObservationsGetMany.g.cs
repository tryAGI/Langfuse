
#nullable enable

namespace Langfuse
{
    public partial class ObservationsClient
    {


        private static readonly global::Langfuse.EndPointSecurityRequirement s_ObservationsGetManySecurityRequirement0 =
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
        private static readonly global::Langfuse.EndPointSecurityRequirement[] s_ObservationsGetManySecurityRequirements =
            new global::Langfuse.EndPointSecurityRequirement[]
            {                s_ObservationsGetManySecurityRequirement0,
            };
        partial void PrepareObservationsGetManyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? fields,
            ref string? expandMetadata,
            ref int? limit,
            ref string? cursor,
            ref bool? parseIoAsJson,
            ref string? name,
            ref string? userId,
            ref string? sessionId,
            ref string? type,
            ref string? traceId,
            ref global::Langfuse.ObservationLevel? level,
            ref string? parentObservationId,
            ref bool? isRootObservation,
            global::System.Collections.Generic.IList<string>? environment,
            ref global::System.DateTime? fromStartTime,
            ref global::System.DateTime? toStartTime,
            ref string? version,
            ref string? filter);
        partial void PrepareObservationsGetManyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? fields,
            string? expandMetadata,
            int? limit,
            string? cursor,
            bool? parseIoAsJson,
            string? name,
            string? userId,
            string? sessionId,
            string? type,
            string? traceId,
            global::Langfuse.ObservationLevel? level,
            string? parentObservationId,
            bool? isRootObservation,
            global::System.Collections.Generic.IList<string>? environment,
            global::System.DateTime? fromStartTime,
            global::System.DateTime? toStartTime,
            string? version,
            string? filter);
        partial void ProcessObservationsGetManyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObservationsGetManyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a list of observations with cursor-based pagination and flexible field selection.<br/>
        /// ## Cursor-based Pagination<br/>
        /// This endpoint uses cursor-based pagination for efficient traversal of large datasets.<br/>
        /// The cursor is returned in the response metadata and should be passed in subsequent requests<br/>
        /// to retrieve the next page of results.<br/>
        /// ## Field Selection<br/>
        /// Use the `fields` parameter to control which observation fields are returned:<br/>
        /// - `core` - Always included: id, traceId, startTime, endTime, projectId, parentObservationId, type<br/>
        /// - `basic` - name, level, statusMessage, version, environment, bookmarked, public, userId, sessionId, isRootObservation<br/>
        /// - `time` - completionStartTime, createdAt, updatedAt<br/>
        /// - `io` - input, output<br/>
        /// - `metadata` - metadata (truncated to 200 chars by default, use `expandMetadata` to get full values)<br/>
        /// - `model` - providedModelName, internalModelId, modelParameters<br/>
        /// - `usage` - usageDetails, costDetails, totalCost, usagePricingTierName<br/>
        /// - `prompt` - promptId, promptName, promptVersion<br/>
        /// - `metrics` - latency, timeToFirstToken<br/>
        /// - `trace_context` - tags, release, traceName<br/>
        /// If not specified, `core` and `basic` field groups are returned.<br/>
        /// ## Filters<br/>
        /// Multiple filtering options are available via query parameters or the structured `filter` parameter.<br/>
        /// When using the `filter` parameter, it takes precedence over individual query parameter filters.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="expandMetadata"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="parseIoAsJson"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="traceId"></param>
        /// <param name="level"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="isRootObservation"></param>
        /// <param name="environment"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="version"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Langfuse.ObservationsV2Response> ObservationsGetManyAsync(
            string? fields = default,
            string? expandMetadata = default,
            int? limit = default,
            string? cursor = default,
            bool? parseIoAsJson = default,
            string? name = default,
            string? userId = default,
            string? sessionId = default,
            string? type = default,
            string? traceId = default,
            global::Langfuse.ObservationLevel? level = default,
            string? parentObservationId = default,
            bool? isRootObservation = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.DateTime? fromStartTime = default,
            global::System.DateTime? toStartTime = default,
            string? version = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ObservationsGetManyAsResponseAsync(
                fields: fields,
                expandMetadata: expandMetadata,
                limit: limit,
                cursor: cursor,
                parseIoAsJson: parseIoAsJson,
                name: name,
                userId: userId,
                sessionId: sessionId,
                type: type,
                traceId: traceId,
                level: level,
                parentObservationId: parentObservationId,
                isRootObservation: isRootObservation,
                environment: environment,
                fromStartTime: fromStartTime,
                toStartTime: toStartTime,
                version: version,
                filter: filter,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get a list of observations with cursor-based pagination and flexible field selection.<br/>
        /// ## Cursor-based Pagination<br/>
        /// This endpoint uses cursor-based pagination for efficient traversal of large datasets.<br/>
        /// The cursor is returned in the response metadata and should be passed in subsequent requests<br/>
        /// to retrieve the next page of results.<br/>
        /// ## Field Selection<br/>
        /// Use the `fields` parameter to control which observation fields are returned:<br/>
        /// - `core` - Always included: id, traceId, startTime, endTime, projectId, parentObservationId, type<br/>
        /// - `basic` - name, level, statusMessage, version, environment, bookmarked, public, userId, sessionId, isRootObservation<br/>
        /// - `time` - completionStartTime, createdAt, updatedAt<br/>
        /// - `io` - input, output<br/>
        /// - `metadata` - metadata (truncated to 200 chars by default, use `expandMetadata` to get full values)<br/>
        /// - `model` - providedModelName, internalModelId, modelParameters<br/>
        /// - `usage` - usageDetails, costDetails, totalCost, usagePricingTierName<br/>
        /// - `prompt` - promptId, promptName, promptVersion<br/>
        /// - `metrics` - latency, timeToFirstToken<br/>
        /// - `trace_context` - tags, release, traceName<br/>
        /// If not specified, `core` and `basic` field groups are returned.<br/>
        /// ## Filters<br/>
        /// Multiple filtering options are available via query parameters or the structured `filter` parameter.<br/>
        /// When using the `filter` parameter, it takes precedence over individual query parameter filters.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="expandMetadata"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="parseIoAsJson"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="traceId"></param>
        /// <param name="level"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="isRootObservation"></param>
        /// <param name="environment"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="version"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ObservationsV2Response>> ObservationsGetManyAsResponseAsync(
            string? fields = default,
            string? expandMetadata = default,
            int? limit = default,
            string? cursor = default,
            bool? parseIoAsJson = default,
            string? name = default,
            string? userId = default,
            string? sessionId = default,
            string? type = default,
            string? traceId = default,
            global::Langfuse.ObservationLevel? level = default,
            string? parentObservationId = default,
            bool? isRootObservation = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.DateTime? fromStartTime = default,
            global::System.DateTime? toStartTime = default,
            string? version = default,
            string? filter = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObservationsGetManyArguments(
                httpClient: HttpClient,
                fields: ref fields,
                expandMetadata: ref expandMetadata,
                limit: ref limit,
                cursor: ref cursor,
                parseIoAsJson: ref parseIoAsJson,
                name: ref name,
                userId: ref userId,
                sessionId: ref sessionId,
                type: ref type,
                traceId: ref traceId,
                level: ref level,
                parentObservationId: ref parentObservationId,
                isRootObservation: ref isRootObservation,
                environment: environment,
                fromStartTime: ref fromStartTime,
                toStartTime: ref toStartTime,
                version: ref version,
                filter: ref filter);


            var __authorizations = global::Langfuse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ObservationsGetManySecurityRequirements,
                operationName: "ObservationsGetManyAsync");

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
                                path: "/api/public/v2/observations",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("fields", fields)
                                .AddOptionalParameter("expandMetadata", expandMetadata)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("parseIoAsJson", parseIoAsJson?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("userId", userId)
                                .AddOptionalParameter("sessionId", sessionId)
                                .AddOptionalParameter("type", type)
                                .AddOptionalParameter("traceId", traceId)
                                .AddOptionalParameter("level", level?.ToValueString())
                                .AddOptionalParameter("parentObservationId", parentObservationId)
                                .AddOptionalParameter("isRootObservation", isRootObservation?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("environment", environment, delimiter: ",", explode: true)
                                .AddOptionalParameter("fromStartTime", fromStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("toStartTime", toStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("version", version)
                                .AddOptionalParameter("filter", filter)
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
                PrepareObservationsGetManyRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    fields: fields,
                    expandMetadata: expandMetadata,
                    limit: limit,
                    cursor: cursor,
                    parseIoAsJson: parseIoAsJson,
                    name: name,
                    userId: userId,
                    sessionId: sessionId,
                    type: type,
                    traceId: traceId,
                    level: level,
                    parentObservationId: parentObservationId,
                    isRootObservation: isRootObservation,
                    environment: environment,
                    fromStartTime: fromStartTime,
                    toStartTime: toStartTime,
                    version: version,
                    filter: filter);

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
                                operationId: "ObservationsGetMany",
                                methodName: "ObservationsGetManyAsync",
                                pathTemplate: "\"/api/public/v2/observations\"",
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
                                operationId: "ObservationsGetMany",
                                methodName: "ObservationsGetManyAsync",
                                pathTemplate: "\"/api/public/v2/observations\"",
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
                                operationId: "ObservationsGetMany",
                                methodName: "ObservationsGetManyAsync",
                                pathTemplate: "\"/api/public/v2/observations\"",
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
                ProcessObservationsGetManyResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Langfuse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Langfuse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObservationsGetMany",
                                methodName: "ObservationsGetManyAsync",
                                pathTemplate: "\"/api/public/v2/observations\"",
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
                                operationId: "ObservationsGetMany",
                                methodName: "ObservationsGetManyAsync",
                                pathTemplate: "\"/api/public/v2/observations\"",
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
                                ProcessObservationsGetManyResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Langfuse.ObservationsV2Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ObservationsV2Response>(
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

                                    var __value = await global::Langfuse.ObservationsV2Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ObservationsV2Response>(
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