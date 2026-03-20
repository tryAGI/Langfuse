#nullable enable

namespace Langfuse
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Dataset> DatasetsCreateAsync(

            global::Langfuse.CreateDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="inputSchema">
        /// JSON Schema for validating dataset item inputs. When set, all new and existing dataset items will be validated against this schema.
        /// </param>
        /// <param name="expectedOutputSchema">
        /// JSON Schema for validating dataset item expected outputs. When set, all new and existing dataset items will be validated against this schema.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Dataset> DatasetsCreateAsync(
            string name,
            string? description = default,
            object? metadata = default,
            object? inputSchema = default,
            object? expectedOutputSchema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}