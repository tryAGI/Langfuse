
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Machine-readable error code returned by unstable public API endpoints.
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
                UnstablePublicApiErrorCode.InternalError => "internal_error",
                UnstablePublicApiErrorCode.InvalidBody => "invalid_body",
                UnstablePublicApiErrorCode.InvalidQuery => "invalid_query",
                UnstablePublicApiErrorCode.InvalidRequest => "invalid_request",
                UnstablePublicApiErrorCode.MethodNotAllowed => "method_not_allowed",
                UnstablePublicApiErrorCode.RateLimited => "rate_limited",
                UnstablePublicApiErrorCode.ResourceNotFound => "resource_not_found",
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
                "internal_error" => UnstablePublicApiErrorCode.InternalError,
                "invalid_body" => UnstablePublicApiErrorCode.InvalidBody,
                "invalid_query" => UnstablePublicApiErrorCode.InvalidQuery,
                "invalid_request" => UnstablePublicApiErrorCode.InvalidRequest,
                "method_not_allowed" => UnstablePublicApiErrorCode.MethodNotAllowed,
                "rate_limited" => UnstablePublicApiErrorCode.RateLimited,
                "resource_not_found" => UnstablePublicApiErrorCode.ResourceNotFound,
                _ => null,
            };
        }
    }
}