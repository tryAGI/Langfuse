
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilterBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilterWithKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilter), TypeInfoPropertyName = "EvaluationRuleReadFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode), TypeInfoPropertyName = "UnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicResultsOrderBy), TypeInfoPropertyName = "UnstableTopicResultsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicResultListMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicRuleList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicSummaryState), TypeInfoPropertyName = "UnstableTopicSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicSummaryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicAssignmentStatus), TypeInfoPropertyName = "UnstableTopicAssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicAssignmentTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicAssignmentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicsOrderBy), TypeInfoPropertyName = "UnstableTopicsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicFacetPublishedRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicFacet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicFacetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicFacetRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicWithStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicStatusCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicFacetCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableTopicFacetCounts>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.EvaluationRuleReadFilter?), TypeInfoPropertyName = "NullableEvaluationRuleReadFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode?), TypeInfoPropertyName = "NullableUnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicResultsOrderBy?), TypeInfoPropertyName = "NullableUnstableTopicResultsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicSummaryState?), TypeInfoPropertyName = "NullableUnstableTopicSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicAssignmentStatus?), TypeInfoPropertyName = "NullableUnstableTopicAssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableTopicsOrderBy?), TypeInfoPropertyName = "NullableUnstableTopicsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.EvaluationRuleReadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopicRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopicSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopicAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableTopicFacetCounts>))]
    internal sealed partial class UnstableTopicsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UnstableTopicsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UnstableTopicsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.EvaluationRuleReadFilterJsonConverter());
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
                    typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicResultsOrderBy)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicResultsOrderBy?)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicSummaryState)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicSummaryState?)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicAssignmentStatus)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicAssignmentStatus?)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicsOrderBy)

                    || typeToConvert == typeof(global::Langfuse.UnstableTopicsOrderBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicResultsOrderBy))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicResultsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicResultsOrderBy?))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicResultsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicSummaryState))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicSummaryStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicSummaryState?))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicSummaryStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicAssignmentStatus))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicAssignmentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicAssignmentStatus?))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicAssignmentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicsOrderBy))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableTopicsOrderBy?))
                {
                    return new global::Langfuse.JsonConverters.UnstableTopicsOrderByNullableJsonConverter();
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
                    0 => new UnstableTopicsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}