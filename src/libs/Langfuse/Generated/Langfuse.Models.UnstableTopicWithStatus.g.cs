
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicWithStatus
    {
        /// <summary>
        /// Always true; retired topics are not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inCurrentMap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InCurrentMap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicWithStatus" /> class.
        /// </summary>
        /// <param name="inCurrentMap">
        /// Always true; retired topics are not returned.
        /// </param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicWithStatus(
            bool inCurrentMap,
            global::Langfuse.UnstableTopicWindow window)
        {
            this.InCurrentMap = inCurrentMap;
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicWithStatus" /> class.
        /// </summary>
        public UnstableTopicWithStatus()
        {
        }

    }
}