
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Deprecation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Trace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceWithDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceWithFullDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ObservationsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationsView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ScoreV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1), TypeInfoPropertyName = "ScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Observation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel), TypeInfoPropertyName = "ObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BaseScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource), TypeInfoPropertyName = "ScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.NumericScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BooleanScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CategoricalScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextScoreV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>), TypeInfoPropertyName = "AllOfScoreV1NumericScoreV12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV1DataType), TypeInfoPropertyName = "ScoreV1NumericScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>), TypeInfoPropertyName = "AllOfScoreV1CategoricalScoreV12CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType), TypeInfoPropertyName = "ScoreV1CategoricalScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>), TypeInfoPropertyName = "AllOfScoreV1BooleanScoreV12BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType), TypeInfoPropertyName = "ScoreV1BooleanScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>), TypeInfoPropertyName = "AllOfScoreV1TextScoreV12TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV1DataType), TypeInfoPropertyName = "ScoreV1TextScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Traces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.TraceWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.DeleteTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TraceDeleteMultipleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1?), TypeInfoPropertyName = "NullableScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ObservationLevel?), TypeInfoPropertyName = "NullableObservationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreSource?), TypeInfoPropertyName = "NullableScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1NumericScoreV12NumericScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1NumericScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1CategoricalScoreV12CategoricalScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1CategoricalScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1BooleanScoreV12BooleanScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1BooleanScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?), TypeInfoPropertyName = "NullableAllOfScoreV1TextScoreV12TextScoreV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ScoreV1TextScoreV1DataType?), TypeInfoPropertyName = "NullableScoreV1TextScoreV1DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ObservationsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ScoreV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.TraceWithDetails>))]
    internal sealed partial class TraceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TraceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TraceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TraceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.ScoreV1JsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>());
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
                    typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType)

                    || typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType?)

                    || typeToConvert == typeof(global::Langfuse.ObservationLevel)

                    || typeToConvert == typeof(global::Langfuse.ObservationLevel?)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource)

                    || typeToConvert == typeof(global::Langfuse.ScoreSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1NumericScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1NumericScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1NumericScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1CategoricalScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1CategoricalScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1CategoricalScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1BooleanScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1BooleanScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1BooleanScoreV1DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1TextScoreV1DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ScoreV1TextScoreV1DataType?))
                {
                    return new global::Langfuse.JsonConverters.ScoreV1TextScoreV1DataTypeNullableJsonConverter();
                }

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
                    0 => new TraceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}