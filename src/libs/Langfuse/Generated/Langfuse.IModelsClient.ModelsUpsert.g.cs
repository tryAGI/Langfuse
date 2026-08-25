#nullable enable

namespace Langfuse
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create or replace a project-owned model using its id. Built-in models cannot be modified.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Model> ModelsUpsertAsync(
            string id,

            global::Langfuse.CreateModelRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a project-owned model using its id. Built-in models cannot be modified.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.Model>> ModelsUpsertAsResponseAsync(
            string id,

            global::Langfuse.CreateModelRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a project-owned model using its id. Built-in models cannot be modified.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modelName">
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </param>
        /// <param name="matchPattern">
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </param>
        /// <param name="startDate">
        /// Apply only to generations which are newer than this ISO date.
        /// </param>
        /// <param name="unit">
        /// Unit of usage in Langfuse
        /// </param>
        /// <param name="inputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per input unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="outputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per output unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="totalPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per total units. Cannot be set if input or output price is set. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="pricingTiers">
        /// Optional. Array of pricing tiers for this model.<br/>
        /// Use pricing tiers for all models - both those with threshold-based pricing variations and those with simple flat pricing:<br/>
        /// - For models with standard flat pricing: Create a single default tier with your prices<br/>
        ///   (e.g., one tier with isDefault=true, priority=0, conditions=[], and your standard prices)<br/>
        /// - For models with threshold-based pricing: Create a default tier plus additional conditional tiers<br/>
        ///   (e.g., default tier for standard usage + high-volume tier for usage above certain thresholds)<br/>
        /// Requirements:<br/>
        /// - Cannot be provided with flat prices (inputPrice/outputPrice/totalPrice) - use one approach or the other<br/>
        /// - Must include exactly one default tier with isDefault=true, priority=0, and conditions=[]<br/>
        /// - All tier names and priorities must be unique within the model<br/>
        /// - Each tier must define at least one price<br/>
        /// If omitted, you must provide flat prices instead (inputPrice/outputPrice/totalPrice),<br/>
        /// which will automatically create a single default tier named "Standard".
        /// </param>
        /// <param name="tokenizerId">
        /// Tokenizer supported by Langfuse for model usage inference.
        /// </param>
        /// <param name="tokenizerConfig">
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Model> ModelsUpsertAsync(
            string id,
            string modelName,
            string matchPattern,
            global::Langfuse.ModelUsageUnit unit,
            global::System.DateTime? startDate = default,
            double? inputPrice = default,
            double? outputPrice = default,
            double? totalPrice = default,
            global::System.Collections.Generic.IList<global::Langfuse.PricingTierInput>? pricingTiers = default,
            global::Langfuse.ModelTokenizerId? tokenizerId = default,
            object? tokenizerConfig = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}