#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
    /// </summary>
    public readonly partial struct DecisionModelEntry : global::System.IEquatable<DecisionModelEntry>
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
        public string PickString() => String is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ObjectValue { get; init; }
#else
        public object? ObjectValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickObjectValue() => ObjectValue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? Array { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? Array { get; }
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
            out global::System.Collections.Generic.IList<object>? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object> PickArray() => Array is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? DoubleNumber { get; init; }
#else
        public double? DoubleNumber { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoubleNumber))]
#endif
        public bool IsDoubleNumber => DoubleNumber != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDoubleNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = DoubleNumber;
            return IsDoubleNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickDoubleNumber() => DoubleNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleNumber' but the value was {ToString()}.");

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
        public bool PickBoolean() => Boolean is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelEntry(string value) => new DecisionModelEntry((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionModelEntry @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelEntry(string? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelEntry FromString(string? value) => new DecisionModelEntry(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelEntry(double value) => new DecisionModelEntry((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(DecisionModelEntry @this) => @this.DoubleNumber;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelEntry(double? value)
        {
            DoubleNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelEntry FromDoubleNumber(double? value) => new DecisionModelEntry(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelEntry(bool value) => new DecisionModelEntry((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(DecisionModelEntry @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelEntry(bool? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelEntry FromBoolean(bool? value) => new DecisionModelEntry(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionModelEntry(
            string? @string,
            object? objectValue,
            global::System.Collections.Generic.IList<object>? array,
            double? doubleNumber,
            bool? boolean
            )
        {
            String = @string;
            ObjectValue = objectValue;
            Array = array;
            DoubleNumber = doubleNumber;
            Boolean = boolean;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Boolean as object ??
            DoubleNumber as object ??
            Array as object ??
            ObjectValue as object ??
            String as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            ObjectValue?.ToString() ??
            Array?.ToString() ??
            DoubleNumber?.ToString() ??
            Boolean?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsObjectValue && !IsArray && !IsDoubleNumber && !IsBoolean || !IsString && IsObjectValue && !IsArray && !IsDoubleNumber && !IsBoolean || !IsString && !IsObjectValue && IsArray && !IsDoubleNumber && !IsBoolean || !IsString && !IsObjectValue && !IsArray && IsDoubleNumber && !IsBoolean || !IsString && !IsObjectValue && !IsArray && !IsDoubleNumber && IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? @string = null,
            global::System.Func<object, TResult>? objectValue = null,
            global::System.Func<global::System.Collections.Generic.IList<object>, TResult>? array = null,
            global::System.Func<double?, TResult>? doubleNumber = null,
            global::System.Func<bool?, TResult>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0 && @string != null)
            {
                return @string(__value0);
            }
            else if (ObjectValue is { } __value1 && objectValue != null)
            {
                return objectValue(__value1);
            }
            else if (Array is { } __value2 && array != null)
            {
                return array(__value2);
            }
            else if (DoubleNumber is { } __value3 && doubleNumber != null)
            {
                return doubleNumber(__value3);
            }
            else if (Boolean is { } __value4 && boolean != null)
            {
                return boolean(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? @string = null,

            global::System.Action<object>? objectValue = null,

            global::System.Action<global::System.Collections.Generic.IList<object>>? array = null,

            global::System.Action<double?>? doubleNumber = null,

            global::System.Action<bool?>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0)
            {
                @string?.Invoke(__value0);
            }
            else if (ObjectValue is { } __value1)
            {
                objectValue?.Invoke(__value1);
            }
            else if (Array is { } __value2)
            {
                array?.Invoke(__value2);
            }
            else if (DoubleNumber is { } __value3)
            {
                doubleNumber?.Invoke(__value3);
            }
            else if (Boolean is { } __value4)
            {
                boolean?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? @string = null,
            global::System.Action<object>? objectValue = null,
            global::System.Action<global::System.Collections.Generic.IList<object>>? array = null,
            global::System.Action<double?>? doubleNumber = null,
            global::System.Action<bool?>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0)
            {
                @string?.Invoke(__value0);
            }
            else if (ObjectValue is { } __value1)
            {
                objectValue?.Invoke(__value1);
            }
            else if (Array is { } __value2)
            {
                array?.Invoke(__value2);
            }
            else if (DoubleNumber is { } __value3)
            {
                doubleNumber?.Invoke(__value3);
            }
            else if (Boolean is { } __value4)
            {
                boolean?.Invoke(__value4);
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
                ObjectValue,
                typeof(object),
                Array,
                typeof(global::System.Collections.Generic.IList<object>),
                DoubleNumber,
                typeof(double),
                Boolean,
                typeof(bool),
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
        public bool Equals(DecisionModelEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DoubleNumber, other.DoubleNumber) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Boolean, other.Boolean)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionModelEntry obj1, DecisionModelEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionModelEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionModelEntry obj1, DecisionModelEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionModelEntry o && Equals(o);
        }
    }
}
