namespace EvolutionaryArchitecture.Fitnet.Common.IntegrationTests.TestEngine.Database;
using System.Collections.Generic;

public interface IDatabaseConfiguration
{
    public Dictionary<string, string?> Get();
}
