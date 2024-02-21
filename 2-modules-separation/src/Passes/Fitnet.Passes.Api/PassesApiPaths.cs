namespace EvolutionaryArchitecture.Fitnet.Passes.Api;

using EvolutionaryArchitecture.Fitnet.Common.Api;

internal static class PassesApiPaths
{
    internal const string GetAll = $"{ApiPaths.Root}/passes";
    internal const string MarkPassAsExpired = $"{ApiPaths.Root}/passes/{{id}}";
}