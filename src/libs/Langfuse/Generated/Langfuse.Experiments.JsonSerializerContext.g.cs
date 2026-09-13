
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel), TypeInfoPropertyName = "ObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource), TypeInfoPropertyName = "ScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentsResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3), TypeInfoPropertyName = "ScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectTraceV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectObservationV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectSessionV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectExperimentV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3), TypeInfoPropertyName = "ScoreSubjectV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectTraceV32ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectTraceV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectObservationV32ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectObservationV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectSessionV32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectSessionV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>), TypeInfoPropertyName = "AllOfScoreSubjectV3ScoreSubjectExperimentV32ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind), TypeInfoPropertyName = "ScoreSubjectV3ScoreSubjectExperimentV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CorrectionScoreV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>), TypeInfoPropertyName = "AllOfScoreV3NumericScoreV32NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV3DataType), TypeInfoPropertyName = "ScoreV3NumericScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>), TypeInfoPropertyName = "AllOfScoreV3BooleanScoreV32BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType), TypeInfoPropertyName = "ScoreV3BooleanScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>), TypeInfoPropertyName = "AllOfScoreV3CategoricalScoreV32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType), TypeInfoPropertyName = "ScoreV3CategoricalScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>), TypeInfoPropertyName = "AllOfScoreV3TextScoreV32TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV3DataType), TypeInfoPropertyName = "ScoreV3TextScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>), TypeInfoPropertyName = "AllOfScoreV3CorrectionScoreV32CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType), TypeInfoPropertyName = "ScoreV3CorrectionScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel?), TypeInfoPropertyName = "NullableObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource?), TypeInfoPropertyName = "NullableScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3?), TypeInfoPropertyName = "NullableScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3?), TypeInfoPropertyName = "NullableScoreSubjectV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectTraceV32ScoreSubjectTraceV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectTraceV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectObservationV32ScoreSubjectObservationV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectObservationV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectSessionV32ScoreSubjectSessionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectSessionV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?), TypeInfoPropertyName = "NullableAllOfScoreSubjectV3ScoreSubjectExperimentV32ScoreSubjectExperimentV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?), TypeInfoPropertyName = "NullableScoreSubjectV3ScoreSubjectExperimentV3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3NumericScoreV32NumericScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3NumericScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3BooleanScoreV32BooleanScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3BooleanScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3CategoricalScoreV32CategoricalScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3CategoricalScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3TextScoreV32TextScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3TextScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3TextScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?), TypeInfoPropertyName = "NullableAllOfScoreV3CorrectionScoreV32CorrectionScoreV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?), TypeInfoPropertyName = "NullableScoreV3CorrectionScoreV3DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ExperimentItem>))]
    internal sealed partial class ExperimentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExperimentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ExperimentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ExperimentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreSubjectV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV3JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>());
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
                    typeToConvert == typeof(global::Langfuse.ObservationLevel)

                    || typeToConvert == typeof(global::Langfuse.ObservationLevel?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind)

                    || typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.ObservationLevel))
                {
                    return new global::Langfuse.JsonConverters.ObservationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ObservationLevel?))
                {
                    return new global::Langfuse.JsonConverters.ObservationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSource?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectTraceV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectTraceV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectObservationV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectObservationV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectSessionV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectSessionV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectExperimentV3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV3Kind?))
                {
                    return new global::Langfuse.JsonConverters.ScoreSubjectV3ScoreSubjectExperimentV3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3NumericScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3NumericScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3NumericScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3BooleanScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3BooleanScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3BooleanScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CategoricalScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CategoricalScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CategoricalScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3TextScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3TextScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3TextScoreV3DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CorrectionScoreV3DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV3CorrectionScoreV3DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV3CorrectionScoreV3DataTypeNullableJsonConverter();
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
                    0 => new ExperimentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}