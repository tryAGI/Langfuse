#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Condition for matching a pricing tier against usage details or observation attributes.<br/>
    /// Usage-detail conditions treat usageDetailPattern as a regex, sum all matching usage values, and compare the sum to the numeric value. Model-parameter and metadata conditions match an exact top-level key against one or more string values.
    /// </summary>
    public readonly partial struct PricingTierCondition : global::System.IEquatable<PricingTierCondition>
    {
        /// <summary>
        /// Condition that sums usage details whose keys match a regex.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.PricingTierUsageCondition? PricingTierUsageCondition { get; init; }
#else
        public global::Langfuse.PricingTierUsageCondition? PricingTierUsageCondition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingTierUsageCondition))]
#endif
        public bool IsPricingTierUsageCondition => PricingTierUsageCondition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingTierUsageCondition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.PricingTierUsageCondition? value)
        {
            value = PricingTierUsageCondition;
            return IsPricingTierUsageCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageCondition PickPricingTierUsageCondition() => IsPricingTierUsageCondition
            ? PricingTierUsageCondition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingTierUsageCondition' but the value was {ToString()}.");

        /// <summary>
        /// Condition that matches any configured value for a top-level observation attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.PricingTierAttributeCondition? PricingTierAttributeCondition { get; init; }
#else
        public global::Langfuse.PricingTierAttributeCondition? PricingTierAttributeCondition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingTierAttributeCondition))]
#endif
        public bool IsPricingTierAttributeCondition => PricingTierAttributeCondition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingTierAttributeCondition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.PricingTierAttributeCondition? value)
        {
            value = PricingTierAttributeCondition;
            return IsPricingTierAttributeCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierAttributeCondition PickPricingTierAttributeCondition() => IsPricingTierAttributeCondition
            ? PricingTierAttributeCondition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingTierAttributeCondition' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingTierCondition(global::Langfuse.PricingTierUsageCondition value) => new PricingTierCondition((global::Langfuse.PricingTierUsageCondition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.PricingTierUsageCondition?(PricingTierCondition @this) => @this.PricingTierUsageCondition;

        /// <summary>
        ///
        /// </summary>
        public PricingTierCondition(global::Langfuse.PricingTierUsageCondition? value)
        {
            PricingTierUsageCondition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingTierCondition FromPricingTierUsageCondition(global::Langfuse.PricingTierUsageCondition? value) => new PricingTierCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingTierCondition(global::Langfuse.PricingTierAttributeCondition value) => new PricingTierCondition((global::Langfuse.PricingTierAttributeCondition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.PricingTierAttributeCondition?(PricingTierCondition @this) => @this.PricingTierAttributeCondition;

        /// <summary>
        ///
        /// </summary>
        public PricingTierCondition(global::Langfuse.PricingTierAttributeCondition? value)
        {
            PricingTierAttributeCondition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingTierCondition FromPricingTierAttributeCondition(global::Langfuse.PricingTierAttributeCondition? value) => new PricingTierCondition(value);

        /// <summary>
        ///
        /// </summary>
        public PricingTierCondition(
            global::Langfuse.PricingTierUsageCondition? pricingTierUsageCondition,
            global::Langfuse.PricingTierAttributeCondition? pricingTierAttributeCondition
            )
        {
            PricingTierUsageCondition = pricingTierUsageCondition;
            PricingTierAttributeCondition = pricingTierAttributeCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PricingTierAttributeCondition as object ??
            PricingTierUsageCondition as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PricingTierUsageCondition?.ToString() ??
            PricingTierAttributeCondition?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPricingTierUsageCondition && !IsPricingTierAttributeCondition || !IsPricingTierUsageCondition && IsPricingTierAttributeCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.PricingTierUsageCondition, TResult>? pricingTierUsageCondition = null,
            global::System.Func<global::Langfuse.PricingTierAttributeCondition, TResult>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageCondition && pricingTierUsageCondition != null)
            {
                return pricingTierUsageCondition(PricingTierUsageCondition!);
            }
            else if (IsPricingTierAttributeCondition && pricingTierAttributeCondition != null)
            {
                return pricingTierAttributeCondition(PricingTierAttributeCondition!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.PricingTierUsageCondition>? pricingTierUsageCondition = null,

            global::System.Action<global::Langfuse.PricingTierAttributeCondition>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageCondition)
            {
                pricingTierUsageCondition?.Invoke(PricingTierUsageCondition!);
            }
            else if (IsPricingTierAttributeCondition)
            {
                pricingTierAttributeCondition?.Invoke(PricingTierAttributeCondition!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.PricingTierUsageCondition>? pricingTierUsageCondition = null,
            global::System.Action<global::Langfuse.PricingTierAttributeCondition>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageCondition)
            {
                pricingTierUsageCondition?.Invoke(PricingTierUsageCondition!);
            }
            else if (IsPricingTierAttributeCondition)
            {
                pricingTierAttributeCondition?.Invoke(PricingTierAttributeCondition!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PricingTierUsageCondition,
                typeof(global::Langfuse.PricingTierUsageCondition),
                PricingTierAttributeCondition,
                typeof(global::Langfuse.PricingTierAttributeCondition),
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
        public bool Equals(PricingTierCondition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.PricingTierUsageCondition?>.Default.Equals(PricingTierUsageCondition, other.PricingTierUsageCondition) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.PricingTierAttributeCondition?>.Default.Equals(PricingTierAttributeCondition, other.PricingTierAttributeCondition)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PricingTierCondition obj1, PricingTierCondition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PricingTierCondition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PricingTierCondition obj1, PricingTierCondition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PricingTierCondition o && Equals(o);
        }
    }
}
