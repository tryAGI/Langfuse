
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptVersionUpdateRequest
    {
        /// <summary>
        /// New labels for the prompt version. Labels are unique across versions. The "latest" label is reserved and managed by Langfuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newLabels")]
        public global::System.Collections.Generic.IList<string>? NewLabels { get; set; }

        /// <summary>
        /// Labels to remove from the prompt version. The "latest" label is reserved and managed by Langfuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeLabels")]
        public global::System.Collections.Generic.IList<string>? RemoveLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdateRequest" /> class.
        /// </summary>
        /// <param name="newLabels">
        /// New labels for the prompt version. Labels are unique across versions. The "latest" label is reserved and managed by Langfuse.
        /// </param>
        /// <param name="removeLabels">
        /// Labels to remove from the prompt version. The "latest" label is reserved and managed by Langfuse.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionUpdateRequest(
            global::System.Collections.Generic.IList<string>? newLabels,
            global::System.Collections.Generic.IList<string>? removeLabels)
        {
            this.NewLabels = newLabels;
            this.RemoveLabels = removeLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdateRequest" /> class.
        /// </summary>
        public PromptVersionUpdateRequest()
        {
        }

    }
}