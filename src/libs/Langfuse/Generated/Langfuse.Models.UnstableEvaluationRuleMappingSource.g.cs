
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Source field used to populate a prompt variable.<br/>
    /// Use these values when mapping evaluator prompt variables to live data.<br/>
    /// Target-specific rules:<br/>
    /// - `target=observation` supports `input`, `output`, `metadata`, and `tool_calls`<br/>
    /// - `target=experiment` supports `input`, `output`, `metadata`, `tool_calls`, `expected_output`, and `experiment_item_metadata`<br/>
    /// Source semantics:<br/>
    /// - `input`: the observation or experiment input payload<br/>
    /// - `output`: the observation or experiment output payload<br/>
    /// - `metadata`: the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
    /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
    /// - `expected_output`: the experiment item's expected output. Only valid for `target=experiment`.<br/>
    /// - `experiment_item_metadata`: the experiment item's metadata object. Only valid for `target=experiment`.
    /// </summary>
    public enum UnstableEvaluationRuleMappingSource
    {
        /// <summary>
        /// the experiment item's expected output. Only valid for `target=experiment`.
        /// </summary>
        ExpectedOutput,
        /// <summary>
        /// the experiment item's metadata object. Only valid for `target=experiment`.
        /// </summary>
        ExperimentItemMetadata,
        /// <summary>
        /// the observation or experiment input payload
        /// </summary>
        Input,
        /// <summary>
        /// the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.
        /// </summary>
        Metadata,
        /// <summary>
        /// the observation or experiment output payload
        /// </summary>
        Output,
        /// <summary>
        /// the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluationRuleMappingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluationRuleMappingSource value)
        {
            return value switch
            {
                UnstableEvaluationRuleMappingSource.ExpectedOutput => "expected_output",
                UnstableEvaluationRuleMappingSource.ExperimentItemMetadata => "experiment_item_metadata",
                UnstableEvaluationRuleMappingSource.Input => "input",
                UnstableEvaluationRuleMappingSource.Metadata => "metadata",
                UnstableEvaluationRuleMappingSource.Output => "output",
                UnstableEvaluationRuleMappingSource.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluationRuleMappingSource? ToEnum(string value)
        {
            return value switch
            {
                "expected_output" => UnstableEvaluationRuleMappingSource.ExpectedOutput,
                "experiment_item_metadata" => UnstableEvaluationRuleMappingSource.ExperimentItemMetadata,
                "input" => UnstableEvaluationRuleMappingSource.Input,
                "metadata" => UnstableEvaluationRuleMappingSource.Metadata,
                "output" => UnstableEvaluationRuleMappingSource.Output,
                "tool_calls" => UnstableEvaluationRuleMappingSource.ToolCalls,
                _ => null,
            };
        }
    }
}