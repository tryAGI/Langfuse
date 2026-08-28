#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeExtensions.ToValueString(value));
        }
    }
}
