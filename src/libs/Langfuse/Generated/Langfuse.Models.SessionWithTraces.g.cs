
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionWithTraces
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.Trace> Traces { get; set; }

        /// <summary>
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_deprecation")]
        public global::Langfuse.Deprecation? Deprecation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionWithTraces" /> class.
        /// </summary>
        /// <param name="traces"></param>
        /// <param name="deprecation">
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionWithTraces(
            global::System.Collections.Generic.IList<global::Langfuse.Trace> traces,
            global::Langfuse.Deprecation? deprecation)
        {
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.Deprecation = deprecation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionWithTraces" /> class.
        /// </summary>
        public SessionWithTraces()
        {
        }

    }
}