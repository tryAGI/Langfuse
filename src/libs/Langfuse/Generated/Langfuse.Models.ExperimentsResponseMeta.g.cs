#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Metadata for cursor-based pagination.
    /// </summary>
    public readonly partial struct ExperimentsResponseMeta : global::System.IEquatable<ExperimentsResponseMeta>
    {
        /// <summary>
        /// Metadata for cursor-based pagination.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UtilsCursorMetaResponse? UtilsCursorMetaResponse { get; init; }
#else
        public global::Langfuse.UtilsCursorMetaResponse? UtilsCursorMetaResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UtilsCursorMetaResponse))]
#endif
        public bool IsUtilsCursorMetaResponse => UtilsCursorMetaResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUtilsCursorMetaResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UtilsCursorMetaResponse? value)
        {
            value = UtilsCursorMetaResponse;
            return IsUtilsCursorMetaResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UtilsCursorMetaResponse PickUtilsCursorMetaResponse() => IsUtilsCursorMetaResponse
            ? UtilsCursorMetaResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UtilsCursorMetaResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ExperimentsResponseMeta(global::Langfuse.UtilsCursorMetaResponse value) => new ExperimentsResponseMeta((global::Langfuse.UtilsCursorMetaResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UtilsCursorMetaResponse?(ExperimentsResponseMeta @this) => @this.UtilsCursorMetaResponse;

        /// <summary>
        ///
        /// </summary>
        public ExperimentsResponseMeta(global::Langfuse.UtilsCursorMetaResponse? value)
        {
            UtilsCursorMetaResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ExperimentsResponseMeta FromUtilsCursorMetaResponse(global::Langfuse.UtilsCursorMetaResponse? value) => new ExperimentsResponseMeta(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UtilsCursorMetaResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UtilsCursorMetaResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUtilsCursorMetaResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.UtilsCursorMetaResponse, TResult>? utilsCursorMetaResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtilsCursorMetaResponse && utilsCursorMetaResponse != null)
            {
                return utilsCursorMetaResponse(UtilsCursorMetaResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.UtilsCursorMetaResponse>? utilsCursorMetaResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtilsCursorMetaResponse)
            {
                utilsCursorMetaResponse?.Invoke(UtilsCursorMetaResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.UtilsCursorMetaResponse>? utilsCursorMetaResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtilsCursorMetaResponse)
            {
                utilsCursorMetaResponse?.Invoke(UtilsCursorMetaResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UtilsCursorMetaResponse,
                typeof(global::Langfuse.UtilsCursorMetaResponse),
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
        public bool Equals(ExperimentsResponseMeta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UtilsCursorMetaResponse?>.Default.Equals(UtilsCursorMetaResponse, other.UtilsCursorMetaResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ExperimentsResponseMeta obj1, ExperimentsResponseMeta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExperimentsResponseMeta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExperimentsResponseMeta obj1, ExperimentsResponseMeta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExperimentsResponseMeta o && Equals(o);
        }
    }
}
