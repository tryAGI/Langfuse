#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluatorUnstableCodeEvaluatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType Read(
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
                        return global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorTypeExtensions.ToValueString(value));
        }
    }
}
