
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextScore
    {
        /// <summary>
        /// The text content of the score (1-500 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextScore" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// The text content of the score (1-500 characters)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextScore(
            string stringValue)
        {
            this.StringValue = stringValue ?? throw new global::System.ArgumentNullException(nameof(stringValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextScore" /> class.
        /// </summary>
        public TextScore()
        {
        }

    }
}