#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScoreV1 : global::System.IEquatable<ScoreV1>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? NumericScoreV1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? NumericScoreV1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericScoreV1))]
#endif
        public bool IsNumericScoreV1 => NumericScoreV1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumericScoreV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? value)
        {
            value = NumericScoreV1;
            return IsNumericScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1> PickNumericScoreV1() => IsNumericScoreV1
            ? NumericScoreV1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumericScoreV1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? CategoricalScoreV1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? CategoricalScoreV1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CategoricalScoreV1))]
#endif
        public bool IsCategoricalScoreV1 => CategoricalScoreV1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCategoricalScoreV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? value)
        {
            value = CategoricalScoreV1;
            return IsCategoricalScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1> PickCategoricalScoreV1() => IsCategoricalScoreV1
            ? CategoricalScoreV1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CategoricalScoreV1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? BooleanScoreV1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? BooleanScoreV1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanScoreV1))]
#endif
        public bool IsBooleanScoreV1 => BooleanScoreV1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBooleanScoreV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? value)
        {
            value = BooleanScoreV1;
            return IsBooleanScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1> PickBooleanScoreV1() => IsBooleanScoreV1
            ? BooleanScoreV1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BooleanScoreV1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? TextScoreV1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? TextScoreV1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextScoreV1))]
#endif
        public bool IsTextScoreV1 => TextScoreV1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextScoreV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? value)
        {
            value = TextScoreV1;
            return IsTextScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1> PickTextScoreV1() => IsTextScoreV1
            ? TextScoreV1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextScoreV1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1> value) => new ScoreV1((global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?(ScoreV1 @this) => @this.NumericScoreV1;

        /// <summary>
        ///
        /// </summary>
        public ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? value)
        {
            NumericScoreV1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV1 FromNumericScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? value) => new ScoreV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1> value) => new ScoreV1((global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?(ScoreV1 @this) => @this.CategoricalScoreV1;

        /// <summary>
        ///
        /// </summary>
        public ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? value)
        {
            CategoricalScoreV1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV1 FromCategoricalScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? value) => new ScoreV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1> value) => new ScoreV1((global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?(ScoreV1 @this) => @this.BooleanScoreV1;

        /// <summary>
        ///
        /// </summary>
        public ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? value)
        {
            BooleanScoreV1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV1 FromBooleanScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? value) => new ScoreV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1> value) => new ScoreV1((global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?(ScoreV1 @this) => @this.TextScoreV1;

        /// <summary>
        ///
        /// </summary>
        public ScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? value)
        {
            TextScoreV1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV1 FromTextScoreV1(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? value) => new ScoreV1(value);

        /// <summary>
        ///
        /// </summary>
        public ScoreV1(
            global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>? numericScoreV1,
            global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>? categoricalScoreV1,
            global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>? booleanScoreV1,
            global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>? textScoreV1
            )
        {
            NumericScoreV1 = numericScoreV1;
            CategoricalScoreV1 = categoricalScoreV1;
            BooleanScoreV1 = booleanScoreV1;
            TextScoreV1 = textScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextScoreV1 as object ??
            BooleanScoreV1 as object ??
            CategoricalScoreV1 as object ??
            NumericScoreV1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NumericScoreV1?.ToString() ??
            CategoricalScoreV1?.ToString() ??
            BooleanScoreV1?.ToString() ??
            TextScoreV1?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNumericScoreV1 && !IsCategoricalScoreV1 && !IsBooleanScoreV1 && !IsTextScoreV1 || !IsNumericScoreV1 && IsCategoricalScoreV1 && !IsBooleanScoreV1 && !IsTextScoreV1 || !IsNumericScoreV1 && !IsCategoricalScoreV1 && IsBooleanScoreV1 && !IsTextScoreV1 || !IsNumericScoreV1 && !IsCategoricalScoreV1 && !IsBooleanScoreV1 && IsTextScoreV1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?, TResult>? numericScoreV1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?, TResult>? categoricalScoreV1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?, TResult>? booleanScoreV1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?, TResult>? textScoreV1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV1 && numericScoreV1 != null)
            {
                return numericScoreV1(NumericScoreV1!);
            }
            else if (IsCategoricalScoreV1 && categoricalScoreV1 != null)
            {
                return categoricalScoreV1(CategoricalScoreV1!);
            }
            else if (IsBooleanScoreV1 && booleanScoreV1 != null)
            {
                return booleanScoreV1(BooleanScoreV1!);
            }
            else if (IsTextScoreV1 && textScoreV1 != null)
            {
                return textScoreV1(TextScoreV1!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?>? numericScoreV1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?>? categoricalScoreV1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?>? booleanScoreV1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?>? textScoreV1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV1)
            {
                numericScoreV1?.Invoke(NumericScoreV1!);
            }
            else if (IsCategoricalScoreV1)
            {
                categoricalScoreV1?.Invoke(CategoricalScoreV1!);
            }
            else if (IsBooleanScoreV1)
            {
                booleanScoreV1?.Invoke(BooleanScoreV1!);
            }
            else if (IsTextScoreV1)
            {
                textScoreV1?.Invoke(TextScoreV1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?>? numericScoreV1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?>? categoricalScoreV1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?>? booleanScoreV1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?>? textScoreV1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV1)
            {
                numericScoreV1?.Invoke(NumericScoreV1!);
            }
            else if (IsCategoricalScoreV1)
            {
                categoricalScoreV1?.Invoke(CategoricalScoreV1!);
            }
            else if (IsBooleanScoreV1)
            {
                booleanScoreV1?.Invoke(BooleanScoreV1!);
            }
            else if (IsTextScoreV1)
            {
                textScoreV1?.Invoke(TextScoreV1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NumericScoreV1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>),
                CategoricalScoreV1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>),
                BooleanScoreV1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>),
                TextScoreV1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>),
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
        public bool Equals(ScoreV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV1NumericScoreV12, global::Langfuse.NumericScoreV1>?>.Default.Equals(NumericScoreV1, other.NumericScoreV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV1CategoricalScoreV12, global::Langfuse.CategoricalScoreV1>?>.Default.Equals(CategoricalScoreV1, other.CategoricalScoreV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV1BooleanScoreV12, global::Langfuse.BooleanScoreV1>?>.Default.Equals(BooleanScoreV1, other.BooleanScoreV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV1TextScoreV12, global::Langfuse.TextScoreV1>?>.Default.Equals(TextScoreV1, other.TextScoreV1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScoreV1 obj1, ScoreV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScoreV1 obj1, ScoreV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreV1 o && Equals(o);
        }
    }
}
