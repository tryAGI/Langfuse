
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableSkillFile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256Hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256Hash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableSkillFile" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="blobId"></param>
        /// <param name="sha256Hash"></param>
        /// <param name="contentType"></param>
        /// <param name="contentLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableSkillFile(
            string id,
            string path,
            string blobId,
            string sha256Hash,
            string contentType,
            long contentLength)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.BlobId = blobId ?? throw new global::System.ArgumentNullException(nameof(blobId));
            this.Sha256Hash = sha256Hash ?? throw new global::System.ArgumentNullException(nameof(sha256Hash));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ContentLength = contentLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableSkillFile" /> class.
        /// </summary>
        public UnstableSkillFile()
        {
        }

    }
}