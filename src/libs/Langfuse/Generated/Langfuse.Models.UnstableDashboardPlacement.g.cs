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
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? UnstableDashboardPlacementVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? UnstableDashboardPlacementVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableDashboardPlacementVariant1))]
#endif
        public bool IsUnstableDashboardPlacementVariant1 => UnstableDashboardPlacementVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableDashboardPlacementVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? value)
        {
            value = UnstableDashboardPlacementVariant1;
            return IsUnstableDashboardPlacementVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement> PickUnstableDashboardPlacementVariant1() => IsUnstableDashboardPlacementVariant1
            ? UnstableDashboardPlacementVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableDashboardPlacementVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? UnstableDashboardPlacementVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? UnstableDashboardPlacementVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableDashboardPlacementVariant2))]
#endif
        public bool IsUnstableDashboardPlacementVariant2 => UnstableDashboardPlacementVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableDashboardPlacementVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? value)
        {
            value = UnstableDashboardPlacementVariant2;
            return IsUnstableDashboardPlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement> PickUnstableDashboardPlacementVariant2() => IsUnstableDashboardPlacementVariant2
            ? UnstableDashboardPlacementVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableDashboardPlacementVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement> value) => new UnstableDashboardPlacement((global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?(UnstableDashboardPlacement @this) => @this.UnstableDashboardPlacementVariant1;

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? value)
        {
            UnstableDashboardPlacementVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardPlacement FromUnstableDashboardPlacementVariant1(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? value) => new UnstableDashboardPlacement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement> value) => new UnstableDashboardPlacement((global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?(UnstableDashboardPlacement @this) => @this.UnstableDashboardPlacementVariant2;

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? value)
        {
            UnstableDashboardPlacementVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardPlacement FromUnstableDashboardPlacementVariant2(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? value) => new UnstableDashboardPlacement(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableDashboardPlacement(
            global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>? unstableDashboardPlacementVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>? unstableDashboardPlacementVariant2
            )
        {
            UnstableDashboardPlacementVariant1 = unstableDashboardPlacementVariant1;
            UnstableDashboardPlacementVariant2 = unstableDashboardPlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableDashboardPlacementVariant2 as object ??
            UnstableDashboardPlacementVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableDashboardPlacementVariant1?.ToString() ??
            UnstableDashboardPlacementVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableDashboardPlacementVariant1 && !IsUnstableDashboardPlacementVariant2 || !IsUnstableDashboardPlacementVariant1 && IsUnstableDashboardPlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?, TResult>? unstableDashboardPlacementVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?, TResult>? unstableDashboardPlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDashboardPlacementVariant1 && unstableDashboardPlacementVariant1 != null)
            {
                return unstableDashboardPlacementVariant1(UnstableDashboardPlacementVariant1!);
            }
            else if (IsUnstableDashboardPlacementVariant2 && unstableDashboardPlacementVariant2 != null)
            {
                return unstableDashboardPlacementVariant2(UnstableDashboardPlacementVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?>? unstableDashboardPlacementVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?>? unstableDashboardPlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDashboardPlacementVariant1)
            {
                unstableDashboardPlacementVariant1?.Invoke(UnstableDashboardPlacementVariant1!);
            }
            else if (IsUnstableDashboardPlacementVariant2)
            {
                unstableDashboardPlacementVariant2?.Invoke(UnstableDashboardPlacementVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?>? unstableDashboardPlacementVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?>? unstableDashboardPlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDashboardPlacementVariant1)
            {
                unstableDashboardPlacementVariant1?.Invoke(UnstableDashboardPlacementVariant1!);
            }
            else if (IsUnstableDashboardPlacementVariant2)
            {
                unstableDashboardPlacementVariant2?.Invoke(UnstableDashboardPlacementVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableDashboardPlacementVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>),
                UnstableDashboardPlacementVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant12, global::Langfuse.UnstableWidgetPlacement>?>.Default.Equals(UnstableDashboardPlacementVariant1, other.UnstableDashboardPlacementVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementVariant22, global::Langfuse.UnstablePresetPlacement>?>.Default.Equals(UnstableDashboardPlacementVariant2, other.UnstableDashboardPlacementVariant2)
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
