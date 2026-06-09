
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreSubjectVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.ScoreSubjectVariant3KindJsonConverter))]
        public global::Langfuse.ScoreSubjectVariant3Kind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectVariant32" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreSubjectVariant32(
            global::Langfuse.ScoreSubjectVariant3Kind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectVariant32" /> class.
        /// </summary>
        public ScoreSubjectVariant32()
        {
        }

    }
}