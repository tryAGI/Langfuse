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
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? UnstableCreateWidgetPlacement { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? UnstableCreateWidgetPlacement { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateWidgetPlacement))]
#endif
        public bool IsUnstableCreateWidgetPlacement => UnstableCreateWidgetPlacement != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCreateWidgetPlacement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? value)
        {
            value = UnstableCreateWidgetPlacement;
            return IsUnstableCreateWidgetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement> PickUnstableCreateWidgetPlacement() => IsUnstableCreateWidgetPlacement
            ? UnstableCreateWidgetPlacement!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateWidgetPlacement' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? UnstableCreatePresetPlacement { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? UnstableCreatePresetPlacement { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreatePresetPlacement))]
#endif
        public bool IsUnstableCreatePresetPlacement => UnstableCreatePresetPlacement != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCreatePresetPlacement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? value)
        {
            value = UnstableCreatePresetPlacement;
            return IsUnstableCreatePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement> PickUnstableCreatePresetPlacement() => IsUnstableCreatePresetPlacement
            ? UnstableCreatePresetPlacement!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreatePresetPlacement' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement> value) => new UnstableCreateDashboardPlacementRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?(UnstableCreateDashboardPlacementRequest @this) => @this.UnstableCreateWidgetPlacement;

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? value)
        {
            UnstableCreateWidgetPlacement = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableCreateDashboardPlacementRequest FromUnstableCreateWidgetPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? value) => new UnstableCreateDashboardPlacementRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement> value) => new UnstableCreateDashboardPlacementRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?(UnstableCreateDashboardPlacementRequest @this) => @this.UnstableCreatePresetPlacement;

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? value)
        {
            UnstableCreatePresetPlacement = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableCreateDashboardPlacementRequest FromUnstableCreatePresetPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? value) => new UnstableCreateDashboardPlacementRequest(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateDashboardPlacementRequest(
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>? unstableCreateWidgetPlacement,
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>? unstableCreatePresetPlacement
            )
        {
            UnstableCreateWidgetPlacement = unstableCreateWidgetPlacement;
            UnstableCreatePresetPlacement = unstableCreatePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableCreatePresetPlacement as object ??
            UnstableCreateWidgetPlacement as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableCreateWidgetPlacement?.ToString() ??
            UnstableCreatePresetPlacement?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableCreateWidgetPlacement && !IsUnstableCreatePresetPlacement || !IsUnstableCreateWidgetPlacement && IsUnstableCreatePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?, TResult>? unstableCreateWidgetPlacement = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?, TResult>? unstableCreatePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateWidgetPlacement && unstableCreateWidgetPlacement != null)
            {
                return unstableCreateWidgetPlacement(UnstableCreateWidgetPlacement!);
            }
            else if (IsUnstableCreatePresetPlacement && unstableCreatePresetPlacement != null)
            {
                return unstableCreatePresetPlacement(UnstableCreatePresetPlacement!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?>? unstableCreateWidgetPlacement = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?>? unstableCreatePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateWidgetPlacement)
            {
                unstableCreateWidgetPlacement?.Invoke(UnstableCreateWidgetPlacement!);
            }
            else if (IsUnstableCreatePresetPlacement)
            {
                unstableCreatePresetPlacement?.Invoke(UnstableCreatePresetPlacement!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?>? unstableCreateWidgetPlacement = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?>? unstableCreatePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateWidgetPlacement)
            {
                unstableCreateWidgetPlacement?.Invoke(UnstableCreateWidgetPlacement!);
            }
            else if (IsUnstableCreatePresetPlacement)
            {
                unstableCreatePresetPlacement?.Invoke(UnstableCreatePresetPlacement!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableCreateWidgetPlacement,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>),
                UnstableCreatePresetPlacement,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?>.Default.Equals(UnstableCreateWidgetPlacement, other.UnstableCreateWidgetPlacement) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?>.Default.Equals(UnstableCreatePresetPlacement, other.UnstableCreatePresetPlacement)
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
