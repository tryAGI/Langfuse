#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScoreV3 : global::System.IEquatable<ScoreV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? NumericScoreV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? NumericScoreV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericScoreV3))]
#endif
        public bool IsNumericScoreV3 => NumericScoreV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumericScoreV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? value)
        {
            value = NumericScoreV3;
            return IsNumericScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3> PickNumericScoreV3() => IsNumericScoreV3
            ? NumericScoreV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumericScoreV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? BooleanScoreV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? BooleanScoreV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanScoreV3))]
#endif
        public bool IsBooleanScoreV3 => BooleanScoreV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBooleanScoreV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? value)
        {
            value = BooleanScoreV3;
            return IsBooleanScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3> PickBooleanScoreV3() => IsBooleanScoreV3
            ? BooleanScoreV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BooleanScoreV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? CategoricalScoreV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? CategoricalScoreV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CategoricalScoreV3))]
#endif
        public bool IsCategoricalScoreV3 => CategoricalScoreV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCategoricalScoreV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? value)
        {
            value = CategoricalScoreV3;
            return IsCategoricalScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3> PickCategoricalScoreV3() => IsCategoricalScoreV3
            ? CategoricalScoreV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CategoricalScoreV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? TextScoreV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? TextScoreV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextScoreV3))]
#endif
        public bool IsTextScoreV3 => TextScoreV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextScoreV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? value)
        {
            value = TextScoreV3;
            return IsTextScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3> PickTextScoreV3() => IsTextScoreV3
            ? TextScoreV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextScoreV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? CorrectionScoreV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? CorrectionScoreV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorrectionScoreV3))]
#endif
        public bool IsCorrectionScoreV3 => CorrectionScoreV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCorrectionScoreV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? value)
        {
            value = CorrectionScoreV3;
            return IsCorrectionScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3> PickCorrectionScoreV3() => IsCorrectionScoreV3
            ? CorrectionScoreV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CorrectionScoreV3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?(ScoreV3 @this) => @this.NumericScoreV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? value)
        {
            NumericScoreV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromNumericScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?(ScoreV3 @this) => @this.BooleanScoreV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? value)
        {
            BooleanScoreV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromBooleanScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?(ScoreV3 @this) => @this.CategoricalScoreV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? value)
        {
            CategoricalScoreV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromCategoricalScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?(ScoreV3 @this) => @this.TextScoreV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? value)
        {
            TextScoreV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromTextScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?(ScoreV3 @this) => @this.CorrectionScoreV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? value)
        {
            CorrectionScoreV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromCorrectionScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(
            global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>? numericScoreV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>? booleanScoreV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>? categoricalScoreV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>? textScoreV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>? correctionScoreV3
            )
        {
            NumericScoreV3 = numericScoreV3;
            BooleanScoreV3 = booleanScoreV3;
            CategoricalScoreV3 = categoricalScoreV3;
            TextScoreV3 = textScoreV3;
            CorrectionScoreV3 = correctionScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CorrectionScoreV3 as object ??
            TextScoreV3 as object ??
            CategoricalScoreV3 as object ??
            BooleanScoreV3 as object ??
            NumericScoreV3 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NumericScoreV3?.ToString() ??
            BooleanScoreV3?.ToString() ??
            CategoricalScoreV3?.ToString() ??
            TextScoreV3?.ToString() ??
            CorrectionScoreV3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNumericScoreV3 && !IsBooleanScoreV3 && !IsCategoricalScoreV3 && !IsTextScoreV3 && !IsCorrectionScoreV3 || !IsNumericScoreV3 && IsBooleanScoreV3 && !IsCategoricalScoreV3 && !IsTextScoreV3 && !IsCorrectionScoreV3 || !IsNumericScoreV3 && !IsBooleanScoreV3 && IsCategoricalScoreV3 && !IsTextScoreV3 && !IsCorrectionScoreV3 || !IsNumericScoreV3 && !IsBooleanScoreV3 && !IsCategoricalScoreV3 && IsTextScoreV3 && !IsCorrectionScoreV3 || !IsNumericScoreV3 && !IsBooleanScoreV3 && !IsCategoricalScoreV3 && !IsTextScoreV3 && IsCorrectionScoreV3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?, TResult>? numericScoreV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?, TResult>? booleanScoreV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?, TResult>? categoricalScoreV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?, TResult>? textScoreV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?, TResult>? correctionScoreV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV3 && numericScoreV3 != null)
            {
                return numericScoreV3(NumericScoreV3!);
            }
            else if (IsBooleanScoreV3 && booleanScoreV3 != null)
            {
                return booleanScoreV3(BooleanScoreV3!);
            }
            else if (IsCategoricalScoreV3 && categoricalScoreV3 != null)
            {
                return categoricalScoreV3(CategoricalScoreV3!);
            }
            else if (IsTextScoreV3 && textScoreV3 != null)
            {
                return textScoreV3(TextScoreV3!);
            }
            else if (IsCorrectionScoreV3 && correctionScoreV3 != null)
            {
                return correctionScoreV3(CorrectionScoreV3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?>? numericScoreV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?>? booleanScoreV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?>? categoricalScoreV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?>? textScoreV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?>? correctionScoreV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV3)
            {
                numericScoreV3?.Invoke(NumericScoreV3!);
            }
            else if (IsBooleanScoreV3)
            {
                booleanScoreV3?.Invoke(BooleanScoreV3!);
            }
            else if (IsCategoricalScoreV3)
            {
                categoricalScoreV3?.Invoke(CategoricalScoreV3!);
            }
            else if (IsTextScoreV3)
            {
                textScoreV3?.Invoke(TextScoreV3!);
            }
            else if (IsCorrectionScoreV3)
            {
                correctionScoreV3?.Invoke(CorrectionScoreV3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?>? numericScoreV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?>? booleanScoreV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?>? categoricalScoreV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?>? textScoreV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?>? correctionScoreV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericScoreV3)
            {
                numericScoreV3?.Invoke(NumericScoreV3!);
            }
            else if (IsBooleanScoreV3)
            {
                booleanScoreV3?.Invoke(BooleanScoreV3!);
            }
            else if (IsCategoricalScoreV3)
            {
                categoricalScoreV3?.Invoke(CategoricalScoreV3!);
            }
            else if (IsTextScoreV3)
            {
                textScoreV3?.Invoke(TextScoreV3!);
            }
            else if (IsCorrectionScoreV3)
            {
                correctionScoreV3?.Invoke(CorrectionScoreV3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NumericScoreV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>),
                BooleanScoreV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>),
                CategoricalScoreV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>),
                TextScoreV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>),
                CorrectionScoreV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>),
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
        public bool Equals(ScoreV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3NumericScoreV32, global::Langfuse.NumericScoreV3>?>.Default.Equals(NumericScoreV3, other.NumericScoreV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3BooleanScoreV32, global::Langfuse.BooleanScoreV3>?>.Default.Equals(BooleanScoreV3, other.BooleanScoreV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3CategoricalScoreV32, global::Langfuse.CategoricalScoreV3>?>.Default.Equals(CategoricalScoreV3, other.CategoricalScoreV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3TextScoreV32, global::Langfuse.TextScoreV3>?>.Default.Equals(TextScoreV3, other.TextScoreV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3CorrectionScoreV32, global::Langfuse.CorrectionScoreV3>?>.Default.Equals(CorrectionScoreV3, other.CorrectionScoreV3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScoreV3 obj1, ScoreV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScoreV3 obj1, ScoreV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreV3 o && Equals(o);
        }
    }
}
