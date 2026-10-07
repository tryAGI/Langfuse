#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateScoresRequest : global::System.IEquatable<CreateScoresRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.CreateScoreRequest? CreateScoreRequest { get; init; }
#else
        public global::Langfuse.CreateScoreRequest? CreateScoreRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreRequest))]
#endif
        public bool IsCreateScoreRequest => CreateScoreRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateScoreRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.CreateScoreRequest? value)
        {
            value = CreateScoreRequest;
            return IsCreateScoreRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreRequest PickCreateScoreRequest() => CreateScoreRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateScoreRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? CreateScoreBatchRequest { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? CreateScoreBatchRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreBatchRequest))]
#endif
        public bool IsCreateScoreBatchRequest => CreateScoreBatchRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateScoreBatchRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? value)
        {
            value = CreateScoreBatchRequest;
            return IsCreateScoreBatchRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest> PickCreateScoreBatchRequest() => CreateScoreBatchRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateScoreBatchRequest' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateScoresRequest(global::Langfuse.CreateScoreRequest value) => new CreateScoresRequest((global::Langfuse.CreateScoreRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.CreateScoreRequest?(CreateScoresRequest @this) => @this.CreateScoreRequest;

        /// <summary>
        ///
        /// </summary>
        public CreateScoresRequest(global::Langfuse.CreateScoreRequest? value)
        {
            CreateScoreRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoresRequest FromCreateScoreRequest(global::Langfuse.CreateScoreRequest? value) => new CreateScoresRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateScoresRequest(
            global::Langfuse.CreateScoreRequest? createScoreRequest,
            global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>? createScoreBatchRequest
            )
        {
            CreateScoreRequest = createScoreRequest;
            CreateScoreBatchRequest = createScoreBatchRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateScoreBatchRequest as object ??
            CreateScoreRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateScoreRequest?.ToString() ??
            CreateScoreBatchRequest?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateScoreRequest && !IsCreateScoreBatchRequest || !IsCreateScoreRequest && IsCreateScoreBatchRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.CreateScoreRequest, TResult>? createScoreRequest = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>, TResult>? createScoreBatchRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreRequest is { } __value0 && createScoreRequest != null)
            {
                return createScoreRequest(__value0);
            }
            else if (CreateScoreBatchRequest is { } __value1 && createScoreBatchRequest != null)
            {
                return createScoreBatchRequest(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.CreateScoreRequest>? createScoreRequest = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>>? createScoreBatchRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreRequest is { } __value0)
            {
                createScoreRequest?.Invoke(__value0);
            }
            else if (CreateScoreBatchRequest is { } __value1)
            {
                createScoreBatchRequest?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.CreateScoreRequest>? createScoreRequest = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>>? createScoreBatchRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreRequest is { } __value0)
            {
                createScoreRequest?.Invoke(__value0);
            }
            else if (CreateScoreBatchRequest is { } __value1)
            {
                createScoreBatchRequest?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateScoreRequest,
                typeof(global::Langfuse.CreateScoreRequest),
                CreateScoreBatchRequest,
                typeof(global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>),
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
        public bool Equals(CreateScoresRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.CreateScoreRequest?>.Default.Equals(CreateScoreRequest, other.CreateScoreRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest>?>.Default.Equals(CreateScoreBatchRequest, other.CreateScoreBatchRequest)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateScoresRequest obj1, CreateScoresRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateScoresRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateScoresRequest obj1, CreateScoresRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateScoresRequest o && Equals(o);
        }
    }
}
