
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableCreatePresetPlacement
    {
        /// <summary>
        /// Server-generated when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresetId { get; set; }

        /// <summary>
        /// Grid column (12-column grid). Defaults to `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public int? X { get; set; }

        /// <summary>
        /// Grid row. Defaults to the first row below all existing tiles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public int? Y { get; set; }

        /// <summary>
        /// Width in grid columns. Defaults to `6`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height in grid rows. Defaults to `6`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreatePresetPlacement" /> class.
        /// </summary>
        /// <param name="presetId"></param>
        /// <param name="id">
        /// Server-generated when omitted.
        /// </param>
        /// <param name="x">
        /// Grid column (12-column grid). Defaults to `0`.
        /// </param>
        /// <param name="y">
        /// Grid row. Defaults to the first row below all existing tiles.
        /// </param>
        /// <param name="width">
        /// Width in grid columns. Defaults to `6`.
        /// </param>
        /// <param name="height">
        /// Height in grid rows. Defaults to `6`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCreatePresetPlacement(
            string presetId,
            string? id,
            int? x,
            int? y,
            int? width,
            int? height)
        {
            this.Id = id;
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCreatePresetPlacement" /> class.
        /// </summary>
        public UnstableCreatePresetPlacement()
        {
        }

    }
}