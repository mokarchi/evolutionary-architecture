namespace EvolutionaryArchitecture.Fitnet.ArchitectureTests.Common;
using System.Reflection;
using NetArchTest.Rules;

internal static class Solution
{
    private static readonly Assembly Program = typeof(Program).Assembly;
    internal static Types Types => Types.InAssembly(Program);
}
