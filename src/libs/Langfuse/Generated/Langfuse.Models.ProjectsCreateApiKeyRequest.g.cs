
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsCreateApiKeyRequest
    {
        /// <summary>
        /// Optional name for the API key. Cannot be provided together with note, even if either value is an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated alias for name. Cannot be provided together with name, even if either value is an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Note { get; set; }

        /// <summary>
        /// Optional expiration timestamp in ISO 8601 format. Must be in the future. Omit or set to null for a key that does not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional name for the API key. Cannot be provided together with note, even if either value is an empty string.
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration timestamp in ISO 8601 format. Must be in the future. Omit or set to null for a key that does not expire.
        /// </param>
        /// <param name="publicKey">
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </param>
        /// <param name="secretKey">
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateApiKeyRequest(
            string? name,
            global::System.DateTime? expiresAt,
            string? publicKey,
            string? secretKey)
        {
            this.Name = name;
            this.ExpiresAt = expiresAt;
            this.PublicKey = publicKey;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateApiKeyRequest" /> class.
        /// </summary>
        public ProjectsCreateApiKeyRequest()
        {
        }

    }
}