#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class BlobStorageIntegrationFileTypeResponseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.BlobStorageIntegrationFileTypeResponse?>
    {
        /// <inheritdoc />
        public override global::Langfuse.BlobStorageIntegrationFileTypeResponse? Read(
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
                        return global::Langfuse.BlobStorageIntegrationFileTypeResponseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.BlobStorageIntegrationFileTypeResponse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.BlobStorageIntegrationFileTypeResponse?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.BlobStorageIntegrationFileTypeResponse? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.BlobStorageIntegrationFileTypeResponseExtensions.ToValueString(value.Value));
            }
        }
    }
}
