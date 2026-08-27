#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Evaluation rule returned by list and get, including read-only legacy trace and dataset rules.
    /// </summary>
    public readonly partial struct UnstableReadableEvaluationRule : global::System.IEquatable<UnstableReadableEvaluationRule>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableEvaluationRule? UnstableEvaluationRule { get; init; }
#else
        public global::Langfuse.UnstableEvaluationRule? UnstableEvaluationRule { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRule))]
#endif
        public bool IsUnstableEvaluationRule => UnstableEvaluationRule != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableEvaluationRule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableEvaluationRule? value)
        {
            value = UnstableEvaluationRule;
            return IsUnstableEvaluationRule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableEvaluationRule PickUnstableEvaluationRule() => IsUnstableEvaluationRule
            ? UnstableEvaluationRule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableEvaluationRule' but the value was {ToString()}.");

        /// <summary>
        /// Legacy trace- or dataset-level evaluation rule returned by list and get for migration.<br/>
        /// This resource is read-only through the unstable public API. Its mapping preserves the trace, dataset item, or named observation selected for each evaluator variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableLegacyEvaluationRule? UnstableLegacyEvaluationRule { get; init; }
#else
        public global::Langfuse.UnstableLegacyEvaluationRule? UnstableLegacyEvaluationRule { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableLegacyEvaluationRule))]
#endif
        public bool IsUnstableLegacyEvaluationRule => UnstableLegacyEvaluationRule != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableLegacyEvaluationRule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableLegacyEvaluationRule? value)
        {
            value = UnstableLegacyEvaluationRule;
            return IsUnstableLegacyEvaluationRule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableLegacyEvaluationRule PickUnstableLegacyEvaluationRule() => IsUnstableLegacyEvaluationRule
            ? UnstableLegacyEvaluationRule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableLegacyEvaluationRule' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableReadableEvaluationRule(global::Langfuse.UnstableEvaluationRule value) => new UnstableReadableEvaluationRule((global::Langfuse.UnstableEvaluationRule?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UnstableEvaluationRule?(UnstableReadableEvaluationRule @this) => @this.UnstableEvaluationRule;

        /// <summary>
        ///
        /// </summary>
        public UnstableReadableEvaluationRule(global::Langfuse.UnstableEvaluationRule? value)
        {
            UnstableEvaluationRule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableReadableEvaluationRule FromUnstableEvaluationRule(global::Langfuse.UnstableEvaluationRule? value) => new UnstableReadableEvaluationRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableReadableEvaluationRule(global::Langfuse.UnstableLegacyEvaluationRule value) => new UnstableReadableEvaluationRule((global::Langfuse.UnstableLegacyEvaluationRule?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UnstableLegacyEvaluationRule?(UnstableReadableEvaluationRule @this) => @this.UnstableLegacyEvaluationRule;

        /// <summary>
        ///
        /// </summary>
        public UnstableReadableEvaluationRule(global::Langfuse.UnstableLegacyEvaluationRule? value)
        {
            UnstableLegacyEvaluationRule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableReadableEvaluationRule FromUnstableLegacyEvaluationRule(global::Langfuse.UnstableLegacyEvaluationRule? value) => new UnstableReadableEvaluationRule(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableReadableEvaluationRule(
            global::Langfuse.UnstableEvaluationRule? unstableEvaluationRule,
            global::Langfuse.UnstableLegacyEvaluationRule? unstableLegacyEvaluationRule
            )
        {
            UnstableEvaluationRule = unstableEvaluationRule;
            UnstableLegacyEvaluationRule = unstableLegacyEvaluationRule;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableLegacyEvaluationRule as object ??
            UnstableEvaluationRule as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableEvaluationRule?.ToString() ??
            UnstableLegacyEvaluationRule?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableEvaluationRule && !IsUnstableLegacyEvaluationRule || !IsUnstableEvaluationRule && IsUnstableLegacyEvaluationRule;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.UnstableEvaluationRule, TResult>? unstableEvaluationRule = null,
            global::System.Func<global::Langfuse.UnstableLegacyEvaluationRule, TResult>? unstableLegacyEvaluationRule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluationRule && unstableEvaluationRule != null)
            {
                return unstableEvaluationRule(UnstableEvaluationRule!);
            }
            else if (IsUnstableLegacyEvaluationRule && unstableLegacyEvaluationRule != null)
            {
                return unstableLegacyEvaluationRule(UnstableLegacyEvaluationRule!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.UnstableEvaluationRule>? unstableEvaluationRule = null,

            global::System.Action<global::Langfuse.UnstableLegacyEvaluationRule>? unstableLegacyEvaluationRule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluationRule)
            {
                unstableEvaluationRule?.Invoke(UnstableEvaluationRule!);
            }
            else if (IsUnstableLegacyEvaluationRule)
            {
                unstableLegacyEvaluationRule?.Invoke(UnstableLegacyEvaluationRule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.UnstableEvaluationRule>? unstableEvaluationRule = null,
            global::System.Action<global::Langfuse.UnstableLegacyEvaluationRule>? unstableLegacyEvaluationRule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluationRule)
            {
                unstableEvaluationRule?.Invoke(UnstableEvaluationRule!);
            }
            else if (IsUnstableLegacyEvaluationRule)
            {
                unstableLegacyEvaluationRule?.Invoke(UnstableLegacyEvaluationRule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableEvaluationRule,
                typeof(global::Langfuse.UnstableEvaluationRule),
                UnstableLegacyEvaluationRule,
                typeof(global::Langfuse.UnstableLegacyEvaluationRule),
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
        public bool Equals(UnstableReadableEvaluationRule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableEvaluationRule?>.Default.Equals(UnstableEvaluationRule, other.UnstableEvaluationRule) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableLegacyEvaluationRule?>.Default.Equals(UnstableLegacyEvaluationRule, other.UnstableLegacyEvaluationRule)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstableReadableEvaluationRule obj1, UnstableReadableEvaluationRule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableReadableEvaluationRule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstableReadableEvaluationRule obj1, UnstableReadableEvaluationRule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableReadableEvaluationRule o && Equals(o);
        }
    }
}
