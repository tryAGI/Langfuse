
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservationType
    {
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Generation,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Evaluator,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservationType value)
        {
            return value switch
            {
                ObservationType.Span => "SPAN",
                ObservationType.Generation => "GENERATION",
                ObservationType.Event => "EVENT",
                ObservationType.Agent => "AGENT",
                ObservationType.Tool => "TOOL",
                ObservationType.Chain => "CHAIN",
                ObservationType.Retriever => "RETRIEVER",
                ObservationType.Evaluator => "EVALUATOR",
                ObservationType.Embedding => "EMBEDDING",
                ObservationType.Guardrail => "GUARDRAIL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservationType? ToEnum(string value)
        {
            return value switch
            {
                "SPAN" => ObservationType.Span,
                "GENERATION" => ObservationType.Generation,
                "EVENT" => ObservationType.Event,
                "AGENT" => ObservationType.Agent,
                "TOOL" => ObservationType.Tool,
                "CHAIN" => ObservationType.Chain,
                "RETRIEVER" => ObservationType.Retriever,
                "EVALUATOR" => ObservationType.Evaluator,
                "EMBEDDING" => ObservationType.Embedding,
                "GUARDRAIL" => ObservationType.Guardrail,
                _ => null,
            };
        }
    }
}