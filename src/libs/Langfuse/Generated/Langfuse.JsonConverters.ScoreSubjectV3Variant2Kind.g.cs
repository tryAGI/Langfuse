#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScoreSubjectV3Variant2KindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.ScoreSubjectV3Variant2Kind>
    {
        /// <inheritdoc />
        public override global::Langfuse.ScoreSubjectV3Variant2Kind Read(
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
                        return global::Langfuse.ScoreSubjectV3Variant2KindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.ScoreSubjectV3Variant2Kind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.ScoreSubjectV3Variant2Kind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.ScoreSubjectV3Variant2Kind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.ScoreSubjectV3Variant2KindExtensions.ToValueString(value));
        }
    }
}
