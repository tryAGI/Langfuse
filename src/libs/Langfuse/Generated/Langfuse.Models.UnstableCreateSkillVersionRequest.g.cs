
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableCreateSkillVersionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput> Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMessage")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateSkillVersionRequest" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="commitMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreateSkillVersionRequest(
            global::System.Collections.Generic.IList<global::Langfuse.UnstableSkillVersionFileCreateInput> files,
            string? commitMessage)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreateSkillVersionRequest" /> class.
        /// </summary>
        public UnstableCreateSkillVersionRequest()
        {
        }

    }
}