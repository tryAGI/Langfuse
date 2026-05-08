#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetScoresResponseData : global::System.IEquatable<GetScoresResponseData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? GetScoresResponseDataVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? GetScoresResponseDataVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant1))]
#endif
        public bool IsGetScoresResponseDataVariant1 => GetScoresResponseDataVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetScoresResponseDataVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? value)
        {
            value = GetScoresResponseDataVariant1;
            return IsGetScoresResponseDataVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? GetScoresResponseDataVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? GetScoresResponseDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant2))]
#endif
        public bool IsGetScoresResponseDataVariant2 => GetScoresResponseDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetScoresResponseDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? value)
        {
            value = GetScoresResponseDataVariant2;
            return IsGetScoresResponseDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? GetScoresResponseDataVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? GetScoresResponseDataVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant3))]
#endif
        public bool IsGetScoresResponseDataVariant3 => GetScoresResponseDataVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetScoresResponseDataVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? value)
        {
            value = GetScoresResponseDataVariant3;
            return IsGetScoresResponseDataVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? GetScoresResponseDataVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? GetScoresResponseDataVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant4))]
#endif
        public bool IsGetScoresResponseDataVariant4 => GetScoresResponseDataVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetScoresResponseDataVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? value)
        {
            value = GetScoresResponseDataVariant4;
            return IsGetScoresResponseDataVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? GetScoresResponseDataVariant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? GetScoresResponseDataVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataVariant5))]
#endif
        public bool IsGetScoresResponseDataVariant5 => GetScoresResponseDataVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetScoresResponseDataVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? value)
        {
            value = GetScoresResponseDataVariant5;
            return IsGetScoresResponseDataVariant5;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? value)
        {
            GetScoresResponseDataVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? value)
        {
            GetScoresResponseDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant3;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? value)
        {
            GetScoresResponseDataVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant4;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? value)
        {
            GetScoresResponseDataVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?(GetScoresResponseData @this) => @this.GetScoresResponseDataVariant5;

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? value)
        {
            GetScoresResponseDataVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetScoresResponseData(
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>? getScoresResponseDataVariant1,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>? getScoresResponseDataVariant2,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>? getScoresResponseDataVariant3,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>? getScoresResponseDataVariant4,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>? getScoresResponseDataVariant5
            )
        {
            GetScoresResponseDataVariant1 = getScoresResponseDataVariant1;
            GetScoresResponseDataVariant2 = getScoresResponseDataVariant2;
            GetScoresResponseDataVariant3 = getScoresResponseDataVariant3;
            GetScoresResponseDataVariant4 = getScoresResponseDataVariant4;
            GetScoresResponseDataVariant5 = getScoresResponseDataVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetScoresResponseDataVariant5 as object ??
            GetScoresResponseDataVariant4 as object ??
            GetScoresResponseDataVariant3 as object ??
            GetScoresResponseDataVariant2 as object ??
            GetScoresResponseDataVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GetScoresResponseDataVariant1?.ToString() ??
            GetScoresResponseDataVariant2?.ToString() ??
            GetScoresResponseDataVariant3?.ToString() ??
            GetScoresResponseDataVariant4?.ToString() ??
            GetScoresResponseDataVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 && !IsGetScoresResponseDataVariant5 || !IsGetScoresResponseDataVariant1 && IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 && !IsGetScoresResponseDataVariant5 || !IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 && !IsGetScoresResponseDataVariant5 || !IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && IsGetScoresResponseDataVariant4 && !IsGetScoresResponseDataVariant5 || !IsGetScoresResponseDataVariant1 && !IsGetScoresResponseDataVariant2 && !IsGetScoresResponseDataVariant3 && !IsGetScoresResponseDataVariant4 && IsGetScoresResponseDataVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?, TResult>? getScoresResponseDataVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?, TResult>? getScoresResponseDataVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?, TResult>? getScoresResponseDataVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?, TResult>? getScoresResponseDataVariant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?, TResult>? getScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataVariant1 && getScoresResponseDataVariant1 != null)
            {
                return getScoresResponseDataVariant1(GetScoresResponseDataVariant1!);
            }
            else if (IsGetScoresResponseDataVariant2 && getScoresResponseDataVariant2 != null)
            {
                return getScoresResponseDataVariant2(GetScoresResponseDataVariant2!);
            }
            else if (IsGetScoresResponseDataVariant3 && getScoresResponseDataVariant3 != null)
            {
                return getScoresResponseDataVariant3(GetScoresResponseDataVariant3!);
            }
            else if (IsGetScoresResponseDataVariant4 && getScoresResponseDataVariant4 != null)
            {
                return getScoresResponseDataVariant4(GetScoresResponseDataVariant4!);
            }
            else if (IsGetScoresResponseDataVariant5 && getScoresResponseDataVariant5 != null)
            {
                return getScoresResponseDataVariant5(GetScoresResponseDataVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?>? getScoresResponseDataVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?>? getScoresResponseDataVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?>? getScoresResponseDataVariant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?>? getScoresResponseDataVariant4 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?>? getScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataVariant1)
            {
                getScoresResponseDataVariant1?.Invoke(GetScoresResponseDataVariant1!);
            }
            else if (IsGetScoresResponseDataVariant2)
            {
                getScoresResponseDataVariant2?.Invoke(GetScoresResponseDataVariant2!);
            }
            else if (IsGetScoresResponseDataVariant3)
            {
                getScoresResponseDataVariant3?.Invoke(GetScoresResponseDataVariant3!);
            }
            else if (IsGetScoresResponseDataVariant4)
            {
                getScoresResponseDataVariant4?.Invoke(GetScoresResponseDataVariant4!);
            }
            else if (IsGetScoresResponseDataVariant5)
            {
                getScoresResponseDataVariant5?.Invoke(GetScoresResponseDataVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?>? getScoresResponseDataVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?>? getScoresResponseDataVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?>? getScoresResponseDataVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?>? getScoresResponseDataVariant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?>? getScoresResponseDataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataVariant1)
            {
                getScoresResponseDataVariant1?.Invoke(GetScoresResponseDataVariant1!);
            }
            else if (IsGetScoresResponseDataVariant2)
            {
                getScoresResponseDataVariant2?.Invoke(GetScoresResponseDataVariant2!);
            }
            else if (IsGetScoresResponseDataVariant3)
            {
                getScoresResponseDataVariant3?.Invoke(GetScoresResponseDataVariant3!);
            }
            else if (IsGetScoresResponseDataVariant4)
            {
                getScoresResponseDataVariant4?.Invoke(GetScoresResponseDataVariant4!);
            }
            else if (IsGetScoresResponseDataVariant5)
            {
                getScoresResponseDataVariant5?.Invoke(GetScoresResponseDataVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetScoresResponseDataVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>),
                GetScoresResponseDataVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>),
                GetScoresResponseDataVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>),
                GetScoresResponseDataVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>),
                GetScoresResponseDataVariant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>),
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
        public bool Equals(GetScoresResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant12, global::Langfuse.GetScoresResponseDataNumeric>?>.Default.Equals(GetScoresResponseDataVariant1, other.GetScoresResponseDataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant22, global::Langfuse.GetScoresResponseDataCategorical>?>.Default.Equals(GetScoresResponseDataVariant2, other.GetScoresResponseDataVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant32, global::Langfuse.GetScoresResponseDataBoolean>?>.Default.Equals(GetScoresResponseDataVariant3, other.GetScoresResponseDataVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant42, global::Langfuse.GetScoresResponseDataCorrection>?>.Default.Equals(GetScoresResponseDataVariant4, other.GetScoresResponseDataVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataVariant52, global::Langfuse.GetScoresResponseDataText>?>.Default.Equals(GetScoresResponseDataVariant5, other.GetScoresResponseDataVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetScoresResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetScoresResponseData o && Equals(o);
        }
    }
}
