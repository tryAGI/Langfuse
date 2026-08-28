
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// **Deprecated:** Legacy Langfuse object kind used by trace and dataset evaluation rules.
    /// </summary>
    public enum LegacyEvaluationObject
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Chain,
        /// <summary>
        ///
        /// </summary>
        DatasetItem,
        /// <summary>
        ///
        /// </summary>
        Embedding,
        /// <summary>
        ///
        /// </summary>
        Evaluator,
        /// <summary>
        ///
        /// </summary>
        Event,
        /// <summary>
        ///
        /// </summary>
        Generation,
        /// <summary>
        ///
        /// </summary>
        Guardrail,
        /// <summary>
        ///
        /// </summary>
        Retriever,
        /// <summary>
        ///
        /// </summary>
        Span,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        /// ** Legacy Langfuse object kind used by trace and dataset evaluation rules.
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyEvaluationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyEvaluationObject value)
        {
            return value switch
            {
                LegacyEvaluationObject.Agent => "agent",
                LegacyEvaluationObject.Chain => "chain",
                LegacyEvaluationObject.DatasetItem => "dataset_item",
                LegacyEvaluationObject.Embedding => "embedding",
                LegacyEvaluationObject.Evaluator => "evaluator",
                LegacyEvaluationObject.Event => "event",
                LegacyEvaluationObject.Generation => "generation",
                LegacyEvaluationObject.Guardrail => "guardrail",
                LegacyEvaluationObject.Retriever => "retriever",
                LegacyEvaluationObject.Span => "span",
                LegacyEvaluationObject.Tool => "tool",
                LegacyEvaluationObject.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyEvaluationObject? ToEnum(string value)
        {
            return value switch
            {
                "agent" => LegacyEvaluationObject.Agent,
                "chain" => LegacyEvaluationObject.Chain,
                "dataset_item" => LegacyEvaluationObject.DatasetItem,
                "embedding" => LegacyEvaluationObject.Embedding,
                "evaluator" => LegacyEvaluationObject.Evaluator,
                "event" => LegacyEvaluationObject.Event,
                "generation" => LegacyEvaluationObject.Generation,
                "guardrail" => LegacyEvaluationObject.Guardrail,
                "retriever" => LegacyEvaluationObject.Retriever,
                "span" => LegacyEvaluationObject.Span,
                "tool" => LegacyEvaluationObject.Tool,
                "trace" => LegacyEvaluationObject.Trace,
                _ => null,
            };
        }
    }
}