
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoreSubjectTraceV3
    {
        /// <summary>
        /// The trace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectTraceV3" /> class.
        /// </summary>
        /// <param name="id">
        /// The trace ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreSubjectTraceV3(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectTraceV3" /> class.
        /// </summary>
        public ScoreSubjectTraceV3()
        {
        }

    }
}