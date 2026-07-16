#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UnstableCreateDashboardPlacementRequest : global::System.IEquatable<UnstableCreateDashboardPlacementRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? UnstableCreateDashboardPlacementRequestVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? UnstableCreateDashboardPlacementRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateDashboardPlacementRequestVariant1))]
#endif
        public bool IsUnstableCreateDashboardPlacementRequestVariant1 => UnstableCreateDashboardPlacementRequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateDashboardPlacementRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? value)
        {
            value = UnstableCreateDashboardPlacementRequestVariant1;
            return IsUnstableCreateDashboardPlacementRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement> PickUnstableCreateDashboardPlacementRequestVariant1() => IsUnstableCreateDashboardPlacementRequestVariant1
            ? UnstableCreateDashboardPlacementRequestVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateDashboardPlacementRequestVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? UnstableCreateDashboardPlacementRequestVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? UnstableCreateDashboardPlacementRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateDashboardPlacementRequestVariant2))]
#endif
        public bool IsUnstableCreateDashboardPlacementRequestVariant2 => UnstableCreateDashboardPlacementRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateDashboardPlacementRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? value)
        {
            value = UnstableCreateDashboardPlacementRequestVariant2;
            return IsUnstableCreateDashboardPlacementRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement> PickUnstableCreateDashboardPlacementRequestVariant2() => IsUnstableCreateDashboardPlacementRequestVariant2
            ? UnstableCreateDashboardPlacementRequestVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateDashboardPlacementRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement> value) => new UnstableCreateDashboardPlacementRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?(UnstableCreateDashboardPlacementRequest @this) => @this.UnstableCreateDashboardPlacementRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? value)
        {
            UnstableCreateDashboardPlacementRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateDashboardPlacementRequest FromUnstableCreateDashboardPlacementRequestVariant1(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? value) => new UnstableCreateDashboardPlacementRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement> value) => new UnstableCreateDashboardPlacementRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?(UnstableCreateDashboardPlacementRequest @this) => @this.UnstableCreateDashboardPlacementRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? value)
        {
            UnstableCreateDashboardPlacementRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateDashboardPlacementRequest FromUnstableCreateDashboardPlacementRequestVariant2(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? value) => new UnstableCreateDashboardPlacementRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>? unstableCreateDashboardPlacementRequestVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>? unstableCreateDashboardPlacementRequestVariant2
            )
        {
            UnstableCreateDashboardPlacementRequestVariant1 = unstableCreateDashboardPlacementRequestVariant1;
            UnstableCreateDashboardPlacementRequestVariant2 = unstableCreateDashboardPlacementRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableCreateDashboardPlacementRequestVariant2 as object ??
            UnstableCreateDashboardPlacementRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableCreateDashboardPlacementRequestVariant1?.ToString() ??
            UnstableCreateDashboardPlacementRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableCreateDashboardPlacementRequestVariant1 && !IsUnstableCreateDashboardPlacementRequestVariant2 || !IsUnstableCreateDashboardPlacementRequestVariant1 && IsUnstableCreateDashboardPlacementRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?, TResult>? unstableCreateDashboardPlacementRequestVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?, TResult>? unstableCreateDashboardPlacementRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateDashboardPlacementRequestVariant1 && unstableCreateDashboardPlacementRequestVariant1 != null)
            {
                return unstableCreateDashboardPlacementRequestVariant1(UnstableCreateDashboardPlacementRequestVariant1!);
            }
            else if (IsUnstableCreateDashboardPlacementRequestVariant2 && unstableCreateDashboardPlacementRequestVariant2 != null)
            {
                return unstableCreateDashboardPlacementRequestVariant2(UnstableCreateDashboardPlacementRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?>? unstableCreateDashboardPlacementRequestVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?>? unstableCreateDashboardPlacementRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateDashboardPlacementRequestVariant1)
            {
                unstableCreateDashboardPlacementRequestVariant1?.Invoke(UnstableCreateDashboardPlacementRequestVariant1!);
            }
            else if (IsUnstableCreateDashboardPlacementRequestVariant2)
            {
                unstableCreateDashboardPlacementRequestVariant2?.Invoke(UnstableCreateDashboardPlacementRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?>? unstableCreateDashboardPlacementRequestVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?>? unstableCreateDashboardPlacementRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateDashboardPlacementRequestVariant1)
            {
                unstableCreateDashboardPlacementRequestVariant1?.Invoke(UnstableCreateDashboardPlacementRequestVariant1!);
            }
            else if (IsUnstableCreateDashboardPlacementRequestVariant2)
            {
                unstableCreateDashboardPlacementRequestVariant2?.Invoke(UnstableCreateDashboardPlacementRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableCreateDashboardPlacementRequestVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>),
                UnstableCreateDashboardPlacementRequestVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>),
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
        public bool Equals(UnstableCreateDashboardPlacementRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant12, global::Langfuse.UnstableCreateWidgetPlacement>?>.Default.Equals(UnstableCreateDashboardPlacementRequestVariant1, other.UnstableCreateDashboardPlacementRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestVariant22, global::Langfuse.UnstableCreatePresetPlacement>?>.Default.Equals(UnstableCreateDashboardPlacementRequestVariant2, other.UnstableCreateDashboardPlacementRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnstableCreateDashboardPlacementRequest obj1, UnstableCreateDashboardPlacementRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableCreateDashboardPlacementRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnstableCreateDashboardPlacementRequest obj1, UnstableCreateDashboardPlacementRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableCreateDashboardPlacementRequest o && Equals(o);
        }
    }
}
