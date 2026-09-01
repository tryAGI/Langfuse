#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// A user prompt string shortcut, or an ordered list of chat messages.
    /// </summary>
    public readonly partial struct EvaluatorChatPromptInput : global::System.IEquatable<EvaluatorChatPromptInput>
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
        /// An ordered list of chat messages. A system message is only allowed as the first message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? EvaluatorChatPrompt { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? EvaluatorChatPrompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvaluatorChatPrompt))]
#endif
        public bool IsEvaluatorChatPrompt => EvaluatorChatPrompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvaluatorChatPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? value)
        {
            value = EvaluatorChatPrompt;
            return IsEvaluatorChatPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage> PickEvaluatorChatPrompt() => IsEvaluatorChatPrompt
            ? EvaluatorChatPrompt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EvaluatorChatPrompt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorChatPromptInput(string value) => new EvaluatorChatPromptInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(EvaluatorChatPromptInput @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorChatPromptInput(string? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorChatPromptInput FromString(string? value) => new EvaluatorChatPromptInput(value);

        /// <summary>
        ///
        /// </summary>
        public EvaluatorChatPromptInput(
            string? @string,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>? evaluatorChatPrompt
            )
        {
            String = @string;
            EvaluatorChatPrompt = evaluatorChatPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EvaluatorChatPrompt as object ??
            String as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            EvaluatorChatPrompt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsEvaluatorChatPrompt || !IsString && IsEvaluatorChatPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? @string = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>, TResult>? evaluatorChatPrompt = null,
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
            else if (IsEvaluatorChatPrompt && evaluatorChatPrompt != null)
            {
                return evaluatorChatPrompt(EvaluatorChatPrompt!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? @string = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>>? evaluatorChatPrompt = null,
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
            else if (IsEvaluatorChatPrompt)
            {
                evaluatorChatPrompt?.Invoke(EvaluatorChatPrompt!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? @string = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>>? evaluatorChatPrompt = null,
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
            else if (IsEvaluatorChatPrompt)
            {
                evaluatorChatPrompt?.Invoke(EvaluatorChatPrompt!);
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
                EvaluatorChatPrompt,
                typeof(global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>),
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
        public bool Equals(EvaluatorChatPromptInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Langfuse.EvaluatorChatMessage>?>.Default.Equals(EvaluatorChatPrompt, other.EvaluatorChatPrompt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EvaluatorChatPromptInput obj1, EvaluatorChatPromptInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluatorChatPromptInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EvaluatorChatPromptInput obj1, EvaluatorChatPromptInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluatorChatPromptInput o && Equals(o);
        }
    }
}
