#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType Read(
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
                        return global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilterTypeExtensions.ToValueString(value));
        }
    }
}
