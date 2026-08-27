
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableLegacyEvaluationObject
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
        ///
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableLegacyEvaluationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableLegacyEvaluationObject value)
        {
            return value switch
            {
                UnstableLegacyEvaluationObject.Agent => "agent",
                UnstableLegacyEvaluationObject.Chain => "chain",
                UnstableLegacyEvaluationObject.DatasetItem => "dataset_item",
                UnstableLegacyEvaluationObject.Embedding => "embedding",
                UnstableLegacyEvaluationObject.Evaluator => "evaluator",
                UnstableLegacyEvaluationObject.Event => "event",
                UnstableLegacyEvaluationObject.Generation => "generation",
                UnstableLegacyEvaluationObject.Guardrail => "guardrail",
                UnstableLegacyEvaluationObject.Retriever => "retriever",
                UnstableLegacyEvaluationObject.Span => "span",
                UnstableLegacyEvaluationObject.Tool => "tool",
                UnstableLegacyEvaluationObject.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableLegacyEvaluationObject? ToEnum(string value)
        {
            return value switch
            {
                "agent" => UnstableLegacyEvaluationObject.Agent,
                "chain" => UnstableLegacyEvaluationObject.Chain,
                "dataset_item" => UnstableLegacyEvaluationObject.DatasetItem,
                "embedding" => UnstableLegacyEvaluationObject.Embedding,
                "evaluator" => UnstableLegacyEvaluationObject.Evaluator,
                "event" => UnstableLegacyEvaluationObject.Event,
                "generation" => UnstableLegacyEvaluationObject.Generation,
                "guardrail" => UnstableLegacyEvaluationObject.Guardrail,
                "retriever" => UnstableLegacyEvaluationObject.Retriever,
                "span" => UnstableLegacyEvaluationObject.Span,
                "tool" => UnstableLegacyEvaluationObject.Tool,
                "trace" => UnstableLegacyEvaluationObject.Trace,
                _ => null,
            };
        }
    }
}