#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MapValue : global::System.IEquatable<MapValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? String { get; init; }
#else
        public string? String { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickString() => IsString
            ? String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? Integer { get; init; }
#else
        public int? Integer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Integer))]
#endif
        public bool IsInteger => Integer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInteger(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickInteger() => IsInteger
            ? Integer!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public float? FloatNumber { get; init; }
#else
        public float? FloatNumber { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FloatNumber))]
#endif
        public bool IsFloatNumber => FloatNumber != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFloatNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out float? value)
        {
            value = FloatNumber;
            return IsFloatNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public float PickFloatNumber() => IsFloatNumber
            ? FloatNumber!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FloatNumber' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Boolean { get; init; }
#else
        public bool? Boolean { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBoolean(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickBoolean() => IsBoolean
            ? Boolean!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? Array { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Array { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickArray() => IsArray
            ? Array!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MapValue(string value) => new MapValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(MapValue @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public MapValue(string? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MapValue FromString(string? value) => new MapValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MapValue(int value) => new MapValue((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(MapValue @this) => @this.Integer;

        /// <summary>
        ///
        /// </summary>
        public MapValue(int? value)
        {
            Integer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MapValue FromInteger(int? value) => new MapValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MapValue(float value) => new MapValue((float?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator float?(MapValue @this) => @this.FloatNumber;

        /// <summary>
        ///
        /// </summary>
        public MapValue(float? value)
        {
            FloatNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MapValue FromFloatNumber(float? value) => new MapValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MapValue(bool value) => new MapValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(MapValue @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public MapValue(bool? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MapValue FromBoolean(bool? value) => new MapValue(value);

        /// <summary>
        ///
        /// </summary>
        public MapValue(
            string? @string,
            int? integer,
            float? floatNumber,
            bool? boolean,
            global::System.Collections.Generic.IList<string>? array
            )
        {
            String = @string;
            Integer = integer;
            FloatNumber = floatNumber;
            Boolean = boolean;
            Array = array;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Array as object ??
            Boolean as object ??
            FloatNumber as object ??
            Integer as object ??
            String as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Integer?.ToString() ??
            FloatNumber?.ToString() ??
            Boolean?.ToString().ToLowerInvariant() ??
            Array?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsInteger && !IsFloatNumber && !IsBoolean && !IsArray || !IsString && IsInteger && !IsFloatNumber && !IsBoolean && !IsArray || !IsString && !IsInteger && IsFloatNumber && !IsBoolean && !IsArray || !IsString && !IsInteger && !IsFloatNumber && IsBoolean && !IsArray || !IsString && !IsInteger && !IsFloatNumber && !IsBoolean && IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? @string = null,
            global::System.Func<int?, TResult>? integer = null,
            global::System.Func<float?, TResult>? floatNumber = null,
            global::System.Func<bool?, TResult>? boolean = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsInteger && integer != null)
            {
                return integer(Integer!);
            }
            else if (IsFloatNumber && floatNumber != null)
            {
                return floatNumber(FloatNumber!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? @string = null,

            global::System.Action<int?>? integer = null,

            global::System.Action<float?>? floatNumber = null,

            global::System.Action<bool?>? boolean = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsFloatNumber)
            {
                floatNumber?.Invoke(FloatNumber!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? @string = null,
            global::System.Action<int?>? integer = null,
            global::System.Action<float?>? floatNumber = null,
            global::System.Action<bool?>? boolean = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsFloatNumber)
            {
                floatNumber?.Invoke(FloatNumber!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(string),
                Integer,
                typeof(int),
                FloatNumber,
                typeof(float),
                Boolean,
                typeof(bool),
                Array,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(MapValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<float?>.Default.Equals(FloatNumber, other.FloatNumber) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Array, other.Array)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MapValue obj1, MapValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MapValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MapValue obj1, MapValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MapValue o && Equals(o);
        }
    }
}
