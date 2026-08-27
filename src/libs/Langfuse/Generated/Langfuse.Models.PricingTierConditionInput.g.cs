#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Condition input for matching a pricing tier.
    /// </summary>
    public readonly partial struct PricingTierConditionInput : global::System.IEquatable<PricingTierConditionInput>
    {
        /// <summary>
        /// Input condition that sums usage details whose keys match a regex.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.PricingTierUsageConditionInput? PricingTierUsageConditionInput { get; init; }
#else
        public global::Langfuse.PricingTierUsageConditionInput? PricingTierUsageConditionInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingTierUsageConditionInput))]
#endif
        public bool IsPricingTierUsageConditionInput => PricingTierUsageConditionInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingTierUsageConditionInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.PricingTierUsageConditionInput? value)
        {
            value = PricingTierUsageConditionInput;
            return IsPricingTierUsageConditionInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PricingTierUsageConditionInput PickPricingTierUsageConditionInput() => IsPricingTierUsageConditionInput
            ? PricingTierUsageConditionInput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingTierUsageConditionInput' but the value was {ToString()}.");

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
        public static implicit operator PricingTierConditionInput(global::Langfuse.PricingTierUsageConditionInput value) => new PricingTierConditionInput((global::Langfuse.PricingTierUsageConditionInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.PricingTierUsageConditionInput?(PricingTierConditionInput @this) => @this.PricingTierUsageConditionInput;

        /// <summary>
        ///
        /// </summary>
        public PricingTierConditionInput(global::Langfuse.PricingTierUsageConditionInput? value)
        {
            PricingTierUsageConditionInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingTierConditionInput FromPricingTierUsageConditionInput(global::Langfuse.PricingTierUsageConditionInput? value) => new PricingTierConditionInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingTierConditionInput(global::Langfuse.PricingTierAttributeCondition value) => new PricingTierConditionInput((global::Langfuse.PricingTierAttributeCondition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.PricingTierAttributeCondition?(PricingTierConditionInput @this) => @this.PricingTierAttributeCondition;

        /// <summary>
        ///
        /// </summary>
        public PricingTierConditionInput(global::Langfuse.PricingTierAttributeCondition? value)
        {
            PricingTierAttributeCondition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingTierConditionInput FromPricingTierAttributeCondition(global::Langfuse.PricingTierAttributeCondition? value) => new PricingTierConditionInput(value);

        /// <summary>
        ///
        /// </summary>
        public PricingTierConditionInput(
            global::Langfuse.PricingTierUsageConditionInput? pricingTierUsageConditionInput,
            global::Langfuse.PricingTierAttributeCondition? pricingTierAttributeCondition
            )
        {
            PricingTierUsageConditionInput = pricingTierUsageConditionInput;
            PricingTierAttributeCondition = pricingTierAttributeCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PricingTierAttributeCondition as object ??
            PricingTierUsageConditionInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PricingTierUsageConditionInput?.ToString() ??
            PricingTierAttributeCondition?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPricingTierUsageConditionInput && !IsPricingTierAttributeCondition || !IsPricingTierUsageConditionInput && IsPricingTierAttributeCondition;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.PricingTierUsageConditionInput, TResult>? pricingTierUsageConditionInput = null,
            global::System.Func<global::Langfuse.PricingTierAttributeCondition, TResult>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageConditionInput && pricingTierUsageConditionInput != null)
            {
                return pricingTierUsageConditionInput(PricingTierUsageConditionInput!);
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
            global::System.Action<global::Langfuse.PricingTierUsageConditionInput>? pricingTierUsageConditionInput = null,

            global::System.Action<global::Langfuse.PricingTierAttributeCondition>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageConditionInput)
            {
                pricingTierUsageConditionInput?.Invoke(PricingTierUsageConditionInput!);
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
            global::System.Action<global::Langfuse.PricingTierUsageConditionInput>? pricingTierUsageConditionInput = null,
            global::System.Action<global::Langfuse.PricingTierAttributeCondition>? pricingTierAttributeCondition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPricingTierUsageConditionInput)
            {
                pricingTierUsageConditionInput?.Invoke(PricingTierUsageConditionInput!);
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
                PricingTierUsageConditionInput,
                typeof(global::Langfuse.PricingTierUsageConditionInput),
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
        public bool Equals(PricingTierConditionInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.PricingTierUsageConditionInput?>.Default.Equals(PricingTierUsageConditionInput, other.PricingTierUsageConditionInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.PricingTierAttributeCondition?>.Default.Equals(PricingTierAttributeCondition, other.PricingTierAttributeCondition)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PricingTierConditionInput obj1, PricingTierConditionInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PricingTierConditionInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PricingTierConditionInput obj1, PricingTierConditionInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PricingTierConditionInput o && Equals(o);
        }
    }
}
