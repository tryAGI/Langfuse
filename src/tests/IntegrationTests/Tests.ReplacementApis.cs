namespace Langfuse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public Task ReplacementApiContracts() => Contracts.ReplacementApiContract.RunAsync();
}
