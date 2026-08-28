
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Source field used to populate a prompt variable.<br/>
    /// Use these values when mapping evaluator prompt variables to live data.<br/>
    /// Source semantics:<br/>
    /// - `input`: the observation input payload<br/>
    /// - `output`: the observation output payload<br/>
    /// - `metadata`: the observation metadata object. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
    /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
    /// - `expected_output`: the experiment item's expected output when the observation belongs to an experiment.<br/>
    /// - `experiment_item_metadata`: the experiment item's metadata when the observation belongs to an experiment.
    /// </summary>
    public enum PromptVariableMappingSource
    {
        /// <summary>
        /// the experiment item's expected output when the observation belongs to an experiment.
        /// </summary>
        ExpectedOutput,
        /// <summary>
        /// the experiment item's metadata when the observation belongs to an experiment.
        /// </summary>
        ExperimentItemMetadata,
        /// <summary>
        /// the observation input payload
        /// </summary>
        Input,
        /// <summary>
        /// the observation metadata object. Combine with `jsonPath` when you need one nested field instead of the whole object.
        /// </summary>
        Metadata,
        /// <summary>
        /// the observation output payload
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
    public static class PromptVariableMappingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVariableMappingSource value)
        {
            return value switch
            {
                PromptVariableMappingSource.ExpectedOutput => "expected_output",
                PromptVariableMappingSource.ExperimentItemMetadata => "experiment_item_metadata",
                PromptVariableMappingSource.Input => "input",
                PromptVariableMappingSource.Metadata => "metadata",
                PromptVariableMappingSource.Output => "output",
                PromptVariableMappingSource.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVariableMappingSource? ToEnum(string value)
        {
            return value switch
            {
                "expected_output" => PromptVariableMappingSource.ExpectedOutput,
                "experiment_item_metadata" => PromptVariableMappingSource.ExperimentItemMetadata,
                "input" => PromptVariableMappingSource.Input,
                "metadata" => PromptVariableMappingSource.Metadata,
                "output" => PromptVariableMappingSource.Output,
                "tool_calls" => PromptVariableMappingSource.ToolCalls,
                _ => null,
            };
        }
    }
}