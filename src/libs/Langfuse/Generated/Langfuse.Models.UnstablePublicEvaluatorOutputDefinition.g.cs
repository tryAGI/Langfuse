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
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicEvaluatorOutputDefinitionVariant1))]
#endif
        public bool IsUnstablePublicEvaluatorOutputDefinitionVariant1 => UnstablePublicEvaluatorOutputDefinitionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstablePublicEvaluatorOutputDefinitionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicEvaluatorOutputDefinitionVariant1;
            return IsUnstablePublicEvaluatorOutputDefinitionVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition> PickUnstablePublicEvaluatorOutputDefinitionVariant1() => IsUnstablePublicEvaluatorOutputDefinitionVariant1
            ? UnstablePublicEvaluatorOutputDefinitionVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicEvaluatorOutputDefinitionVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicEvaluatorOutputDefinitionVariant2))]
#endif
        public bool IsUnstablePublicEvaluatorOutputDefinitionVariant2 => UnstablePublicEvaluatorOutputDefinitionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstablePublicEvaluatorOutputDefinitionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicEvaluatorOutputDefinitionVariant2;
            return IsUnstablePublicEvaluatorOutputDefinitionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition> PickUnstablePublicEvaluatorOutputDefinitionVariant2() => IsUnstablePublicEvaluatorOutputDefinitionVariant2
            ? UnstablePublicEvaluatorOutputDefinitionVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicEvaluatorOutputDefinitionVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstablePublicEvaluatorOutputDefinitionVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePublicEvaluatorOutputDefinitionVariant3))]
#endif
        public bool IsUnstablePublicEvaluatorOutputDefinitionVariant3 => UnstablePublicEvaluatorOutputDefinitionVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstablePublicEvaluatorOutputDefinitionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            value = UnstablePublicEvaluatorOutputDefinitionVariant3;
            return IsUnstablePublicEvaluatorOutputDefinitionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition> PickUnstablePublicEvaluatorOutputDefinitionVariant3() => IsUnstablePublicEvaluatorOutputDefinitionVariant3
            ? UnstablePublicEvaluatorOutputDefinitionVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePublicEvaluatorOutputDefinitionVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicEvaluatorOutputDefinitionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            UnstablePublicEvaluatorOutputDefinitionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicEvaluatorOutputDefinitionVariant1(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicEvaluatorOutputDefinitionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            UnstablePublicEvaluatorOutputDefinitionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicEvaluatorOutputDefinitionVariant2(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition> value) => new UnstablePublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?(UnstablePublicEvaluatorOutputDefinition @this) => @this.UnstablePublicEvaluatorOutputDefinitionVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            UnstablePublicEvaluatorOutputDefinitionVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstablePublicEvaluatorOutputDefinition FromUnstablePublicEvaluatorOutputDefinitionVariant3(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value) => new UnstablePublicEvaluatorOutputDefinition(value);

        /// <summary>
        /// 
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinition(
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? unstablePublicEvaluatorOutputDefinitionVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? unstablePublicEvaluatorOutputDefinitionVariant2,
            global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? unstablePublicEvaluatorOutputDefinitionVariant3
            )
        {
            UnstablePublicEvaluatorOutputDefinitionVariant1 = unstablePublicEvaluatorOutputDefinitionVariant1;
            UnstablePublicEvaluatorOutputDefinitionVariant2 = unstablePublicEvaluatorOutputDefinitionVariant2;
            UnstablePublicEvaluatorOutputDefinitionVariant3 = unstablePublicEvaluatorOutputDefinitionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstablePublicEvaluatorOutputDefinitionVariant3 as object ??
            UnstablePublicEvaluatorOutputDefinitionVariant2 as object ??
            UnstablePublicEvaluatorOutputDefinitionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstablePublicEvaluatorOutputDefinitionVariant1?.ToString() ??
            UnstablePublicEvaluatorOutputDefinitionVariant2?.ToString() ??
            UnstablePublicEvaluatorOutputDefinitionVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstablePublicEvaluatorOutputDefinitionVariant1 && !IsUnstablePublicEvaluatorOutputDefinitionVariant2 && !IsUnstablePublicEvaluatorOutputDefinitionVariant3 || !IsUnstablePublicEvaluatorOutputDefinitionVariant1 && IsUnstablePublicEvaluatorOutputDefinitionVariant2 && !IsUnstablePublicEvaluatorOutputDefinitionVariant3 || !IsUnstablePublicEvaluatorOutputDefinitionVariant1 && !IsUnstablePublicEvaluatorOutputDefinitionVariant2 && IsUnstablePublicEvaluatorOutputDefinitionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?, TResult>? unstablePublicEvaluatorOutputDefinitionVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?, TResult>? unstablePublicEvaluatorOutputDefinitionVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?, TResult>? unstablePublicEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicEvaluatorOutputDefinitionVariant1 && unstablePublicEvaluatorOutputDefinitionVariant1 != null)
            {
                return unstablePublicEvaluatorOutputDefinitionVariant1(UnstablePublicEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant2 && unstablePublicEvaluatorOutputDefinitionVariant2 != null)
            {
                return unstablePublicEvaluatorOutputDefinitionVariant2(UnstablePublicEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant3 && unstablePublicEvaluatorOutputDefinitionVariant3 != null)
            {
                return unstablePublicEvaluatorOutputDefinitionVariant3(UnstablePublicEvaluatorOutputDefinitionVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicEvaluatorOutputDefinitionVariant1)
            {
                unstablePublicEvaluatorOutputDefinitionVariant1?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant2)
            {
                unstablePublicEvaluatorOutputDefinitionVariant2?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant3)
            {
                unstablePublicEvaluatorOutputDefinitionVariant3?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstablePublicEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstablePublicEvaluatorOutputDefinitionVariant1)
            {
                unstablePublicEvaluatorOutputDefinitionVariant1?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant2)
            {
                unstablePublicEvaluatorOutputDefinitionVariant2?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstablePublicEvaluatorOutputDefinitionVariant3)
            {
                unstablePublicEvaluatorOutputDefinitionVariant3?.Invoke(UnstablePublicEvaluatorOutputDefinitionVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstablePublicEvaluatorOutputDefinitionVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),
                UnstablePublicEvaluatorOutputDefinitionVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),
                UnstablePublicEvaluatorOutputDefinitionVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicEvaluatorOutputDefinitionVariant1, other.UnstablePublicEvaluatorOutputDefinitionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicEvaluatorOutputDefinitionVariant2, other.UnstablePublicEvaluatorOutputDefinitionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstablePublicEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>.Default.Equals(UnstablePublicEvaluatorOutputDefinitionVariant3, other.UnstablePublicEvaluatorOutputDefinitionVariant3) 
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
