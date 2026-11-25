#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class DecisionModelQuestionDecisionModelBooleanQuestionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType>
    {
        /// <inheritdoc />
        public override global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType Read(
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
                        return global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestionTypeExtensions.ToValueString(value));
        }
    }
}
