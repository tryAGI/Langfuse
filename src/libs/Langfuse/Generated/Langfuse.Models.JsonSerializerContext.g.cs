
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelUsageUnit), TypeInfoPropertyName = "ModelUsageUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Langfuse.ModelPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierCondition), TypeInfoPropertyName = "PricingTierCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierUsageCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierOperator), TypeInfoPropertyName = "PricingTierOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeSource), TypeInfoPropertyName = "PricingTierAttributeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierConditionInput), TypeInfoPropertyName = "PricingTierConditionInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierUsageConditionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierConditionInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelTokenizerId), TypeInfoPropertyName = "ModelTokenizerId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PaginatedModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelUsageUnit?), TypeInfoPropertyName = "NullableModelUsageUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierCondition?), TypeInfoPropertyName = "NullablePricingTierCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierOperator?), TypeInfoPropertyName = "NullablePricingTierOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierAttributeSource?), TypeInfoPropertyName = "NullablePricingTierAttributeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PricingTierConditionInput?), TypeInfoPropertyName = "NullablePricingTierConditionInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ModelTokenizerId?), TypeInfoPropertyName = "NullableModelTokenizerId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierConditionInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PricingTierInput>))]
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PricingTierConditionInputJsonConverter());
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
                    typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource)

                    || typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource?)

                    || typeToConvert == typeof(global::Langfuse.PricingTierOperator)

                    || typeToConvert == typeof(global::Langfuse.PricingTierOperator?)

                    || typeToConvert == typeof(global::Langfuse.ModelUsageUnit)

                    || typeToConvert == typeof(global::Langfuse.ModelUsageUnit?)

                    || typeToConvert == typeof(global::Langfuse.ModelTokenizerId)

                    || typeToConvert == typeof(global::Langfuse.ModelTokenizerId?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource))
                {
                    return new global::Langfuse.JsonConverters.PricingTierAttributeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierAttributeSource?))
                {
                    return new global::Langfuse.JsonConverters.PricingTierAttributeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierOperator))
                {
                    return new global::Langfuse.JsonConverters.PricingTierOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PricingTierOperator?))
                {
                    return new global::Langfuse.JsonConverters.PricingTierOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelUsageUnit))
                {
                    return new global::Langfuse.JsonConverters.ModelUsageUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelUsageUnit?))
                {
                    return new global::Langfuse.JsonConverters.ModelUsageUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelTokenizerId))
                {
                    return new global::Langfuse.JsonConverters.ModelTokenizerIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ModelTokenizerId?))
                {
                    return new global::Langfuse.JsonConverters.ModelTokenizerIdNullableJsonConverter();
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
                    0 => new ModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}