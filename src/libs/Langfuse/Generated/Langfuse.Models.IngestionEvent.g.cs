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
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? IngestionEventVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? IngestionEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant1))]
#endif
        public bool IsIngestionEventVariant1 => IngestionEventVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? value)
        {
            value = IngestionEventVariant1;
            return IsIngestionEventVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? IngestionEventVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? IngestionEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant2))]
#endif
        public bool IsIngestionEventVariant2 => IngestionEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? value)
        {
            value = IngestionEventVariant2;
            return IsIngestionEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? IngestionEventVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? IngestionEventVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant3))]
#endif
        public bool IsIngestionEventVariant3 => IngestionEventVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? value)
        {
            value = IngestionEventVariant3;
            return IsIngestionEventVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? IngestionEventVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? IngestionEventVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant4))]
#endif
        public bool IsIngestionEventVariant4 => IngestionEventVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? value)
        {
            value = IngestionEventVariant4;
            return IsIngestionEventVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? IngestionEventVariant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? IngestionEventVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant5))]
#endif
        public bool IsIngestionEventVariant5 => IngestionEventVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? value)
        {
            value = IngestionEventVariant5;
            return IsIngestionEventVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? IngestionEventVariant6 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? IngestionEventVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant6))]
#endif
        public bool IsIngestionEventVariant6 => IngestionEventVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? value)
        {
            value = IngestionEventVariant6;
            return IsIngestionEventVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? IngestionEventVariant7 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? IngestionEventVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant7))]
#endif
        public bool IsIngestionEventVariant7 => IngestionEventVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? value)
        {
            value = IngestionEventVariant7;
            return IsIngestionEventVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? IngestionEventVariant8 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? IngestionEventVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant8))]
#endif
        public bool IsIngestionEventVariant8 => IngestionEventVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? value)
        {
            value = IngestionEventVariant8;
            return IsIngestionEventVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? IngestionEventVariant9 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? IngestionEventVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant9))]
#endif
        public bool IsIngestionEventVariant9 => IngestionEventVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? value)
        {
            value = IngestionEventVariant9;
            return IsIngestionEventVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? IngestionEventVariant10 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? IngestionEventVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant10))]
#endif
        public bool IsIngestionEventVariant10 => IngestionEventVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIngestionEventVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? value)
        {
            value = IngestionEventVariant10;
            return IsIngestionEventVariant10;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?(IngestionEvent @this) => @this.IngestionEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? value)
        {
            IngestionEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant1(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?(IngestionEvent @this) => @this.IngestionEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? value)
        {
            IngestionEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant2(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?(IngestionEvent @this) => @this.IngestionEventVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? value)
        {
            IngestionEventVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant3(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?(IngestionEvent @this) => @this.IngestionEventVariant4;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? value)
        {
            IngestionEventVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant4(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant5;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? value)
        {
            IngestionEventVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant5(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant6;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? value)
        {
            IngestionEventVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant6(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?(IngestionEvent @this) => @this.IngestionEventVariant7;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? value)
        {
            IngestionEventVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant7(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?(IngestionEvent @this) => @this.IngestionEventVariant8;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? value)
        {
            IngestionEventVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant8(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant9;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? value)
        {
            IngestionEventVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant9(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent> value) => new IngestionEvent((global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant10;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? value)
        {
            IngestionEventVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IngestionEvent FromIngestionEventVariant10(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? value) => new IngestionEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? ingestionEventVariant1,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? ingestionEventVariant2,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? ingestionEventVariant3,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? ingestionEventVariant4,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? ingestionEventVariant5,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? ingestionEventVariant6,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? ingestionEventVariant7,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? ingestionEventVariant8,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? ingestionEventVariant9,
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? ingestionEventVariant10
            )
        {
            IngestionEventVariant1 = ingestionEventVariant1;
            IngestionEventVariant2 = ingestionEventVariant2;
            IngestionEventVariant3 = ingestionEventVariant3;
            IngestionEventVariant4 = ingestionEventVariant4;
            IngestionEventVariant5 = ingestionEventVariant5;
            IngestionEventVariant6 = ingestionEventVariant6;
            IngestionEventVariant7 = ingestionEventVariant7;
            IngestionEventVariant8 = ingestionEventVariant8;
            IngestionEventVariant9 = ingestionEventVariant9;
            IngestionEventVariant10 = ingestionEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IngestionEventVariant10 as object ??
            IngestionEventVariant9 as object ??
            IngestionEventVariant8 as object ??
            IngestionEventVariant7 as object ??
            IngestionEventVariant6 as object ??
            IngestionEventVariant5 as object ??
            IngestionEventVariant4 as object ??
            IngestionEventVariant3 as object ??
            IngestionEventVariant2 as object ??
            IngestionEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IngestionEventVariant1?.ToString() ??
            IngestionEventVariant2?.ToString() ??
            IngestionEventVariant3?.ToString() ??
            IngestionEventVariant4?.ToString() ??
            IngestionEventVariant5?.ToString() ??
            IngestionEventVariant6?.ToString() ??
            IngestionEventVariant7?.ToString() ??
            IngestionEventVariant8?.ToString() ??
            IngestionEventVariant9?.ToString() ??
            IngestionEventVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && IsIngestionEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?, TResult>? ingestionEventVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?, TResult>? ingestionEventVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?, TResult>? ingestionEventVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?, TResult>? ingestionEventVariant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?, TResult>? ingestionEventVariant5 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?, TResult>? ingestionEventVariant6 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?, TResult>? ingestionEventVariant7 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?, TResult>? ingestionEventVariant8 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?, TResult>? ingestionEventVariant9 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?, TResult>? ingestionEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestionEventVariant1 && ingestionEventVariant1 != null)
            {
                return ingestionEventVariant1(IngestionEventVariant1!);
            }
            else if (IsIngestionEventVariant2 && ingestionEventVariant2 != null)
            {
                return ingestionEventVariant2(IngestionEventVariant2!);
            }
            else if (IsIngestionEventVariant3 && ingestionEventVariant3 != null)
            {
                return ingestionEventVariant3(IngestionEventVariant3!);
            }
            else if (IsIngestionEventVariant4 && ingestionEventVariant4 != null)
            {
                return ingestionEventVariant4(IngestionEventVariant4!);
            }
            else if (IsIngestionEventVariant5 && ingestionEventVariant5 != null)
            {
                return ingestionEventVariant5(IngestionEventVariant5!);
            }
            else if (IsIngestionEventVariant6 && ingestionEventVariant6 != null)
            {
                return ingestionEventVariant6(IngestionEventVariant6!);
            }
            else if (IsIngestionEventVariant7 && ingestionEventVariant7 != null)
            {
                return ingestionEventVariant7(IngestionEventVariant7!);
            }
            else if (IsIngestionEventVariant8 && ingestionEventVariant8 != null)
            {
                return ingestionEventVariant8(IngestionEventVariant8!);
            }
            else if (IsIngestionEventVariant9 && ingestionEventVariant9 != null)
            {
                return ingestionEventVariant9(IngestionEventVariant9!);
            }
            else if (IsIngestionEventVariant10 && ingestionEventVariant10 != null)
            {
                return ingestionEventVariant10(IngestionEventVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?>? ingestionEventVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?>? ingestionEventVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?>? ingestionEventVariant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?>? ingestionEventVariant4 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?>? ingestionEventVariant5 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?>? ingestionEventVariant6 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?>? ingestionEventVariant7 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?>? ingestionEventVariant8 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?>? ingestionEventVariant9 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?>? ingestionEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestionEventVariant1)
            {
                ingestionEventVariant1?.Invoke(IngestionEventVariant1!);
            }
            else if (IsIngestionEventVariant2)
            {
                ingestionEventVariant2?.Invoke(IngestionEventVariant2!);
            }
            else if (IsIngestionEventVariant3)
            {
                ingestionEventVariant3?.Invoke(IngestionEventVariant3!);
            }
            else if (IsIngestionEventVariant4)
            {
                ingestionEventVariant4?.Invoke(IngestionEventVariant4!);
            }
            else if (IsIngestionEventVariant5)
            {
                ingestionEventVariant5?.Invoke(IngestionEventVariant5!);
            }
            else if (IsIngestionEventVariant6)
            {
                ingestionEventVariant6?.Invoke(IngestionEventVariant6!);
            }
            else if (IsIngestionEventVariant7)
            {
                ingestionEventVariant7?.Invoke(IngestionEventVariant7!);
            }
            else if (IsIngestionEventVariant8)
            {
                ingestionEventVariant8?.Invoke(IngestionEventVariant8!);
            }
            else if (IsIngestionEventVariant9)
            {
                ingestionEventVariant9?.Invoke(IngestionEventVariant9!);
            }
            else if (IsIngestionEventVariant10)
            {
                ingestionEventVariant10?.Invoke(IngestionEventVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?>? ingestionEventVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?>? ingestionEventVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?>? ingestionEventVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?>? ingestionEventVariant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?>? ingestionEventVariant5 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?>? ingestionEventVariant6 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?>? ingestionEventVariant7 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?>? ingestionEventVariant8 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?>? ingestionEventVariant9 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?>? ingestionEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestionEventVariant1)
            {
                ingestionEventVariant1?.Invoke(IngestionEventVariant1!);
            }
            else if (IsIngestionEventVariant2)
            {
                ingestionEventVariant2?.Invoke(IngestionEventVariant2!);
            }
            else if (IsIngestionEventVariant3)
            {
                ingestionEventVariant3?.Invoke(IngestionEventVariant3!);
            }
            else if (IsIngestionEventVariant4)
            {
                ingestionEventVariant4?.Invoke(IngestionEventVariant4!);
            }
            else if (IsIngestionEventVariant5)
            {
                ingestionEventVariant5?.Invoke(IngestionEventVariant5!);
            }
            else if (IsIngestionEventVariant6)
            {
                ingestionEventVariant6?.Invoke(IngestionEventVariant6!);
            }
            else if (IsIngestionEventVariant7)
            {
                ingestionEventVariant7?.Invoke(IngestionEventVariant7!);
            }
            else if (IsIngestionEventVariant8)
            {
                ingestionEventVariant8?.Invoke(IngestionEventVariant8!);
            }
            else if (IsIngestionEventVariant9)
            {
                ingestionEventVariant9?.Invoke(IngestionEventVariant9!);
            }
            else if (IsIngestionEventVariant10)
            {
                ingestionEventVariant10?.Invoke(IngestionEventVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IngestionEventVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>),
                IngestionEventVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>),
                IngestionEventVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>),
                IngestionEventVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>),
                IngestionEventVariant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>),
                IngestionEventVariant6,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>),
                IngestionEventVariant7,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>),
                IngestionEventVariant8,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>),
                IngestionEventVariant9,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>),
                IngestionEventVariant10,
                typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>?>.Default.Equals(IngestionEventVariant1, other.IngestionEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>?>.Default.Equals(IngestionEventVariant2, other.IngestionEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>?>.Default.Equals(IngestionEventVariant3, other.IngestionEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>?>.Default.Equals(IngestionEventVariant4, other.IngestionEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>?>.Default.Equals(IngestionEventVariant5, other.IngestionEventVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>?>.Default.Equals(IngestionEventVariant6, other.IngestionEventVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>?>.Default.Equals(IngestionEventVariant7, other.IngestionEventVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>?>.Default.Equals(IngestionEventVariant8, other.IngestionEventVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>?>.Default.Equals(IngestionEventVariant9, other.IngestionEventVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>?>.Default.Equals(IngestionEventVariant10, other.IngestionEventVariant10) 
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
