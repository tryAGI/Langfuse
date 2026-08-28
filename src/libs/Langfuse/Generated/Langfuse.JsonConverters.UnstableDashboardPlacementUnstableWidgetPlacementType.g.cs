#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableDashboardPlacementUnstableWidgetPlacementTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType Read(
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
                        return global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementTypeExtensions.ToValueString(value));
        }
    }
}
