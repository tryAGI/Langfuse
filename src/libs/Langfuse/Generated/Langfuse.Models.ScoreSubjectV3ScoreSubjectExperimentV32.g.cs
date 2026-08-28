
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoreSubjectV3ScoreSubjectExperimentV32
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectExperimentV3KindJsonConverter))]
        public global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectV3ScoreSubjectExperimentV32" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreSubjectV3ScoreSubjectExperimentV32(
            global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectV3ScoreSubjectExperimentV32" /> class.
        /// </summary>
        public ScoreSubjectV3ScoreSubjectExperimentV32()
        {
        }

    }
}