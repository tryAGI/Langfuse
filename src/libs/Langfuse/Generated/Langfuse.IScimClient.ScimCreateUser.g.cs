#nullable enable

namespace Langfuse
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a new user in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ScimUser> ScimCreateUserAsync(

            global::Langfuse.ScimCreateUserRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.ScimUser>> ScimCreateUserAsResponseAsync(

            global::Langfuse.ScimCreateUserRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="userName">
        /// User's email address (required)
        /// </param>
        /// <param name="name"></param>
        /// <param name="emails">
        /// User's email addresses
        /// </param>
        /// <param name="active">
        /// Whether the user is active
        /// </param>
        /// <param name="password">
        /// Initial password for the user
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.ScimUser> ScimCreateUserAsync(
            string userName,
            global::Langfuse.ScimName name,
            global::System.Collections.Generic.IList<global::Langfuse.ScimEmail>? emails = default,
            bool? active = default,
            string? password = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}