
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The ingestion object type that should trigger evaluation runs.<br/>
    /// Choose the target first, because it changes both the valid filter columns and the valid variable-mapping sources:<br/>
    /// - `observation` evaluates live-ingested observations such as generations, spans, and events.<br/>
    ///   It supports mapping from `input`, `output`, and `metadata`.<br/>
    /// - `experiment` evaluates live experiment executions and can additionally map `expected_output` and `experiment_item_metadata`.<br/>
    ///   It currently supports filtering by `datasetId`.<br/>
    ///   Discover valid dataset IDs with `GET /api/public/v2/datasets`, then use the returned dataset `id` values in your filter.
    /// </summary>
    public enum UnstableEvaluationRuleTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Observation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleTarget value)
        {
            return value switch
            {
                UnstableEvaluationRuleTarget.Experiment => "experiment",
                UnstableEvaluationRuleTarget.Observation => "observation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleTarget? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => UnstableEvaluationRuleTarget.Experiment,
                "observation" => UnstableEvaluationRuleTarget.Observation,
                _ => null,
            };
        }
    }
}