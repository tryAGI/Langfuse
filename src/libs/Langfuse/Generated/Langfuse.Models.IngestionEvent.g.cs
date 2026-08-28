#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IngestionEvent : global::System.IEquatable<IngestionEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? TraceEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? TraceEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TraceEvent))]
#endif
        public bool IsTraceEvent => TraceEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTraceEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? value)
        {
            value = TraceEvent;
            return IsTraceEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent> PickTraceEvent() => IsTraceEvent
            ? TraceEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TraceEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? ScoreEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? ScoreEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreEvent))]
#endif
        public bool IsScoreEvent => ScoreEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? value)
        {
            value = ScoreEvent;
            return IsScoreEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent> PickScoreEvent() => IsScoreEvent
            ? ScoreEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? CreateSpanEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? CreateSpanEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSpanEvent))]
#endif
        public bool IsCreateSpanEvent => CreateSpanEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSpanEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? value)
        {
            value = CreateSpanEvent;
            return IsCreateSpanEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent> PickCreateSpanEvent() => IsCreateSpanEvent
            ? CreateSpanEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSpanEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? UpdateSpanEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? UpdateSpanEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateSpanEvent))]
#endif
        public bool IsUpdateSpanEvent => UpdateSpanEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateSpanEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? value)
        {
            value = UpdateSpanEvent;
            return IsUpdateSpanEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent> PickUpdateSpanEvent() => IsUpdateSpanEvent
            ? UpdateSpanEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateSpanEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? CreateGenerationEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? CreateGenerationEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateGenerationEvent))]
#endif
        public bool IsCreateGenerationEvent => CreateGenerationEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateGenerationEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? value)
        {
            value = CreateGenerationEvent;
            return IsCreateGenerationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent> PickCreateGenerationEvent() => IsCreateGenerationEvent
            ? CreateGenerationEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateGenerationEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? UpdateGenerationEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? UpdateGenerationEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateGenerationEvent))]
#endif
        public bool IsUpdateGenerationEvent => UpdateGenerationEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateGenerationEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? value)
        {
            value = UpdateGenerationEvent;
            return IsUpdateGenerationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent> PickUpdateGenerationEvent() => IsUpdateGenerationEvent
            ? UpdateGenerationEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateGenerationEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? CreateEventEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? CreateEventEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEventEvent))]
#endif
        public bool IsCreateEventEvent => CreateEventEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateEventEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? value)
        {
            value = CreateEventEvent;
            return IsCreateEventEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent> PickCreateEventEvent() => IsCreateEventEvent
            ? CreateEventEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateEventEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? SDKLogEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? SDKLogEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SDKLogEvent))]
#endif
        public bool IsSDKLogEvent => SDKLogEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSDKLogEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? value)
        {
            value = SDKLogEvent;
            return IsSDKLogEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent> PickSDKLogEvent() => IsSDKLogEvent
            ? SDKLogEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SDKLogEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? CreateObservationEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? CreateObservationEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateObservationEvent))]
#endif
        public bool IsCreateObservationEvent => CreateObservationEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateObservationEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? value)
        {
            value = CreateObservationEvent;
            return IsCreateObservationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent> PickCreateObservationEvent() => IsCreateObservationEvent
            ? CreateObservationEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateObservationEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? UpdateObservationEvent { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? UpdateObservationEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateObservationEvent))]
#endif
        public bool IsUpdateObservationEvent => UpdateObservationEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateObservationEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? value)
        {
            value = UpdateObservationEvent;
            return IsUpdateObservationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent> PickUpdateObservationEvent() => IsUpdateObservationEvent
            ? UpdateObservationEvent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateObservationEvent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?(IngestionEvent @this) => @this.TraceEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? value)
        {
            TraceEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromTraceEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?(IngestionEvent @this) => @this.ScoreEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? value)
        {
            ScoreEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromScoreEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?(IngestionEvent @this) => @this.CreateSpanEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? value)
        {
            CreateSpanEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromCreateSpanEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?(IngestionEvent @this) => @this.UpdateSpanEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? value)
        {
            UpdateSpanEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromUpdateSpanEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?(IngestionEvent @this) => @this.CreateGenerationEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? value)
        {
            CreateGenerationEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromCreateGenerationEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?(IngestionEvent @this) => @this.UpdateGenerationEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? value)
        {
            UpdateGenerationEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromUpdateGenerationEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?(IngestionEvent @this) => @this.CreateEventEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? value)
        {
            CreateEventEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromCreateEventEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?(IngestionEvent @this) => @this.SDKLogEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? value)
        {
            SDKLogEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromSDKLogEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?(IngestionEvent @this) => @this.CreateObservationEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? value)
        {
            CreateObservationEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromCreateObservationEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?(IngestionEvent @this) => @this.UpdateObservationEvent;

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? value)
        {
            UpdateObservationEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IngestionEvent FromUpdateObservationEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public IngestionEvent(
            global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>? traceEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>? scoreEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>? createSpanEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>? updateSpanEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>? createGenerationEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>? updateGenerationEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>? createEventEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>? sDKLogEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>? createObservationEvent,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>? updateObservationEvent
            )
        {
            TraceEvent = traceEvent;
            ScoreEvent = scoreEvent;
            CreateSpanEvent = createSpanEvent;
            UpdateSpanEvent = updateSpanEvent;
            CreateGenerationEvent = createGenerationEvent;
            UpdateGenerationEvent = updateGenerationEvent;
            CreateEventEvent = createEventEvent;
            SDKLogEvent = sDKLogEvent;
            CreateObservationEvent = createObservationEvent;
            UpdateObservationEvent = updateObservationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UpdateObservationEvent as object ??
            CreateObservationEvent as object ??
            SDKLogEvent as object ??
            CreateEventEvent as object ??
            UpdateGenerationEvent as object ??
            CreateGenerationEvent as object ??
            UpdateSpanEvent as object ??
            CreateSpanEvent as object ??
            ScoreEvent as object ??
            TraceEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TraceEvent?.ToString() ??
            ScoreEvent?.ToString() ??
            CreateSpanEvent?.ToString() ??
            UpdateSpanEvent?.ToString() ??
            CreateGenerationEvent?.ToString() ??
            UpdateGenerationEvent?.ToString() ??
            CreateEventEvent?.ToString() ??
            SDKLogEvent?.ToString() ??
            CreateObservationEvent?.ToString() ??
            UpdateObservationEvent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && IsSDKLogEvent && !IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && IsCreateObservationEvent && !IsUpdateObservationEvent || !IsTraceEvent && !IsScoreEvent && !IsCreateSpanEvent && !IsUpdateSpanEvent && !IsCreateGenerationEvent && !IsUpdateGenerationEvent && !IsCreateEventEvent && !IsSDKLogEvent && !IsCreateObservationEvent && IsUpdateObservationEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?, TResult>? traceEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?, TResult>? scoreEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?, TResult>? createSpanEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?, TResult>? updateSpanEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?, TResult>? createGenerationEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?, TResult>? updateGenerationEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?, TResult>? createEventEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?, TResult>? sDKLogEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?, TResult>? createObservationEvent = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?, TResult>? updateObservationEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTraceEvent && traceEvent != null)
            {
                return traceEvent(TraceEvent!);
            }
            else if (IsScoreEvent && scoreEvent != null)
            {
                return scoreEvent(ScoreEvent!);
            }
            else if (IsCreateSpanEvent && createSpanEvent != null)
            {
                return createSpanEvent(CreateSpanEvent!);
            }
            else if (IsUpdateSpanEvent && updateSpanEvent != null)
            {
                return updateSpanEvent(UpdateSpanEvent!);
            }
            else if (IsCreateGenerationEvent && createGenerationEvent != null)
            {
                return createGenerationEvent(CreateGenerationEvent!);
            }
            else if (IsUpdateGenerationEvent && updateGenerationEvent != null)
            {
                return updateGenerationEvent(UpdateGenerationEvent!);
            }
            else if (IsCreateEventEvent && createEventEvent != null)
            {
                return createEventEvent(CreateEventEvent!);
            }
            else if (IsSDKLogEvent && sDKLogEvent != null)
            {
                return sDKLogEvent(SDKLogEvent!);
            }
            else if (IsCreateObservationEvent && createObservationEvent != null)
            {
                return createObservationEvent(CreateObservationEvent!);
            }
            else if (IsUpdateObservationEvent && updateObservationEvent != null)
            {
                return updateObservationEvent(UpdateObservationEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?>? traceEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?>? scoreEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?>? createSpanEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?>? updateSpanEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?>? createGenerationEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?>? updateGenerationEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?>? createEventEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?>? sDKLogEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?>? createObservationEvent = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?>? updateObservationEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTraceEvent)
            {
                traceEvent?.Invoke(TraceEvent!);
            }
            else if (IsScoreEvent)
            {
                scoreEvent?.Invoke(ScoreEvent!);
            }
            else if (IsCreateSpanEvent)
            {
                createSpanEvent?.Invoke(CreateSpanEvent!);
            }
            else if (IsUpdateSpanEvent)
            {
                updateSpanEvent?.Invoke(UpdateSpanEvent!);
            }
            else if (IsCreateGenerationEvent)
            {
                createGenerationEvent?.Invoke(CreateGenerationEvent!);
            }
            else if (IsUpdateGenerationEvent)
            {
                updateGenerationEvent?.Invoke(UpdateGenerationEvent!);
            }
            else if (IsCreateEventEvent)
            {
                createEventEvent?.Invoke(CreateEventEvent!);
            }
            else if (IsSDKLogEvent)
            {
                sDKLogEvent?.Invoke(SDKLogEvent!);
            }
            else if (IsCreateObservationEvent)
            {
                createObservationEvent?.Invoke(CreateObservationEvent!);
            }
            else if (IsUpdateObservationEvent)
            {
                updateObservationEvent?.Invoke(UpdateObservationEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?>? traceEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?>? scoreEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?>? createSpanEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?>? updateSpanEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?>? createGenerationEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?>? updateGenerationEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?>? createEventEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?>? sDKLogEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?>? createObservationEvent = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?>? updateObservationEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTraceEvent)
            {
                traceEvent?.Invoke(TraceEvent!);
            }
            else if (IsScoreEvent)
            {
                scoreEvent?.Invoke(ScoreEvent!);
            }
            else if (IsCreateSpanEvent)
            {
                createSpanEvent?.Invoke(CreateSpanEvent!);
            }
            else if (IsUpdateSpanEvent)
            {
                updateSpanEvent?.Invoke(UpdateSpanEvent!);
            }
            else if (IsCreateGenerationEvent)
            {
                createGenerationEvent?.Invoke(CreateGenerationEvent!);
            }
            else if (IsUpdateGenerationEvent)
            {
                updateGenerationEvent?.Invoke(UpdateGenerationEvent!);
            }
            else if (IsCreateEventEvent)
            {
                createEventEvent?.Invoke(CreateEventEvent!);
            }
            else if (IsSDKLogEvent)
            {
                sDKLogEvent?.Invoke(SDKLogEvent!);
            }
            else if (IsCreateObservationEvent)
            {
                createObservationEvent?.Invoke(CreateObservationEvent!);
            }
            else if (IsUpdateObservationEvent)
            {
                updateObservationEvent?.Invoke(UpdateObservationEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TraceEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>),
                ScoreEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>),
                CreateSpanEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>),
                UpdateSpanEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>),
                CreateGenerationEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>),
                UpdateGenerationEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>),
                CreateEventEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>),
                SDKLogEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>),
                CreateObservationEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>),
                UpdateObservationEvent,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>),
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
        public bool Equals(IngestionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventTraceEvent2, global::Langfuse.TraceEvent>?>.Default.Equals(TraceEvent, other.TraceEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventScoreEvent2, global::Langfuse.ScoreEvent>?>.Default.Equals(ScoreEvent, other.ScoreEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateSpanEvent2, global::Langfuse.CreateSpanEvent>?>.Default.Equals(CreateSpanEvent, other.CreateSpanEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateSpanEvent2, global::Langfuse.UpdateSpanEvent>?>.Default.Equals(UpdateSpanEvent, other.UpdateSpanEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateGenerationEvent2, global::Langfuse.CreateGenerationEvent>?>.Default.Equals(CreateGenerationEvent, other.CreateGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateGenerationEvent2, global::Langfuse.UpdateGenerationEvent>?>.Default.Equals(UpdateGenerationEvent, other.UpdateGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateEventEvent2, global::Langfuse.CreateEventEvent>?>.Default.Equals(CreateEventEvent, other.CreateEventEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventSDKLogEvent2, global::Langfuse.SDKLogEvent>?>.Default.Equals(SDKLogEvent, other.SDKLogEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventCreateObservationEvent2, global::Langfuse.CreateObservationEvent>?>.Default.Equals(CreateObservationEvent, other.CreateObservationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventUpdateObservationEvent2, global::Langfuse.UpdateObservationEvent>?>.Default.Equals(UpdateObservationEvent, other.UpdateObservationEvent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IngestionEvent obj1, IngestionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IngestionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IngestionEvent obj1, IngestionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IngestionEvent o && Equals(o);
        }
    }
}
