
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemMediaReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.DatasetItemMediaReferenceFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.DatasetItemMediaReferenceField Field { get; set; }

        /// <summary>
        /// The Langfuse media reference string, e.g. `@@@langfuseMedia:type=image/png|id=...|source=bytes@@@`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceString { get; set; }

        /// <summary>
        /// JSONPath of the string holding the reference within the field, e.g. `$['image']`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JsonPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.DatasetItemMediaReferenceMedia Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemMediaReference" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="referenceString">
        /// The Langfuse media reference string, e.g. `@@@langfuseMedia:type=image/png|id=...|source=bytes@@@`
        /// </param>
        /// <param name="jsonPath">
        /// JSONPath of the string holding the reference within the field, e.g. `$['image']`
        /// </param>
        /// <param name="media"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemMediaReference(
            global::Langfuse.DatasetItemMediaReferenceField field,
            string referenceString,
            string jsonPath,
            global::Langfuse.DatasetItemMediaReferenceMedia media)
        {
            this.Field = field;
            this.ReferenceString = referenceString ?? throw new global::System.ArgumentNullException(nameof(referenceString));
            this.JsonPath = jsonPath ?? throw new global::System.ArgumentNullException(nameof(jsonPath));
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemMediaReference" /> class.
        /// </summary>
        public DatasetItemMediaReference()
        {
        }

    }
}