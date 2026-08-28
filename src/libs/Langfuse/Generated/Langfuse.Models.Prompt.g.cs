#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Prompt : global::System.IEquatable<Prompt>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? ChatPrompt { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? ChatPrompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatPrompt))]
#endif
        public bool IsChatPrompt => ChatPrompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? value)
        {
            value = ChatPrompt;
            return IsChatPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt> PickChatPrompt() => IsChatPrompt
            ? ChatPrompt!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatPrompt' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? TextPrompt { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? TextPrompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextPrompt))]
#endif
        public bool IsTextPrompt => TextPrompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? value)
        {
            value = TextPrompt;
            return IsTextPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt> PickTextPrompt() => IsTextPrompt
            ? TextPrompt!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextPrompt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Prompt(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt> value) => new Prompt((global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?(Prompt @this) => @this.ChatPrompt;

        /// <summary>
        ///
        /// </summary>
        public Prompt(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? value)
        {
            ChatPrompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Prompt FromChatPrompt(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? value) => new Prompt(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Prompt(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt> value) => new Prompt((global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?(Prompt @this) => @this.TextPrompt;

        /// <summary>
        ///
        /// </summary>
        public Prompt(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? value)
        {
            TextPrompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Prompt FromTextPrompt(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? value) => new Prompt(value);

        /// <summary>
        ///
        /// </summary>
        public Prompt(
            global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>? chatPrompt,
            global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>? textPrompt
            )
        {
            ChatPrompt = chatPrompt;
            TextPrompt = textPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextPrompt as object ??
            ChatPrompt as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChatPrompt?.ToString() ??
            TextPrompt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChatPrompt && !IsTextPrompt || !IsChatPrompt && IsTextPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?, TResult>? chatPrompt = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?, TResult>? textPrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatPrompt && chatPrompt != null)
            {
                return chatPrompt(ChatPrompt!);
            }
            else if (IsTextPrompt && textPrompt != null)
            {
                return textPrompt(TextPrompt!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?>? chatPrompt = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?>? textPrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatPrompt)
            {
                chatPrompt?.Invoke(ChatPrompt!);
            }
            else if (IsTextPrompt)
            {
                textPrompt?.Invoke(TextPrompt!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?>? chatPrompt = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?>? textPrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatPrompt)
            {
                chatPrompt?.Invoke(ChatPrompt!);
            }
            else if (IsTextPrompt)
            {
                textPrompt?.Invoke(TextPrompt!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatPrompt,
                typeof(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>),
                TextPrompt,
                typeof(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>),
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
        public bool Equals(Prompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?>.Default.Equals(ChatPrompt, other.ChatPrompt) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?>.Default.Equals(TextPrompt, other.TextPrompt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Prompt obj1, Prompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Prompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Prompt obj1, Prompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Prompt o && Equals(o);
        }
    }
}
