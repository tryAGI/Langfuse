#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType Read(
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
                        return global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinitionDataTypeExtensions.ToValueString(value));
        }
    }
}
