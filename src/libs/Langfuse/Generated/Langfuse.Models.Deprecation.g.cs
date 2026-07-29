
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
    /// </summary>
    public sealed partial class Deprecation
    {
        /// <summary>
        /// Human- and agent-readable summary of the deprecation and its replacement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The replacement endpoint, e.g. "GET /api/public/v2/observations". Omitted when the endpoint is being removed without a direct replacement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacement")]
        public string? Replacement { get; set; }

        /// <summary>
        /// Link to the migration documentation (markdown), when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docsUrl")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// ISO date after which the endpoint may stop working, when a removal date is committed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunsetAt")]
        public string? SunsetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deprecation" /> class.
        /// </summary>
        /// <param name="message">
        /// Human- and agent-readable summary of the deprecation and its replacement.
        /// </param>
        /// <param name="replacement">
        /// The replacement endpoint, e.g. "GET /api/public/v2/observations". Omitted when the endpoint is being removed without a direct replacement.
        /// </param>
        /// <param name="docsUrl">
        /// Link to the migration documentation (markdown), when available.
        /// </param>
        /// <param name="sunsetAt">
        /// ISO date after which the endpoint may stop working, when a removal date is committed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Deprecation(
            string message,
            string? replacement,
            string? docsUrl,
            string? sunsetAt)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Replacement = replacement;
            this.DocsUrl = docsUrl;
            this.SunsetAt = sunsetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deprecation" /> class.
        /// </summary>
        public Deprecation()
        {
        }

    }
}