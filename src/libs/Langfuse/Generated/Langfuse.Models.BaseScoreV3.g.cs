
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseScoreV3
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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.ScoreSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.ScoreSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The environment from which this score originated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Optional comment attached to the score. Present when "details" is included in the fields parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The score config ID, if this score was created from a config. Present when "details" is included in the fields parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Arbitrary metadata attached to the score. Present when "details" is included in the fields parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The user who created this score, if available. Present when "annotation" is included in the fields parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorUserId")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// The annotation queue this score belongs to, if any. Present when "annotation" is included in the fields parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// A reference to the entity this score is attached to. Discriminated by "kind" — one of trace, observation, session, or experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.ScoreSubjectV3JsonConverter))]
        public global::Langfuse.ScoreSubjectV3? Subject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScoreV3" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="timestamp"></param>
        /// <param name="environment">
        /// The environment from which this score originated.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="comment">
        /// Optional comment attached to the score. Present when "details" is included in the fields parameter.
        /// </param>
        /// <param name="configId">
        /// The score config ID, if this score was created from a config. Present when "details" is included in the fields parameter.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata attached to the score. Present when "details" is included in the fields parameter.
        /// </param>
        /// <param name="authorUserId">
        /// The user who created this score, if available. Present when "annotation" is included in the fields parameter.
        /// </param>
        /// <param name="queueId">
        /// The annotation queue this score belongs to, if any. Present when "annotation" is included in the fields parameter.
        /// </param>
        /// <param name="subject">
        /// A reference to the entity this score is attached to. Discriminated by "kind" — one of trace, observation, session, or experiment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseScoreV3(
            string id,
            string projectId,
            string name,
            global::Langfuse.ScoreSource source,
            global::System.DateTime timestamp,
            string environment,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? comment,
            string? configId,
            object? metadata,
            string? authorUserId,
            string? queueId,
            global::Langfuse.ScoreSubjectV3? subject)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.Timestamp = timestamp;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Comment = comment;
            this.ConfigId = configId;
            this.Metadata = metadata;
            this.AuthorUserId = authorUserId;
            this.QueueId = queueId;
            this.Subject = subject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScoreV3" /> class.
        /// </summary>
        public BaseScoreV3()
        {
        }

    }
}