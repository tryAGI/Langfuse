#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Evaluator output definition returned by the public API.<br/>
    /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
    /// Legacy stored evaluator definitions are normalized into this shape before they are returned.<br/>
    /// Use this response shape when deciding how to interpret future evaluation scores:<br/>
    /// - `NUMERIC`: expect numeric score values<br/>
    /// - `BOOLEAN`: expect `true` / `false`<br/>
    /// - `CATEGORICAL`: expect one or more values from `score.categories`
    /// </summary>
    public readonly partial struct UnstablePublicEvaluatorOutputDefinition : global::System.IEquatable<UnstablePublicEvaluatorOutputDefinition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstablePublicNumericEvaluatorOutputDefinition { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstablePublicNumericEvaluatorOutputDefinition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicNumericEvaluatorOutputDefinition))]
#endif
        public bool IsUnstablePublicNumericEvaluatorOutputDefinition => UnstablePublicNumericEvaluatorOutputDefinition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstablePublicNumericEvaluatorOutputDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicNumericEvaluatorOutputDefinition;
            return IsUnstablePublicNumericEvaluatorOutputDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition> PickUnstablePublicNumericEvaluatorOutputDefinition() => IsUnstablePublicNumericEvaluatorOutputDefinition
            ? UnstablePublicNumericEvaluatorOutputDefinition!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicNumericEvaluatorOutputDefinition' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstablePublicBooleanEvaluatorOutputDefinition { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstablePublicBooleanEvaluatorOutputDefinition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicBooleanEvaluatorOutputDefinition))]
#endif
        public bool IsUnstablePublicBooleanEvaluatorOutputDefinition => UnstablePublicBooleanEvaluatorOutputDefinition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstablePublicBooleanEvaluatorOutputDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicBooleanEvaluatorOutputDefinition;
            return IsUnstablePublicBooleanEvaluatorOutputDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition> PickUnstablePublicBooleanEvaluatorOutputDefinition() => IsUnstablePublicBooleanEvaluatorOutputDefinition
            ? UnstablePublicBooleanEvaluatorOutputDefinition!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicBooleanEvaluatorOutputDefinition' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstablePublicCategoricalEvaluatorOutputDefinition { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstablePublicCategoricalEvaluatorOutputDefinition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicCategoricalEvaluatorOutputDefinition))]
#endif
        public bool IsUnstablePublicCategoricalEvaluatorOutputDefinition => UnstablePublicCategoricalEvaluatorOutputDefinition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstablePublicCategoricalEvaluatorOutputDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicCategoricalEvaluatorOutputDefinition;
            return IsUnstablePublicCategoricalEvaluatorOutputDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition> PickUnstablePublicCategoricalEvaluatorOutputDefinition() => IsUnstablePublicCategoricalEvaluatorOutputDefinition
            ? UnstablePublicCategoricalEvaluatorOutputDefinition!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicCategoricalEvaluatorOutputDefinition' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicNumericEvaluatorOutputDefinition;

        /// <summary>
        ///
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            UnstablePublicNumericEvaluatorOutputDefinition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicNumericEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicBooleanEvaluatorOutputDefinition;

        /// <summary>
        ///
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            UnstablePublicBooleanEvaluatorOutputDefinition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicBooleanEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicCategoricalEvaluatorOutputDefinition;

        /// <summary>
        ///
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            UnstablePublicCategoricalEvaluatorOutputDefinition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicCategoricalEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? unstablePublicNumericEvaluatorOutputDefinition,
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? unstablePublicBooleanEvaluatorOutputDefinition,
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? unstablePublicCategoricalEvaluatorOutputDefinition
            )
        {
            UnstablePublicNumericEvaluatorOutputDefinition = unstablePublicNumericEvaluatorOutputDefinition;
            UnstablePublicBooleanEvaluatorOutputDefinition = unstablePublicBooleanEvaluatorOutputDefinition;
            UnstablePublicCategoricalEvaluatorOutputDefinition = unstablePublicCategoricalEvaluatorOutputDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstablePublicCategoricalEvaluatorOutputDefinition as object ??
            UnstablePublicBooleanEvaluatorOutputDefinition as object ??
            UnstablePublicNumericEvaluatorOutputDefinition as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstablePublicNumericEvaluatorOutputDefinition?.ToString() ??
            UnstablePublicBooleanEvaluatorOutputDefinition?.ToString() ??
            UnstablePublicCategoricalEvaluatorOutputDefinition?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstablePublicNumericEvaluatorOutputDefinition && !IsUnstablePublicBooleanEvaluatorOutputDefinition && !IsUnstablePublicCategoricalEvaluatorOutputDefinition || !IsUnstablePublicNumericEvaluatorOutputDefinition && IsUnstablePublicBooleanEvaluatorOutputDefinition && !IsUnstablePublicCategoricalEvaluatorOutputDefinition || !IsUnstablePublicNumericEvaluatorOutputDefinition && !IsUnstablePublicBooleanEvaluatorOutputDefinition && IsUnstablePublicCategoricalEvaluatorOutputDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?, TResult>? unstablePublicNumericEvaluatorOutputDefinition = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?, TResult>? unstablePublicBooleanEvaluatorOutputDefinition = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?, TResult>? unstablePublicCategoricalEvaluatorOutputDefinition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicNumericEvaluatorOutputDefinition && unstablePublicNumericEvaluatorOutputDefinition != null)
            {
                return unstablePublicNumericEvaluatorOutputDefinition(UnstablePublicNumericEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicBooleanEvaluatorOutputDefinition && unstablePublicBooleanEvaluatorOutputDefinition != null)
            {
                return unstablePublicBooleanEvaluatorOutputDefinition(UnstablePublicBooleanEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicCategoricalEvaluatorOutputDefinition && unstablePublicCategoricalEvaluatorOutputDefinition != null)
            {
                return unstablePublicCategoricalEvaluatorOutputDefinition(UnstablePublicCategoricalEvaluatorOutputDefinition!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstablePublicNumericEvaluatorOutputDefinition = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstablePublicBooleanEvaluatorOutputDefinition = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstablePublicCategoricalEvaluatorOutputDefinition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicNumericEvaluatorOutputDefinition)
            {
                unstablePublicNumericEvaluatorOutputDefinition?.Invoke(UnstablePublicNumericEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicBooleanEvaluatorOutputDefinition)
            {
                unstablePublicBooleanEvaluatorOutputDefinition?.Invoke(UnstablePublicBooleanEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicCategoricalEvaluatorOutputDefinition)
            {
                unstablePublicCategoricalEvaluatorOutputDefinition?.Invoke(UnstablePublicCategoricalEvaluatorOutputDefinition!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstablePublicNumericEvaluatorOutputDefinition = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstablePublicBooleanEvaluatorOutputDefinition = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstablePublicCategoricalEvaluatorOutputDefinition = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicNumericEvaluatorOutputDefinition)
            {
                unstablePublicNumericEvaluatorOutputDefinition?.Invoke(UnstablePublicNumericEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicBooleanEvaluatorOutputDefinition)
            {
                unstablePublicBooleanEvaluatorOutputDefinition?.Invoke(UnstablePublicBooleanEvaluatorOutputDefinition!);
            }
            else if (IsUnstablePublicCategoricalEvaluatorOutputDefinition)
            {
                unstablePublicCategoricalEvaluatorOutputDefinition?.Invoke(UnstablePublicCategoricalEvaluatorOutputDefinition!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstablePublicNumericEvaluatorOutputDefinition,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),
                UnstablePublicBooleanEvaluatorOutputDefinition,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),
                UnstablePublicCategoricalEvaluatorOutputDefinition,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),
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
        public bool Equals(UnstablePublicEvaluatorOutputDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicNumericEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicNumericEvaluatorOutputDefinition, other.UnstablePublicNumericEvaluatorOutputDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicBooleanEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicBooleanEvaluatorOutputDefinition, other.UnstablePublicBooleanEvaluatorOutputDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicCategoricalEvaluatorOutputDefinition, other.UnstablePublicCategoricalEvaluatorOutputDefinition)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstablePublicEvaluatorOutputDefinition obj1, UnstablePublicEvaluatorOutputDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstablePublicEvaluatorOutputDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstablePublicEvaluatorOutputDefinition obj1, UnstablePublicEvaluatorOutputDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstablePublicEvaluatorOutputDefinition o && Equals(o);
        }
    }
}
