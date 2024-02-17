namespace EvolutionaryArchitecture.Fitnet.Contracts;

using PrepareContract;
using SignContract;

internal static class ContractsEndpoints
{
    internal static void MapContracts(this IEndpointRouteBuilder app)
    {
        app.MapPrepareContract();
        app.MapSignContract();
    }
}
