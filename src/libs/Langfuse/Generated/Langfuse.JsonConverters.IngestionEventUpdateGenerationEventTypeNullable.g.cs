#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class IngestionEventUpdateGenerationEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionEventUpdateGenerationEventType?>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionEventUpdateGenerationEventType? Read(
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
                        return global::Langfuse.IngestionEventUpdateGenerationEventTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.IngestionEventUpdateGenerationEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.IngestionEventUpdateGenerationEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionEventUpdateGenerationEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.IngestionEventUpdateGenerationEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
