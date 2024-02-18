namespace EvolutionaryArchitecture.Fitnet.ArchitectureTests.Common.Predicates;
using System.Linq;
using NetArchTest.Rules;

internal static class PredicatesExtensions
{
    internal static string[] GetModuleTypes(this PredicateList predicates) =>
        predicates
            .GetTypes()
            .Select(type => type.FullName)
            .Distinct()
            .ToArray()!;
}
