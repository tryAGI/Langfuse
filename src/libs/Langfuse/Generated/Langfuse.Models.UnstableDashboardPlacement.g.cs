#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// A tile on the dashboard's 12-column grid. `x`/`y` are the tile's<br/>
    /// top-left cell (0-based; `y` grows downward), `width`/`height` its size<br/>
    /// in cells. The UI default tile is 6x6 (half width). Overlapping tiles<br/>
    /// are not rejected; prefer appending below existing tiles (or omit the<br/>
    /// position on create to let the server do it).
    /// </summary>
    public readonly partial struct UnstableDashboardPlacement : global::System.IEquatable<UnstableDashboardPlacement>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? UnstableWidgetPlacement { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? UnstableWidgetPlacement { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableWidgetPlacement))]
#endif
        public bool IsUnstableWidgetPlacement => UnstableWidgetPlacement != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableWidgetPlacement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? value)
        {
            value = UnstableWidgetPlacement;
            return IsUnstableWidgetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement> PickUnstableWidgetPlacement() => IsUnstableWidgetPlacement
            ? UnstableWidgetPlacement!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableWidgetPlacement' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? UnstablePresetPlacement { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? UnstablePresetPlacement { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstablePresetPlacement))]
#endif
        public bool IsUnstablePresetPlacement => UnstablePresetPlacement != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstablePresetPlacement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? value)
        {
            value = UnstablePresetPlacement;
            return IsUnstablePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement> PickUnstablePresetPlacement() => IsUnstablePresetPlacement
            ? UnstablePresetPlacement!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstablePresetPlacement' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement> value) => new UnstableDashboardPlacement((global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?(UnstableDashboardPlacement @this) => @this.UnstableWidgetPlacement;

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? value)
        {
            UnstableWidgetPlacement = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardPlacement FromUnstableWidgetPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? value) => new UnstableDashboardPlacement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement> value) => new UnstableDashboardPlacement((global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?(UnstableDashboardPlacement @this) => @this.UnstablePresetPlacement;

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? value)
        {
            UnstablePresetPlacement = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardPlacement FromUnstablePresetPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? value) => new UnstableDashboardPlacement(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(
            global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>? unstableWidgetPlacement,
            global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>? unstablePresetPlacement
            )
        {
            UnstableWidgetPlacement = unstableWidgetPlacement;
            UnstablePresetPlacement = unstablePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstablePresetPlacement as object ??
            UnstableWidgetPlacement as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableWidgetPlacement?.ToString() ??
            UnstablePresetPlacement?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableWidgetPlacement && !IsUnstablePresetPlacement || !IsUnstableWidgetPlacement && IsUnstablePresetPlacement;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?, TResult>? unstableWidgetPlacement = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?, TResult>? unstablePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableWidgetPlacement && unstableWidgetPlacement != null)
            {
                return unstableWidgetPlacement(UnstableWidgetPlacement!);
            }
            else if (IsUnstablePresetPlacement && unstablePresetPlacement != null)
            {
                return unstablePresetPlacement(UnstablePresetPlacement!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?>? unstableWidgetPlacement = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?>? unstablePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableWidgetPlacement)
            {
                unstableWidgetPlacement?.Invoke(UnstableWidgetPlacement!);
            }
            else if (IsUnstablePresetPlacement)
            {
                unstablePresetPlacement?.Invoke(UnstablePresetPlacement!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?>? unstableWidgetPlacement = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?>? unstablePresetPlacement = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableWidgetPlacement)
            {
                unstableWidgetPlacement?.Invoke(UnstableWidgetPlacement!);
            }
            else if (IsUnstablePresetPlacement)
            {
                unstablePresetPlacement?.Invoke(UnstablePresetPlacement!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableWidgetPlacement,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>),
                UnstablePresetPlacement,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>),
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
        public bool Equals(UnstableDashboardPlacement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?>.Default.Equals(UnstableWidgetPlacement, other.UnstableWidgetPlacement) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?>.Default.Equals(UnstablePresetPlacement, other.UnstablePresetPlacement)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstableDashboardPlacement obj1, UnstableDashboardPlacement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableDashboardPlacement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstableDashboardPlacement obj1, UnstableDashboardPlacement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableDashboardPlacement o && Equals(o);
        }
    }
}
