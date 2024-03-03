namespace EvolutionaryArchitecture.Fitnet.Reports.GenerateNewPassesRegistrationsPerMonthReport.DataAccess;

using System.Data;

internal interface IDatabaseConnectionFactory : IDisposable
{
    IDbConnection Create();
}
