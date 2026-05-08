#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Structured output definition to send when creating an evaluator.<br/>
    /// Agent guidance:<br/>
    /// - `dataType` is required.<br/>
    /// - Do not send `version`; that is an internal storage detail and is not part of the public request contract.<br/>
    /// - For `NUMERIC` and `BOOLEAN`, provide `reasoning.description` and `score.description`.<br/>
    /// - For `CATEGORICAL`, also provide `score.categories` and `score.shouldAllowMultipleMatches`.
    /// </summary>
    public readonly partial struct UnstableEvaluatorOutputDefinition : global::System.IEquatable<UnstableEvaluatorOutputDefinition>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluatorOutputDefinitionVariant1))]
#endif
        public bool IsUnstableEvaluatorOutputDefinitionVariant1 => UnstableEvaluatorOutputDefinitionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableEvaluatorOutputDefinitionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            value = UnstableEvaluatorOutputDefinitionVariant1;
            return IsUnstableEvaluatorOutputDefinitionVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluatorOutputDefinitionVariant2))]
#endif
        public bool IsUnstableEvaluatorOutputDefinitionVariant2 => UnstableEvaluatorOutputDefinitionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableEvaluatorOutputDefinitionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            value = UnstableEvaluatorOutputDefinitionVariant2;
            return IsUnstableEvaluatorOutputDefinitionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? UnstableEvaluatorOutputDefinitionVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluatorOutputDefinitionVariant3))]
#endif
        public bool IsUnstableEvaluatorOutputDefinitionVariant3 => UnstableEvaluatorOutputDefinitionVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableEvaluatorOutputDefinitionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            value = UnstableEvaluatorOutputDefinitionVariant3;
            return IsUnstableEvaluatorOutputDefinitionVariant3;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition> value) => new UnstableEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?(UnstableEvaluatorOutputDefinition @this) => @this.UnstableEvaluatorOutputDefinitionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? value)
        {
            UnstableEvaluatorOutputDefinitionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition> value) => new UnstableEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?(UnstableEvaluatorOutputDefinition @this) => @this.UnstableEvaluatorOutputDefinitionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? value)
        {
            UnstableEvaluatorOutputDefinitionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition> value) => new UnstableEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?(UnstableEvaluatorOutputDefinition @this) => @this.UnstableEvaluatorOutputDefinitionVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? value)
        {
            UnstableEvaluatorOutputDefinitionVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluatorOutputDefinition(
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>? unstableEvaluatorOutputDefinitionVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>? unstableEvaluatorOutputDefinitionVariant2,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>? unstableEvaluatorOutputDefinitionVariant3
            )
        {
            UnstableEvaluatorOutputDefinitionVariant1 = unstableEvaluatorOutputDefinitionVariant1;
            UnstableEvaluatorOutputDefinitionVariant2 = unstableEvaluatorOutputDefinitionVariant2;
            UnstableEvaluatorOutputDefinitionVariant3 = unstableEvaluatorOutputDefinitionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableEvaluatorOutputDefinitionVariant3 as object ??
            UnstableEvaluatorOutputDefinitionVariant2 as object ??
            UnstableEvaluatorOutputDefinitionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableEvaluatorOutputDefinitionVariant1?.ToString() ??
            UnstableEvaluatorOutputDefinitionVariant2?.ToString() ??
            UnstableEvaluatorOutputDefinitionVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableEvaluatorOutputDefinitionVariant1 && !IsUnstableEvaluatorOutputDefinitionVariant2 && !IsUnstableEvaluatorOutputDefinitionVariant3 || !IsUnstableEvaluatorOutputDefinitionVariant1 && IsUnstableEvaluatorOutputDefinitionVariant2 && !IsUnstableEvaluatorOutputDefinitionVariant3 || !IsUnstableEvaluatorOutputDefinitionVariant1 && !IsUnstableEvaluatorOutputDefinitionVariant2 && IsUnstableEvaluatorOutputDefinitionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?, TResult>? unstableEvaluatorOutputDefinitionVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?, TResult>? unstableEvaluatorOutputDefinitionVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?, TResult>? unstableEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorOutputDefinitionVariant1 && unstableEvaluatorOutputDefinitionVariant1 != null)
            {
                return unstableEvaluatorOutputDefinitionVariant1(UnstableEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant2 && unstableEvaluatorOutputDefinitionVariant2 != null)
            {
                return unstableEvaluatorOutputDefinitionVariant2(UnstableEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant3 && unstableEvaluatorOutputDefinitionVariant3 != null)
            {
                return unstableEvaluatorOutputDefinitionVariant3(UnstableEvaluatorOutputDefinitionVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorOutputDefinitionVariant1)
            {
                unstableEvaluatorOutputDefinitionVariant1?.Invoke(UnstableEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant2)
            {
                unstableEvaluatorOutputDefinitionVariant2?.Invoke(UnstableEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant3)
            {
                unstableEvaluatorOutputDefinitionVariant3?.Invoke(UnstableEvaluatorOutputDefinitionVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>? unstableEvaluatorOutputDefinitionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorOutputDefinitionVariant1)
            {
                unstableEvaluatorOutputDefinitionVariant1?.Invoke(UnstableEvaluatorOutputDefinitionVariant1!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant2)
            {
                unstableEvaluatorOutputDefinitionVariant2?.Invoke(UnstableEvaluatorOutputDefinitionVariant2!);
            }
            else if (IsUnstableEvaluatorOutputDefinitionVariant3)
            {
                unstableEvaluatorOutputDefinitionVariant3?.Invoke(UnstableEvaluatorOutputDefinitionVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableEvaluatorOutputDefinitionVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>),
                UnstableEvaluatorOutputDefinitionVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>),
                UnstableEvaluatorOutputDefinitionVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>),
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
        public bool Equals(UnstableEvaluatorOutputDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant12, global::Langfuse.UnstablePublicNumericEvaluatorOutputDefinition>?>.Default.Equals(UnstableEvaluatorOutputDefinitionVariant1, other.UnstableEvaluatorOutputDefinitionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant22, global::Langfuse.UnstablePublicBooleanEvaluatorOutputDefinition>?>.Default.Equals(UnstableEvaluatorOutputDefinitionVariant2, other.UnstableEvaluatorOutputDefinitionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorOutputDefinitionVariant32, global::Langfuse.UnstablePublicCategoricalEvaluatorOutputDefinition>?>.Default.Equals(UnstableEvaluatorOutputDefinitionVariant3, other.UnstableEvaluatorOutputDefinitionVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnstableEvaluatorOutputDefinition obj1, UnstableEvaluatorOutputDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableEvaluatorOutputDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnstableEvaluatorOutputDefinition obj1, UnstableEvaluatorOutputDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableEvaluatorOutputDefinition o && Equals(o);
        }
    }
}
