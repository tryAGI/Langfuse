#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluationRuleStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleStatus?>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleStatus? Read(
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
                        return global::Langfuse.UnstableEvaluationRuleStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluationRuleStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluationRuleStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.UnstableEvaluationRuleStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
