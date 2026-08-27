
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstablePresetPlacement
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
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePresetPlacement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="presetId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePresetPlacement(
            string id,
            string presetId,
            int x,
            int y,
            int width,
            int height)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePresetPlacement" /> class.
        /// </summary>
        public UnstablePresetPlacement()
        {
        }

    }
}