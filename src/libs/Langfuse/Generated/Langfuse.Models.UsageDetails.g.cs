#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UsageDetails : global::System.IEquatable<UsageDetails>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, int>? ObjectValue { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, int>? ObjectValue { get; }
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
            out global::System.Collections.Generic.Dictionary<string, int>? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int> PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");

        /// <summary>
        /// OpenAI Usage schema from (Chat-)Completion APIs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.OpenAICompletionUsageSchema? OpenAICompletionUsageSchema { get; init; }
#else
        public global::Langfuse.OpenAICompletionUsageSchema? OpenAICompletionUsageSchema { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAICompletionUsageSchema))]
#endif
        public bool IsOpenAICompletionUsageSchema => OpenAICompletionUsageSchema != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAICompletionUsageSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.OpenAICompletionUsageSchema? value)
        {
            value = OpenAICompletionUsageSchema;
            return IsOpenAICompletionUsageSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAICompletionUsageSchema PickOpenAICompletionUsageSchema() => IsOpenAICompletionUsageSchema
            ? OpenAICompletionUsageSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAICompletionUsageSchema' but the value was {ToString()}.");

        /// <summary>
        /// OpenAI Usage schema from Response API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.OpenAIResponseUsageSchema? OpenAIResponseUsageSchema { get; init; }
#else
        public global::Langfuse.OpenAIResponseUsageSchema? OpenAIResponseUsageSchema { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponseUsageSchema))]
#endif
        public bool IsOpenAIResponseUsageSchema => OpenAIResponseUsageSchema != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponseUsageSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.OpenAIResponseUsageSchema? value)
        {
            value = OpenAIResponseUsageSchema;
            return IsOpenAIResponseUsageSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.OpenAIResponseUsageSchema PickOpenAIResponseUsageSchema() => IsOpenAIResponseUsageSchema
            ? OpenAIResponseUsageSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponseUsageSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UsageDetails(global::System.Collections.Generic.Dictionary<string, int> value) => new UsageDetails((global::System.Collections.Generic.Dictionary<string, int>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, int>?(UsageDetails @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public UsageDetails(global::System.Collections.Generic.Dictionary<string, int>? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UsageDetails FromObjectValue(global::System.Collections.Generic.Dictionary<string, int>? value) => new UsageDetails(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UsageDetails(global::Langfuse.OpenAICompletionUsageSchema value) => new UsageDetails((global::Langfuse.OpenAICompletionUsageSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.OpenAICompletionUsageSchema?(UsageDetails @this) => @this.OpenAICompletionUsageSchema;

        /// <summary>
        ///
        /// </summary>
        public UsageDetails(global::Langfuse.OpenAICompletionUsageSchema? value)
        {
            OpenAICompletionUsageSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UsageDetails FromOpenAICompletionUsageSchema(global::Langfuse.OpenAICompletionUsageSchema? value) => new UsageDetails(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UsageDetails(global::Langfuse.OpenAIResponseUsageSchema value) => new UsageDetails((global::Langfuse.OpenAIResponseUsageSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.OpenAIResponseUsageSchema?(UsageDetails @this) => @this.OpenAIResponseUsageSchema;

        /// <summary>
        ///
        /// </summary>
        public UsageDetails(global::Langfuse.OpenAIResponseUsageSchema? value)
        {
            OpenAIResponseUsageSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UsageDetails FromOpenAIResponseUsageSchema(global::Langfuse.OpenAIResponseUsageSchema? value) => new UsageDetails(value);

        /// <summary>
        ///
        /// </summary>
        public UsageDetails(
            global::System.Collections.Generic.Dictionary<string, int>? objectValue,
            global::Langfuse.OpenAICompletionUsageSchema? openAICompletionUsageSchema,
            global::Langfuse.OpenAIResponseUsageSchema? openAIResponseUsageSchema
            )
        {
            ObjectValue = objectValue;
            OpenAICompletionUsageSchema = openAICompletionUsageSchema;
            OpenAIResponseUsageSchema = openAIResponseUsageSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenAIResponseUsageSchema as object ??
            OpenAICompletionUsageSchema as object ??
            ObjectValue as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ObjectValue?.ToString() ??
            OpenAICompletionUsageSchema?.ToString() ??
            OpenAIResponseUsageSchema?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsObjectValue && !IsOpenAICompletionUsageSchema && !IsOpenAIResponseUsageSchema || !IsObjectValue && IsOpenAICompletionUsageSchema && !IsOpenAIResponseUsageSchema || !IsObjectValue && !IsOpenAICompletionUsageSchema && IsOpenAIResponseUsageSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.Dictionary<string, int>, TResult>? objectValue = null,
            global::System.Func<global::Langfuse.OpenAICompletionUsageSchema, TResult>? openAICompletionUsageSchema = null,
            global::System.Func<global::Langfuse.OpenAIResponseUsageSchema, TResult>? openAIResponseUsageSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsOpenAICompletionUsageSchema && openAICompletionUsageSchema != null)
            {
                return openAICompletionUsageSchema(OpenAICompletionUsageSchema!);
            }
            else if (IsOpenAIResponseUsageSchema && openAIResponseUsageSchema != null)
            {
                return openAIResponseUsageSchema(OpenAIResponseUsageSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, int>>? objectValue = null,

            global::System.Action<global::Langfuse.OpenAICompletionUsageSchema>? openAICompletionUsageSchema = null,

            global::System.Action<global::Langfuse.OpenAIResponseUsageSchema>? openAIResponseUsageSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsOpenAICompletionUsageSchema)
            {
                openAICompletionUsageSchema?.Invoke(OpenAICompletionUsageSchema!);
            }
            else if (IsOpenAIResponseUsageSchema)
            {
                openAIResponseUsageSchema?.Invoke(OpenAIResponseUsageSchema!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, int>>? objectValue = null,
            global::System.Action<global::Langfuse.OpenAICompletionUsageSchema>? openAICompletionUsageSchema = null,
            global::System.Action<global::Langfuse.OpenAIResponseUsageSchema>? openAIResponseUsageSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsOpenAICompletionUsageSchema)
            {
                openAICompletionUsageSchema?.Invoke(OpenAICompletionUsageSchema!);
            }
            else if (IsOpenAIResponseUsageSchema)
            {
                openAIResponseUsageSchema?.Invoke(OpenAIResponseUsageSchema!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectValue,
                typeof(global::System.Collections.Generic.Dictionary<string, int>),
                OpenAICompletionUsageSchema,
                typeof(global::Langfuse.OpenAICompletionUsageSchema),
                OpenAIResponseUsageSchema,
                typeof(global::Langfuse.OpenAIResponseUsageSchema),
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
        public bool Equals(UsageDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, int>?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.OpenAICompletionUsageSchema?>.Default.Equals(OpenAICompletionUsageSchema, other.OpenAICompletionUsageSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.OpenAIResponseUsageSchema?>.Default.Equals(OpenAIResponseUsageSchema, other.OpenAIResponseUsageSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UsageDetails obj1, UsageDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsageDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UsageDetails obj1, UsageDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsageDetails o && Equals(o);
        }
    }
}
