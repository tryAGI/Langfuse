
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Stable machine-readable error code returned by the evaluators and evaluation-rules API.
    /// </summary>
    public enum PublicApiErrorCode
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
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InvalidBody,
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
        MethodNotAllowed,
        /// <summary>
        ///
        /// </summary>
        RateLimited,
        /// <summary>
        ///
        /// </summary>
        ResourceNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicApiErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicApiErrorCode value)
        {
            return value switch
            {
                PublicApiErrorCode.AccessDenied => "access_denied",
                PublicApiErrorCode.AuthenticationFailed => "authentication_failed",
                PublicApiErrorCode.Conflict => "conflict",
                PublicApiErrorCode.InternalError => "internal_error",
                PublicApiErrorCode.InvalidBody => "invalid_body",
                PublicApiErrorCode.InvalidQuery => "invalid_query",
                PublicApiErrorCode.InvalidRequest => "invalid_request",
                PublicApiErrorCode.MethodNotAllowed => "method_not_allowed",
                PublicApiErrorCode.RateLimited => "rate_limited",
                PublicApiErrorCode.ResourceNotFound => "resource_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicApiErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "access_denied" => PublicApiErrorCode.AccessDenied,
                "authentication_failed" => PublicApiErrorCode.AuthenticationFailed,
                "conflict" => PublicApiErrorCode.Conflict,
                "internal_error" => PublicApiErrorCode.InternalError,
                "invalid_body" => PublicApiErrorCode.InvalidBody,
                "invalid_query" => PublicApiErrorCode.InvalidQuery,
                "invalid_request" => PublicApiErrorCode.InvalidRequest,
                "method_not_allowed" => PublicApiErrorCode.MethodNotAllowed,
                "rate_limited" => PublicApiErrorCode.RateLimited,
                "resource_not_found" => PublicApiErrorCode.ResourceNotFound,
                _ => null,
            };
        }
    }
}