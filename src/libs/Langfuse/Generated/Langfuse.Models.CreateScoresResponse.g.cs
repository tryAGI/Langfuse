#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateScoresResponse : global::System.IEquatable<CreateScoresResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.CreateScoreResponse? CreateScoreResponse { get; init; }
#else
        public global::Langfuse.CreateScoreResponse? CreateScoreResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreResponse))]
#endif
        public bool IsCreateScoreResponse => CreateScoreResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateScoreResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.CreateScoreResponse? value)
        {
            value = CreateScoreResponse;
            return IsCreateScoreResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreResponse PickCreateScoreResponse() => CreateScoreResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateScoreResponse' but the value was {ToString()}.");

        /// <summary>
        /// Batch accepted (HTTP 202).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.CreateScoreBatchResponse? CreateScoreBatchResponse { get; init; }
#else
        public global::Langfuse.CreateScoreBatchResponse? CreateScoreBatchResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreBatchResponse))]
#endif
        public bool IsCreateScoreBatchResponse => CreateScoreBatchResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateScoreBatchResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.CreateScoreBatchResponse? value)
        {
            value = CreateScoreBatchResponse;
            return IsCreateScoreBatchResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResponse PickCreateScoreBatchResponse() => CreateScoreBatchResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateScoreBatchResponse' but the value was {ToString()}.");

        /// <summary>
        /// Acceptance counts and errors (HTTP 207).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.CreateScoreBatchResults? CreateScoreBatchResults { get; init; }
#else
        public global::Langfuse.CreateScoreBatchResults? CreateScoreBatchResults { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreBatchResults))]
#endif
        public bool IsCreateScoreBatchResults => CreateScoreBatchResults != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateScoreBatchResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.CreateScoreBatchResults? value)
        {
            value = CreateScoreBatchResults;
            return IsCreateScoreBatchResults;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.CreateScoreBatchResults PickCreateScoreBatchResults() => CreateScoreBatchResults is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateScoreBatchResults' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateScoresResponse(global::Langfuse.CreateScoreResponse value) => new CreateScoresResponse((global::Langfuse.CreateScoreResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.CreateScoreResponse?(CreateScoresResponse @this) => @this.CreateScoreResponse;

        /// <summary>
        ///
        /// </summary>
        public CreateScoresResponse(global::Langfuse.CreateScoreResponse? value)
        {
            CreateScoreResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoresResponse FromCreateScoreResponse(global::Langfuse.CreateScoreResponse? value) => new CreateScoresResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateScoresResponse(global::Langfuse.CreateScoreBatchResponse value) => new CreateScoresResponse((global::Langfuse.CreateScoreBatchResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.CreateScoreBatchResponse?(CreateScoresResponse @this) => @this.CreateScoreBatchResponse;

        /// <summary>
        ///
        /// </summary>
        public CreateScoresResponse(global::Langfuse.CreateScoreBatchResponse? value)
        {
            CreateScoreBatchResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoresResponse FromCreateScoreBatchResponse(global::Langfuse.CreateScoreBatchResponse? value) => new CreateScoresResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateScoresResponse(global::Langfuse.CreateScoreBatchResults value) => new CreateScoresResponse((global::Langfuse.CreateScoreBatchResults?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.CreateScoreBatchResults?(CreateScoresResponse @this) => @this.CreateScoreBatchResults;

        /// <summary>
        ///
        /// </summary>
        public CreateScoresResponse(global::Langfuse.CreateScoreBatchResults? value)
        {
            CreateScoreBatchResults = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateScoresResponse FromCreateScoreBatchResults(global::Langfuse.CreateScoreBatchResults? value) => new CreateScoresResponse(value);

        /// <summary>
        ///
        /// </summary>
        public CreateScoresResponse(
            global::Langfuse.CreateScoreResponse? createScoreResponse,
            global::Langfuse.CreateScoreBatchResponse? createScoreBatchResponse,
            global::Langfuse.CreateScoreBatchResults? createScoreBatchResults
            )
        {
            CreateScoreResponse = createScoreResponse;
            CreateScoreBatchResponse = createScoreBatchResponse;
            CreateScoreBatchResults = createScoreBatchResults;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateScoreBatchResults as object ??
            CreateScoreBatchResponse as object ??
            CreateScoreResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateScoreResponse?.ToString() ??
            CreateScoreBatchResponse?.ToString() ??
            CreateScoreBatchResults?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateScoreResponse && !IsCreateScoreBatchResponse && !IsCreateScoreBatchResults || !IsCreateScoreResponse && IsCreateScoreBatchResponse && !IsCreateScoreBatchResults || !IsCreateScoreResponse && !IsCreateScoreBatchResponse && IsCreateScoreBatchResults;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.CreateScoreResponse, TResult>? createScoreResponse = null,
            global::System.Func<global::Langfuse.CreateScoreBatchResponse, TResult>? createScoreBatchResponse = null,
            global::System.Func<global::Langfuse.CreateScoreBatchResults, TResult>? createScoreBatchResults = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreResponse is { } __value0 && createScoreResponse != null)
            {
                return createScoreResponse(__value0);
            }
            else if (CreateScoreBatchResponse is { } __value1 && createScoreBatchResponse != null)
            {
                return createScoreBatchResponse(__value1);
            }
            else if (CreateScoreBatchResults is { } __value2 && createScoreBatchResults != null)
            {
                return createScoreBatchResults(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.CreateScoreResponse>? createScoreResponse = null,

            global::System.Action<global::Langfuse.CreateScoreBatchResponse>? createScoreBatchResponse = null,

            global::System.Action<global::Langfuse.CreateScoreBatchResults>? createScoreBatchResults = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreResponse is { } __value0)
            {
                createScoreResponse?.Invoke(__value0);
            }
            else if (CreateScoreBatchResponse is { } __value1)
            {
                createScoreBatchResponse?.Invoke(__value1);
            }
            else if (CreateScoreBatchResults is { } __value2)
            {
                createScoreBatchResults?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.CreateScoreResponse>? createScoreResponse = null,
            global::System.Action<global::Langfuse.CreateScoreBatchResponse>? createScoreBatchResponse = null,
            global::System.Action<global::Langfuse.CreateScoreBatchResults>? createScoreBatchResults = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateScoreResponse is { } __value0)
            {
                createScoreResponse?.Invoke(__value0);
            }
            else if (CreateScoreBatchResponse is { } __value1)
            {
                createScoreBatchResponse?.Invoke(__value1);
            }
            else if (CreateScoreBatchResults is { } __value2)
            {
                createScoreBatchResults?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateScoreResponse,
                typeof(global::Langfuse.CreateScoreResponse),
                CreateScoreBatchResponse,
                typeof(global::Langfuse.CreateScoreBatchResponse),
                CreateScoreBatchResults,
                typeof(global::Langfuse.CreateScoreBatchResults),
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
        public bool Equals(CreateScoresResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.CreateScoreResponse?>.Default.Equals(CreateScoreResponse, other.CreateScoreResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.CreateScoreBatchResponse?>.Default.Equals(CreateScoreBatchResponse, other.CreateScoreBatchResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.CreateScoreBatchResults?>.Default.Equals(CreateScoreBatchResults, other.CreateScoreBatchResults)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateScoresResponse obj1, CreateScoresResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateScoresResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateScoresResponse obj1, CreateScoresResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateScoresResponse o && Equals(o);
        }
    }
}
