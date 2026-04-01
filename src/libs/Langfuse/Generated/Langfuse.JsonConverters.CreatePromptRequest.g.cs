#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class CreatePromptRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.CreatePromptRequest>
    {
        /// <inheritdoc />
        public override global::Langfuse.CreatePromptRequest Read(
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
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("commitMessage")) __score0++;
            if (__jsonProps.Contains("config")) __score0++;
            if (__jsonProps.Contains("labels")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("tags")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("commitMessage")) __score1++;
            if (__jsonProps.Contains("config")) __score1++;
            if (__jsonProps.Contains("labels")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("tags")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.CreateChatPromptRequest? createChatPromptRequest = default;
            global::Langfuse.CreateTextPromptRequest? createTextPromptRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateChatPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateChatPromptRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateChatPromptRequest).Name}");
                        createChatPromptRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateTextPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateTextPromptRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateTextPromptRequest).Name}");
                        createTextPromptRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createChatPromptRequest == null && createTextPromptRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateChatPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateChatPromptRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateChatPromptRequest).Name}");
                    createChatPromptRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateTextPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateTextPromptRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateTextPromptRequest).Name}");
                    createTextPromptRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.CreatePromptRequest(
                createChatPromptRequest,

                createTextPromptRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.CreatePromptRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateChatPromptRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateChatPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateChatPromptRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateChatPromptRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatPromptRequest!, typeInfo);
            }
            else if (value.IsCreateTextPromptRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateTextPromptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateTextPromptRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateTextPromptRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateTextPromptRequest!, typeInfo);
            }
        }
    }
}