#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class GetScoresResponseDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.GetScoresResponseData>
    {
        /// <inheritdoc />
        public override global::Langfuse.GetScoresResponseData Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? getScoresResponseDataVariant1 = default;
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? getScoresResponseDataVariant2 = default;
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? getScoresResponseDataVariant3 = default;
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? getScoresResponseDataVariant4 = default;
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? getScoresResponseDataVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>).Name}");
                        getScoresResponseDataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>).Name}");
                        getScoresResponseDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>).Name}");
                        getScoresResponseDataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>).Name}");
                        getScoresResponseDataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>).Name}");
                        getScoresResponseDataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (getScoresResponseDataVariant1 == null && getScoresResponseDataVariant2 == null && getScoresResponseDataVariant3 == null && getScoresResponseDataVariant4 == null && getScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>).Name}");
                    getScoresResponseDataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (getScoresResponseDataVariant1 == null && getScoresResponseDataVariant2 == null && getScoresResponseDataVariant3 == null && getScoresResponseDataVariant4 == null && getScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>).Name}");
                    getScoresResponseDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (getScoresResponseDataVariant1 == null && getScoresResponseDataVariant2 == null && getScoresResponseDataVariant3 == null && getScoresResponseDataVariant4 == null && getScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>).Name}");
                    getScoresResponseDataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (getScoresResponseDataVariant1 == null && getScoresResponseDataVariant2 == null && getScoresResponseDataVariant3 == null && getScoresResponseDataVariant4 == null && getScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>).Name}");
                    getScoresResponseDataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (getScoresResponseDataVariant1 == null && getScoresResponseDataVariant2 == null && getScoresResponseDataVariant3 == null && getScoresResponseDataVariant4 == null && getScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>).Name}");
                    getScoresResponseDataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.GetScoresResponseData(
                getScoresResponseDataVariant1,

                getScoresResponseDataVariant2,

                getScoresResponseDataVariant3,

                getScoresResponseDataVariant4,

                getScoresResponseDataVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.GetScoresResponseData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGetScoresResponseDataVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetScoresResponseDataVariant1!.Value, typeInfo);
            }
            else if (value.IsGetScoresResponseDataVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetScoresResponseDataVariant2!.Value, typeInfo);
            }
            else if (value.IsGetScoresResponseDataVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetScoresResponseDataVariant3!.Value, typeInfo);
            }
            else if (value.IsGetScoresResponseDataVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetScoresResponseDataVariant4!.Value, typeInfo);
            }
            else if (value.IsGetScoresResponseDataVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetScoresResponseDataVariant5!.Value, typeInfo);
            }
        }
    }
}