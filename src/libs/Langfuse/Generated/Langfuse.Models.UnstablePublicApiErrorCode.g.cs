
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Machine-readable error code returned by the unstable evaluators API.<br/>
    /// SDKs, CLIs, and agents should branch on `code` rather than parsing the human-readable `message`.<br/>
    /// The HTTP status still indicates the broad error class, while `code` gives the specific failure reason.
    /// </summary>
    public enum UnstablePublicApiErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        AccessDenied,
        /// <summary>
        ///
        /// </summary>
        AuthenticationFailed,
        /// <summary>
        ///
        /// </summary>
        Conflict,
        /// <summary>
        ///
        /// </summary>
        DuplicateVariableMapping,
        /// <summary>
        ///
        /// </summary>
        EvaluatorPreflightFailed,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InvalidBody,
        /// <summary>
        ///
        /// </summary>
        InvalidFilterValue,
        /// <summary>
        ///
        /// </summary>
        InvalidJsonPath,
        /// <summary>
        ///
        /// </summary>
        InvalidQuery,
        /// <summary>
        ///
        /// </summary>
        InvalidRequest,
        /// <summary>
        ///
        /// </summary>
        InvalidVariableMapping,
        /// <summary>
        ///
        /// </summary>
        MethodNotAllowed,
        /// <summary>
        ///
        /// </summary>
        MissingVariableMapping,
        /// <summary>
        ///
        /// </summary>
        NameConflict,
        /// <summary>
        ///
        /// </summary>
        RateLimited,
        /// <summary>
        ///
        /// </summary>
        ResourceNotFound,
        /// <summary>
        ///
        /// </summary>
        UnprocessableContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstablePublicApiErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstablePublicApiErrorCode value)
        {
            return value switch
            {
                UnstablePublicApiErrorCode.AccessDenied => "access_denied",
                UnstablePublicApiErrorCode.AuthenticationFailed => "authentication_failed",
                UnstablePublicApiErrorCode.Conflict => "conflict",
                UnstablePublicApiErrorCode.DuplicateVariableMapping => "duplicate_variable_mapping",
                UnstablePublicApiErrorCode.EvaluatorPreflightFailed => "evaluator_preflight_failed",
                UnstablePublicApiErrorCode.InternalError => "internal_error",
                UnstablePublicApiErrorCode.InvalidBody => "invalid_body",
                UnstablePublicApiErrorCode.InvalidFilterValue => "invalid_filter_value",
                UnstablePublicApiErrorCode.InvalidJsonPath => "invalid_json_path",
                UnstablePublicApiErrorCode.InvalidQuery => "invalid_query",
                UnstablePublicApiErrorCode.InvalidRequest => "invalid_request",
                UnstablePublicApiErrorCode.InvalidVariableMapping => "invalid_variable_mapping",
                UnstablePublicApiErrorCode.MethodNotAllowed => "method_not_allowed",
                UnstablePublicApiErrorCode.MissingVariableMapping => "missing_variable_mapping",
                UnstablePublicApiErrorCode.NameConflict => "name_conflict",
                UnstablePublicApiErrorCode.RateLimited => "rate_limited",
                UnstablePublicApiErrorCode.ResourceNotFound => "resource_not_found",
                UnstablePublicApiErrorCode.UnprocessableContent => "unprocessable_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstablePublicApiErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "access_denied" => UnstablePublicApiErrorCode.AccessDenied,
                "authentication_failed" => UnstablePublicApiErrorCode.AuthenticationFailed,
                "conflict" => UnstablePublicApiErrorCode.Conflict,
                "duplicate_variable_mapping" => UnstablePublicApiErrorCode.DuplicateVariableMapping,
                "evaluator_preflight_failed" => UnstablePublicApiErrorCode.EvaluatorPreflightFailed,
                "internal_error" => UnstablePublicApiErrorCode.InternalError,
                "invalid_body" => UnstablePublicApiErrorCode.InvalidBody,
                "invalid_filter_value" => UnstablePublicApiErrorCode.InvalidFilterValue,
                "invalid_json_path" => UnstablePublicApiErrorCode.InvalidJsonPath,
                "invalid_query" => UnstablePublicApiErrorCode.InvalidQuery,
                "invalid_request" => UnstablePublicApiErrorCode.InvalidRequest,
                "invalid_variable_mapping" => UnstablePublicApiErrorCode.InvalidVariableMapping,
                "method_not_allowed" => UnstablePublicApiErrorCode.MethodNotAllowed,
                "missing_variable_mapping" => UnstablePublicApiErrorCode.MissingVariableMapping,
                "name_conflict" => UnstablePublicApiErrorCode.NameConflict,
                "rate_limited" => UnstablePublicApiErrorCode.RateLimited,
                "resource_not_found" => UnstablePublicApiErrorCode.ResourceNotFound,
                "unprocessable_content" => UnstablePublicApiErrorCode.UnprocessableContent,
                _ => null,
            };
        }
    }
}