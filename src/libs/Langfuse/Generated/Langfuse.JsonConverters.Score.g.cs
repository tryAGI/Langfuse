#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class ScoreJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.Score>
    {
        /// <inheritdoc />
        public override global::Langfuse.Score Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>), options);
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

            global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? scoreVariant1 = default;
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? scoreVariant2 = default;
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? scoreVariant3 = default;
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? scoreVariant4 = default;
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>? scoreVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>).Name}");
                        scoreVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>).Name}");
                        scoreVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>).Name}");
                        scoreVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>).Name}");
                        scoreVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>).Name}");
                        scoreVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scoreVariant1 == null && scoreVariant2 == null && scoreVariant3 == null && scoreVariant4 == null && scoreVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>).Name}");
                    scoreVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>).Name}");
                    scoreVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>).Name}");
                    scoreVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>).Name}");
                    scoreVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>).Name}");
                    scoreVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.Score(
                scoreVariant1,

                scoreVariant2,

                scoreVariant3,

                scoreVariant4,

                scoreVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.Score value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScoreVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant1!.Value, typeInfo);
            }
            else if (value.IsScoreVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant2!.Value, typeInfo);
            }
            else if (value.IsScoreVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant3!.Value, typeInfo);
            }
            else if (value.IsScoreVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant4!.Value, typeInfo);
            }
            else if (value.IsScoreVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreVariant5!.Value, typeInfo);
            }
        }
    }
}