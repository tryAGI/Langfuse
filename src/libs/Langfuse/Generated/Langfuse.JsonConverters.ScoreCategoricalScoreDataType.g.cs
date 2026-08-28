#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScoreCategoricalScoreDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.ScoreCategoricalScoreDataType>
    {
        /// <inheritdoc />
        public override global::Langfuse.ScoreCategoricalScoreDataType Read(
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
                        return global::Langfuse.ScoreCategoricalScoreDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.ScoreCategoricalScoreDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.ScoreCategoricalScoreDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.ScoreCategoricalScoreDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.ScoreCategoricalScoreDataTypeExtensions.ToValueString(value));
        }
    }
}
