#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The value of the score. Must be passed as string for categorical and text scores, and numeric for boolean and numeric scores
    /// </summary>
    public readonly partial struct CreateScoreValue : global::System.IEquatable<CreateScoreValue>
    {
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
        public double PickDoubleNumber() => IsDoubleNumber
            ? DoubleNumber!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleNumber' but the value was {ToString()}.");

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
        public static implicit operator CreateScoreValue(double value) => new CreateScoreValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(CreateScoreValue @this) => @this.DoubleNumber;

        /// <summary>
        ///
        /// </summary>
        public CreateScoreValue(double? value)
        {
            DoubleNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoreValue FromDoubleNumber(double? value) => new CreateScoreValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateScoreValue(string value) => new CreateScoreValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(CreateScoreValue @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public CreateScoreValue(string? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoreValue FromString(string? value) => new CreateScoreValue(value);

        /// <summary>
        ///
        /// </summary>
        public CreateScoreValue(
            double? doubleNumber,
            string? @string
            )
        {
            DoubleNumber = doubleNumber;
            String = @string;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            String as object ??
            DoubleNumber as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DoubleNumber?.ToString() ??
            String?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDoubleNumber && !IsString || !IsDoubleNumber && IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? doubleNumber = null,
            global::System.Func<string, TResult>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDoubleNumber && doubleNumber != null)
            {
                return doubleNumber(DoubleNumber!);
            }
            else if (IsString && @string != null)
            {
                return @string(String!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<double?>? doubleNumber = null,

            global::System.Action<string>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDoubleNumber)
            {
                doubleNumber?.Invoke(DoubleNumber!);
            }
            else if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<double?>? doubleNumber = null,
            global::System.Action<string>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDoubleNumber)
            {
                doubleNumber?.Invoke(DoubleNumber!);
            }
            else if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DoubleNumber,
                typeof(double),
                String,
                typeof(string),
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
        public bool Equals(CreateScoreValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DoubleNumber, other.DoubleNumber) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateScoreValue obj1, CreateScoreValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateScoreValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateScoreValue obj1, CreateScoreValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateScoreValue o && Equals(o);
        }
    }
}
