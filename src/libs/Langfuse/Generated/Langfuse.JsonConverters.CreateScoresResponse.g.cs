#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class CreateScoresResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.CreateScoresResponse>
    {
        /// <inheritdoc />
        public override global::Langfuse.CreateScoresResponse Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("message")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("accepted")) __score2++;
            if (__jsonProps.Contains("errors")) __score2++;
            if (__jsonProps.Contains("rejected")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Langfuse.CreateScoreResponse? createScoreResponse = default;
            global::Langfuse.CreateScoreBatchResponse? createScoreBatchResponse = default;
            global::Langfuse.CreateScoreBatchResults? createScoreBatchResults = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreResponse).Name}");
                        createScoreResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResponse).Name}");
                        createScoreBatchResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResults> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResults).Name}");
                        createScoreBatchResults = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createScoreResponse == null && createScoreBatchResponse == null && createScoreBatchResults == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreResponse).Name}");
                    createScoreResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createScoreResponse == null && createScoreBatchResponse == null && createScoreBatchResults == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResponse).Name}");
                    createScoreBatchResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createScoreResponse == null && createScoreBatchResponse == null && createScoreBatchResults == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResults> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResults).Name}");
                    createScoreBatchResults = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.CreateScoresResponse(
                createScoreResponse,

                createScoreBatchResponse,

                createScoreBatchResults
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.CreateScoresResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateScoreResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCreateScoreResponse(), typeInfo);
            }
            else if (value.IsCreateScoreBatchResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCreateScoreBatchResponse(), typeInfo);
            }
            else if (value.IsCreateScoreBatchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.CreateScoreBatchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.CreateScoreBatchResults?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.CreateScoreBatchResults).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCreateScoreBatchResults(), typeInfo);
            }
        }
    }
}