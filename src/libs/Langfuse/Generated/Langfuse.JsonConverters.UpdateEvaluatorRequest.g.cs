#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class UpdateEvaluatorRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UpdateEvaluatorRequest>
    {
        /// <inheritdoc />
        public override global::Langfuse.UpdateEvaluatorRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("modelConfig")) __score1++;
            if (__jsonProps.Contains("modelConfig.model")) __score1++;
            if (__jsonProps.Contains("modelConfig.provider")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("outputDefinition")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("variableMapping")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("sourceCode")) __score2++;
            if (__jsonProps.Contains("sourceCodeLanguage")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Langfuse.UpdateEvaluatorMetadataRequest? updateEvaluatorMetadataRequest = default;
            global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? updateLlmAsJudgeEvaluatorRequest = default;
            global::Langfuse.UpdateCodeEvaluatorRequest? updateCodeEvaluatorRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateEvaluatorMetadataRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateEvaluatorMetadataRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateEvaluatorMetadataRequest).Name}");
                        updateEvaluatorMetadataRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest).Name}");
                        updateLlmAsJudgeEvaluatorRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateCodeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateCodeEvaluatorRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateCodeEvaluatorRequest).Name}");
                        updateCodeEvaluatorRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (updateEvaluatorMetadataRequest == null && updateLlmAsJudgeEvaluatorRequest == null && updateCodeEvaluatorRequest == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateEvaluatorMetadataRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateEvaluatorMetadataRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateEvaluatorMetadataRequest).Name}");
                    updateEvaluatorMetadataRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (updateEvaluatorMetadataRequest == null && updateLlmAsJudgeEvaluatorRequest == null && updateCodeEvaluatorRequest == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest).Name}");
                    updateLlmAsJudgeEvaluatorRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (updateEvaluatorMetadataRequest == null && updateLlmAsJudgeEvaluatorRequest == null && updateCodeEvaluatorRequest == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateCodeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateCodeEvaluatorRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateCodeEvaluatorRequest).Name}");
                    updateCodeEvaluatorRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.UpdateEvaluatorRequest(
                updateEvaluatorMetadataRequest,

                updateLlmAsJudgeEvaluatorRequest,

                updateCodeEvaluatorRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UpdateEvaluatorRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUpdateEvaluatorMetadataRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateEvaluatorMetadataRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateEvaluatorMetadataRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateEvaluatorMetadataRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateEvaluatorMetadataRequest!, typeInfo);
            }
            else if (value.IsUpdateLlmAsJudgeEvaluatorRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateLlmAsJudgeEvaluatorRequest!, typeInfo);
            }
            else if (value.IsUpdateCodeEvaluatorRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UpdateCodeEvaluatorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UpdateCodeEvaluatorRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UpdateCodeEvaluatorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCodeEvaluatorRequest!, typeInfo);
            }
        }
    }
}