#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IngestionUsage : global::System.IEquatable<IngestionUsage>
    {
        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.Usage? Usage { get; init; }
#else
        public global::Langfuse.Usage? Usage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Usage))]
#endif
        public bool IsUsage => Usage != null;

        /// <summary>
        /// Usage interface of OpenAI for improved compatibility.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.OpenAIUsage? OpenAIUsage { get; init; }
#else
        public global::Langfuse.OpenAIUsage? OpenAIUsage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIUsage))]
#endif
        public bool IsOpenAIUsage => OpenAIUsage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionUsage(global::Langfuse.Usage value) => new IngestionUsage((global::Langfuse.Usage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.Usage?(IngestionUsage @this) => @this.Usage;

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(global::Langfuse.Usage? value)
        {
            Usage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionUsage(global::Langfuse.OpenAIUsage value) => new IngestionUsage((global::Langfuse.OpenAIUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.OpenAIUsage?(IngestionUsage @this) => @this.OpenAIUsage;

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(global::Langfuse.OpenAIUsage? value)
        {
            OpenAIUsage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(
            global::Langfuse.Usage? usage,
            global::Langfuse.OpenAIUsage? openAIUsage
            )
        {
            Usage = usage;
            OpenAIUsage = openAIUsage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAIUsage as object ??
            Usage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Usage?.ToString() ??
            OpenAIUsage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsage && !IsOpenAIUsage || !IsUsage && IsOpenAIUsage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.Usage?, TResult>? usage = null,
            global::System.Func<global::Langfuse.OpenAIUsage?, TResult>? openAIUsage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsage && usage != null)
            {
                return usage(Usage!);
            }
            else if (IsOpenAIUsage && openAIUsage != null)
            {
                return openAIUsage(OpenAIUsage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.Usage?>? usage = null,
            global::System.Action<global::Langfuse.OpenAIUsage?>? openAIUsage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsage)
            {
                usage?.Invoke(Usage!);
            }
            else if (IsOpenAIUsage)
            {
                openAIUsage?.Invoke(OpenAIUsage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Usage,
                typeof(global::Langfuse.Usage),
                OpenAIUsage,
                typeof(global::Langfuse.OpenAIUsage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(IngestionUsage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.Usage?>.Default.Equals(Usage, other.Usage) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.OpenAIUsage?>.Default.Equals(OpenAIUsage, other.OpenAIUsage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IngestionUsage obj1, IngestionUsage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IngestionUsage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IngestionUsage obj1, IngestionUsage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IngestionUsage o && Equals(o);
        }
    }
}
