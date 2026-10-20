#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class SkillVersionFileCreateInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.SkillVersionFileCreateInput>
    {
        /// <inheritdoc />
        public override global::Langfuse.SkillVersionFileCreateInput Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("path")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("sha256Hash")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.SkillVersionFileInput? skillVersionFileInput = default;
            global::Langfuse.SkillVersionFileReference? skillVersionFileReference = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileInput).Name}");
                        skillVersionFileInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileReference> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileReference).Name}");
                        skillVersionFileReference = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (skillVersionFileInput == null && skillVersionFileReference == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileInput).Name}");
                    skillVersionFileInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (skillVersionFileInput == null && skillVersionFileReference == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileReference> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileReference).Name}");
                    skillVersionFileReference = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Langfuse.SkillVersionFileCreateInput(
                skillVersionFileInput,

                skillVersionFileReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.SkillVersionFileCreateInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSkillVersionFileInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSkillVersionFileInput(), typeInfo);
            }
            else if (value.IsSkillVersionFileReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.SkillVersionFileReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.SkillVersionFileReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.SkillVersionFileReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSkillVersionFileReference(), typeInfo);
            }
        }
    }
}