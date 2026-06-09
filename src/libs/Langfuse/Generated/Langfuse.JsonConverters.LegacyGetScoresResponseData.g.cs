#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class LegacyGetScoresResponseDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.LegacyGetScoresResponseData>
    {
        /// <inheritdoc />
        public override global::Langfuse.LegacyGetScoresResponseData Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>), options);
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

            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? legacyGetScoresResponseDataVariant1 = default;
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? legacyGetScoresResponseDataVariant2 = default;
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? legacyGetScoresResponseDataVariant3 = default;
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? legacyGetScoresResponseDataVariant4 = default;
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? legacyGetScoresResponseDataVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>).Name}");
                        legacyGetScoresResponseDataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>).Name}");
                        legacyGetScoresResponseDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>).Name}");
                        legacyGetScoresResponseDataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>).Name}");
                        legacyGetScoresResponseDataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>).Name}");
                        legacyGetScoresResponseDataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (legacyGetScoresResponseDataVariant1 == null && legacyGetScoresResponseDataVariant2 == null && legacyGetScoresResponseDataVariant3 == null && legacyGetScoresResponseDataVariant4 == null && legacyGetScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>).Name}");
                    legacyGetScoresResponseDataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (legacyGetScoresResponseDataVariant1 == null && legacyGetScoresResponseDataVariant2 == null && legacyGetScoresResponseDataVariant3 == null && legacyGetScoresResponseDataVariant4 == null && legacyGetScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>).Name}");
                    legacyGetScoresResponseDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (legacyGetScoresResponseDataVariant1 == null && legacyGetScoresResponseDataVariant2 == null && legacyGetScoresResponseDataVariant3 == null && legacyGetScoresResponseDataVariant4 == null && legacyGetScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>).Name}");
                    legacyGetScoresResponseDataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (legacyGetScoresResponseDataVariant1 == null && legacyGetScoresResponseDataVariant2 == null && legacyGetScoresResponseDataVariant3 == null && legacyGetScoresResponseDataVariant4 == null && legacyGetScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>).Name}");
                    legacyGetScoresResponseDataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (legacyGetScoresResponseDataVariant1 == null && legacyGetScoresResponseDataVariant2 == null && legacyGetScoresResponseDataVariant3 == null && legacyGetScoresResponseDataVariant4 == null && legacyGetScoresResponseDataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>).Name}");
                    legacyGetScoresResponseDataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.LegacyGetScoresResponseData(
                legacyGetScoresResponseDataVariant1,

                legacyGetScoresResponseDataVariant2,

                legacyGetScoresResponseDataVariant3,

                legacyGetScoresResponseDataVariant4,

                legacyGetScoresResponseDataVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.LegacyGetScoresResponseData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLegacyGetScoresResponseDataVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyGetScoresResponseDataVariant1!.Value, typeInfo);
            }
            else if (value.IsLegacyGetScoresResponseDataVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyGetScoresResponseDataVariant2!.Value, typeInfo);
            }
            else if (value.IsLegacyGetScoresResponseDataVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyGetScoresResponseDataVariant3!.Value, typeInfo);
            }
            else if (value.IsLegacyGetScoresResponseDataVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyGetScoresResponseDataVariant4!.Value, typeInfo);
            }
            else if (value.IsLegacyGetScoresResponseDataVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyGetScoresResponseDataVariant5!.Value, typeInfo);
            }
        }
    }
}