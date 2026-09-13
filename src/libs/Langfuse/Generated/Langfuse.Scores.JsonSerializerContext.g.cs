
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Deprecation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource), TypeInfoPropertyName = "ScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Score))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>), TypeInfoPropertyName = "AllOfScoreNumericScore2NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScoreDataType), TypeInfoPropertyName = "ScoreNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>), TypeInfoPropertyName = "AllOfScoreCategoricalScore2CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScoreDataType), TypeInfoPropertyName = "ScoreCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>), TypeInfoPropertyName = "AllOfScoreBooleanScore2BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScoreDataType), TypeInfoPropertyName = "ScoreBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>), TypeInfoPropertyName = "AllOfScoreCorrectionScore2CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScoreDataType), TypeInfoPropertyName = "ScoreCorrectionScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>), TypeInfoPropertyName = "AllOfScoreTextScore2TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScore2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScoreDataType), TypeInfoPropertyName = "ScoreTextScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreValue), TypeInfoPropertyName = "CreateScoreValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreDataType), TypeInfoPropertyName = "ScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreSource), TypeInfoPropertyName = "CreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseTraceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataNumeric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataCategorical))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataCorrection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseData), TypeInfoPropertyName = "GetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataNumeric2GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataNumericDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataCategorical2GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataCategoricalDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataBoolean2GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataBooleanDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataCorrection2GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataCorrectionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>), TypeInfoPropertyName = "AllOfGetScoresResponseDataGetScoresResponseDataText2GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType), TypeInfoPropertyName = "GetScoresResponseDataGetScoresResponseDataTextDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.GetScoresResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource?), TypeInfoPropertyName = "NullableScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>?), TypeInfoPropertyName = "NullableAllOfScoreNumericScore2NumericScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreNumericScoreDataType?), TypeInfoPropertyName = "NullableScoreNumericScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>?), TypeInfoPropertyName = "NullableAllOfScoreCategoricalScore2CategoricalScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCategoricalScoreDataType?), TypeInfoPropertyName = "NullableScoreCategoricalScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>?), TypeInfoPropertyName = "NullableAllOfScoreBooleanScore2BooleanScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreBooleanScoreDataType?), TypeInfoPropertyName = "NullableScoreBooleanScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>?), TypeInfoPropertyName = "NullableAllOfScoreCorrectionScore2CorrectionScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreCorrectionScoreDataType?), TypeInfoPropertyName = "NullableScoreCorrectionScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>?), TypeInfoPropertyName = "NullableAllOfScoreTextScore2TextScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreTextScoreDataType?), TypeInfoPropertyName = "NullableScoreTextScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreValue?), TypeInfoPropertyName = "NullableCreateScoreValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreDataType?), TypeInfoPropertyName = "NullableScoreDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateScoreSource?), TypeInfoPropertyName = "NullableCreateScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseData?), TypeInfoPropertyName = "NullableGetScoresResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataNumeric2GetScoresResponseDataNumeric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataNumericDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataCategorical2GetScoresResponseDataCategorical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataCategoricalDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataBoolean2GetScoresResponseDataBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataBooleanDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataCorrection2GetScoresResponseDataCorrection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataCorrectionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?), TypeInfoPropertyName = "NullableAllOfGetScoresResponseDataGetScoresResponseDataText2GetScoresResponseDataText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?), TypeInfoPropertyName = "NullableGetScoresResponseDataGetScoresResponseDataTextDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.GetScoresResponseData>))]
    internal sealed partial class ScoresSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ScoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ScoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Langfuse.JsonConverters.CreateScoreValueJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.GetScoresResponseDataJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreNumericScore2, global::Langfuse.NumericScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreCategoricalScore2, global::Langfuse.CategoricalScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreBooleanScore2, global::Langfuse.BooleanScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreCorrectionScore2, global::Langfuse.CorrectionScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreTextScore2, global::Langfuse.TextScore>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.ScoreDataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreDataType?)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource)

                    || typeToConvert == typeof(global::Langfuse.CreateScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType)

                    || typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreNumericScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreNumericScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreNumericScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreCategoricalScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCategoricalScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreCategoricalScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreBooleanScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreBooleanScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreBooleanScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreCorrectionScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreCorrectionScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreCorrectionScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreTextScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreTextScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreTextScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreDataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreDataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.CreateScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataNumericDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumericDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataNumericDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCategoricalDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategoricalDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCategoricalDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataBooleanDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataBooleanDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataBooleanDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCorrectionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrectionDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataCorrectionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataTextDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.GetScoresResponseDataGetScoresResponseDataTextDataType?))
                {
                    return new global::Langfuse.JsonConverters.GetScoresResponseDataGetScoresResponseDataTextDataTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ScoresSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}