#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LegacyGetScoresResponseData : global::System.IEquatable<LegacyGetScoresResponseData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? LegacyGetScoresResponseDataVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? LegacyGetScoresResponseDataVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyGetScoresResponseDataVariant1))]
#endif
        public bool IsLegacyGetScoresResponseDataVariant1 => LegacyGetScoresResponseDataVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyGetScoresResponseDataVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? value)
        {
            value = LegacyGetScoresResponseDataVariant1;
            return IsLegacyGetScoresResponseDataVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric> PickLegacyGetScoresResponseDataVariant1() => IsLegacyGetScoresResponseDataVariant1
            ? LegacyGetScoresResponseDataVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyGetScoresResponseDataVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? LegacyGetScoresResponseDataVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? LegacyGetScoresResponseDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyGetScoresResponseDataVariant2))]
#endif
        public bool IsLegacyGetScoresResponseDataVariant2 => LegacyGetScoresResponseDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyGetScoresResponseDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? value)
        {
            value = LegacyGetScoresResponseDataVariant2;
            return IsLegacyGetScoresResponseDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical> PickLegacyGetScoresResponseDataVariant2() => IsLegacyGetScoresResponseDataVariant2
            ? LegacyGetScoresResponseDataVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyGetScoresResponseDataVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? LegacyGetScoresResponseDataVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? LegacyGetScoresResponseDataVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyGetScoresResponseDataVariant3))]
#endif
        public bool IsLegacyGetScoresResponseDataVariant3 => LegacyGetScoresResponseDataVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyGetScoresResponseDataVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? value)
        {
            value = LegacyGetScoresResponseDataVariant3;
            return IsLegacyGetScoresResponseDataVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean> PickLegacyGetScoresResponseDataVariant3() => IsLegacyGetScoresResponseDataVariant3
            ? LegacyGetScoresResponseDataVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyGetScoresResponseDataVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? LegacyGetScoresResponseDataVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? LegacyGetScoresResponseDataVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyGetScoresResponseDataVariant4))]
#endif
        public bool IsLegacyGetScoresResponseDataVariant4 => LegacyGetScoresResponseDataVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyGetScoresResponseDataVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? value)
        {
            value = LegacyGetScoresResponseDataVariant4;
            return IsLegacyGetScoresResponseDataVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection> PickLegacyGetScoresResponseDataVariant4() => IsLegacyGetScoresResponseDataVariant4
            ? LegacyGetScoresResponseDataVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyGetScoresResponseDataVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? LegacyGetScoresResponseDataVariant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? LegacyGetScoresResponseDataVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyGetScoresResponseDataVariant5))]
#endif
        public bool IsLegacyGetScoresResponseDataVariant5 => LegacyGetScoresResponseDataVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyGetScoresResponseDataVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? value)
        {
            value = LegacyGetScoresResponseDataVariant5;
            return IsLegacyGetScoresResponseDataVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText> PickLegacyGetScoresResponseDataVariant5() => IsLegacyGetScoresResponseDataVariant5
            ? LegacyGetScoresResponseDataVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyGetScoresResponseDataVariant5' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric> value) => new LegacyGetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?(LegacyGetScoresResponseData @this) => @this.LegacyGetScoresResponseDataVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? value)
        {
            LegacyGetScoresResponseDataVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyGetScoresResponseData FromLegacyGetScoresResponseDataVariant1(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? value) => new LegacyGetScoresResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical> value) => new LegacyGetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?(LegacyGetScoresResponseData @this) => @this.LegacyGetScoresResponseDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? value)
        {
            LegacyGetScoresResponseDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyGetScoresResponseData FromLegacyGetScoresResponseDataVariant2(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? value) => new LegacyGetScoresResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean> value) => new LegacyGetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?(LegacyGetScoresResponseData @this) => @this.LegacyGetScoresResponseDataVariant3;

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? value)
        {
            LegacyGetScoresResponseDataVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyGetScoresResponseData FromLegacyGetScoresResponseDataVariant3(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? value) => new LegacyGetScoresResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection> value) => new LegacyGetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?(LegacyGetScoresResponseData @this) => @this.LegacyGetScoresResponseDataVariant4;

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? value)
        {
            LegacyGetScoresResponseDataVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyGetScoresResponseData FromLegacyGetScoresResponseDataVariant4(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? value) => new LegacyGetScoresResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText> value) => new LegacyGetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?(LegacyGetScoresResponseData @this) => @this.LegacyGetScoresResponseDataVariant5;

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? value)
        {
            LegacyGetScoresResponseDataVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyGetScoresResponseData FromLegacyGetScoresResponseDataVariant5(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? value) => new LegacyGetScoresResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public LegacyGetScoresResponseData(
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>? legacyGetScoresResponseDataVariant1,
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>? legacyGetScoresResponseDataVariant2,
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>? legacyGetScoresResponseDataVariant3,
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>? legacyGetScoresResponseDataVariant4,
            global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>? legacyGetScoresResponseDataVariant5
            )
        {
            LegacyGetScoresResponseDataVariant1 = legacyGetScoresResponseDataVariant1;
            LegacyGetScoresResponseDataVariant2 = legacyGetScoresResponseDataVariant2;
            LegacyGetScoresResponseDataVariant3 = legacyGetScoresResponseDataVariant3;
            LegacyGetScoresResponseDataVariant4 = legacyGetScoresResponseDataVariant4;
            LegacyGetScoresResponseDataVariant5 = legacyGetScoresResponseDataVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LegacyGetScoresResponseDataVariant5 as object ??
            LegacyGetScoresResponseDataVariant4 as object ??
            LegacyGetScoresResponseDataVariant3 as object ??
            LegacyGetScoresResponseDataVariant2 as object ??
            LegacyGetScoresResponseDataVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LegacyGetScoresResponseDataVariant1?.ToString() ??
            LegacyGetScoresResponseDataVariant2?.ToString() ??
            LegacyGetScoresResponseDataVariant3?.ToString() ??
            LegacyGetScoresResponseDataVariant4?.ToString() ??
            LegacyGetScoresResponseDataVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLegacyGetScoresResponseDataVariant1 && !IsLegacyGetScoresResponseDataVariant2 && !IsLegacyGetScoresResponseDataVariant3 && !IsLegacyGetScoresResponseDataVariant4 && !IsLegacyGetScoresResponseDataVariant5 || !IsLegacyGetScoresResponseDataVariant1 && IsLegacyGetScoresResponseDataVariant2 && !IsLegacyGetScoresResponseDataVariant3 && !IsLegacyGetScoresResponseDataVariant4 && !IsLegacyGetScoresResponseDataVariant5 || !IsLegacyGetScoresResponseDataVariant1 && !IsLegacyGetScoresResponseDataVariant2 && IsLegacyGetScoresResponseDataVariant3 && !IsLegacyGetScoresResponseDataVariant4 && !IsLegacyGetScoresResponseDataVariant5 || !IsLegacyGetScoresResponseDataVariant1 && !IsLegacyGetScoresResponseDataVariant2 && !IsLegacyGetScoresResponseDataVariant3 && IsLegacyGetScoresResponseDataVariant4 && !IsLegacyGetScoresResponseDataVariant5 || !IsLegacyGetScoresResponseDataVariant1 && !IsLegacyGetScoresResponseDataVariant2 && !IsLegacyGetScoresResponseDataVariant3 && !IsLegacyGetScoresResponseDataVariant4 && IsLegacyGetScoresResponseDataVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?, TResult>? legacyGetScoresResponseDataVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?, TResult>? legacyGetScoresResponseDataVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?, TResult>? legacyGetScoresResponseDataVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?, TResult>? legacyGetScoresResponseDataVariant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?, TResult>? legacyGetScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLegacyGetScoresResponseDataVariant1 && legacyGetScoresResponseDataVariant1 != null)
            {
                return legacyGetScoresResponseDataVariant1(LegacyGetScoresResponseDataVariant1!);
            }
            else if (IsLegacyGetScoresResponseDataVariant2 && legacyGetScoresResponseDataVariant2 != null)
            {
                return legacyGetScoresResponseDataVariant2(LegacyGetScoresResponseDataVariant2!);
            }
            else if (IsLegacyGetScoresResponseDataVariant3 && legacyGetScoresResponseDataVariant3 != null)
            {
                return legacyGetScoresResponseDataVariant3(LegacyGetScoresResponseDataVariant3!);
            }
            else if (IsLegacyGetScoresResponseDataVariant4 && legacyGetScoresResponseDataVariant4 != null)
            {
                return legacyGetScoresResponseDataVariant4(LegacyGetScoresResponseDataVariant4!);
            }
            else if (IsLegacyGetScoresResponseDataVariant5 && legacyGetScoresResponseDataVariant5 != null)
            {
                return legacyGetScoresResponseDataVariant5(LegacyGetScoresResponseDataVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?>? legacyGetScoresResponseDataVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?>? legacyGetScoresResponseDataVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?>? legacyGetScoresResponseDataVariant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?>? legacyGetScoresResponseDataVariant4 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?>? legacyGetScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLegacyGetScoresResponseDataVariant1)
            {
                legacyGetScoresResponseDataVariant1?.Invoke(LegacyGetScoresResponseDataVariant1!);
            }
            else if (IsLegacyGetScoresResponseDataVariant2)
            {
                legacyGetScoresResponseDataVariant2?.Invoke(LegacyGetScoresResponseDataVariant2!);
            }
            else if (IsLegacyGetScoresResponseDataVariant3)
            {
                legacyGetScoresResponseDataVariant3?.Invoke(LegacyGetScoresResponseDataVariant3!);
            }
            else if (IsLegacyGetScoresResponseDataVariant4)
            {
                legacyGetScoresResponseDataVariant4?.Invoke(LegacyGetScoresResponseDataVariant4!);
            }
            else if (IsLegacyGetScoresResponseDataVariant5)
            {
                legacyGetScoresResponseDataVariant5?.Invoke(LegacyGetScoresResponseDataVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?>? legacyGetScoresResponseDataVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?>? legacyGetScoresResponseDataVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?>? legacyGetScoresResponseDataVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?>? legacyGetScoresResponseDataVariant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?>? legacyGetScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLegacyGetScoresResponseDataVariant1)
            {
                legacyGetScoresResponseDataVariant1?.Invoke(LegacyGetScoresResponseDataVariant1!);
            }
            else if (IsLegacyGetScoresResponseDataVariant2)
            {
                legacyGetScoresResponseDataVariant2?.Invoke(LegacyGetScoresResponseDataVariant2!);
            }
            else if (IsLegacyGetScoresResponseDataVariant3)
            {
                legacyGetScoresResponseDataVariant3?.Invoke(LegacyGetScoresResponseDataVariant3!);
            }
            else if (IsLegacyGetScoresResponseDataVariant4)
            {
                legacyGetScoresResponseDataVariant4?.Invoke(LegacyGetScoresResponseDataVariant4!);
            }
            else if (IsLegacyGetScoresResponseDataVariant5)
            {
                legacyGetScoresResponseDataVariant5?.Invoke(LegacyGetScoresResponseDataVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LegacyGetScoresResponseDataVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>),
                LegacyGetScoresResponseDataVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>),
                LegacyGetScoresResponseDataVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>),
                LegacyGetScoresResponseDataVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>),
                LegacyGetScoresResponseDataVariant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>),
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
        public bool Equals(LegacyGetScoresResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant12, global::Langfuse.LegacyGetScoresResponseDataNumeric>?>.Default.Equals(LegacyGetScoresResponseDataVariant1, other.LegacyGetScoresResponseDataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant22, global::Langfuse.LegacyGetScoresResponseDataCategorical>?>.Default.Equals(LegacyGetScoresResponseDataVariant2, other.LegacyGetScoresResponseDataVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant32, global::Langfuse.LegacyGetScoresResponseDataBoolean>?>.Default.Equals(LegacyGetScoresResponseDataVariant3, other.LegacyGetScoresResponseDataVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant42, global::Langfuse.LegacyGetScoresResponseDataCorrection>?>.Default.Equals(LegacyGetScoresResponseDataVariant4, other.LegacyGetScoresResponseDataVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.LegacyGetScoresResponseDataVariant52, global::Langfuse.LegacyGetScoresResponseDataText>?>.Default.Equals(LegacyGetScoresResponseDataVariant5, other.LegacyGetScoresResponseDataVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LegacyGetScoresResponseData obj1, LegacyGetScoresResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LegacyGetScoresResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LegacyGetScoresResponseData obj1, LegacyGetScoresResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LegacyGetScoresResponseData o && Equals(o);
        }
    }
}
