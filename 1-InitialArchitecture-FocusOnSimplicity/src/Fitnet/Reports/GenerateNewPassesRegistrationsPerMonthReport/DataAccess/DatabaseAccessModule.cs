namespace EvolutionaryArchitecture.Fitnet.Reports.GenerateNewPassesRegistrationsPerMonthReport.DataAccess;

internal static class DatabaseAccessModule
{
    internal static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddSingleton<IDatabaseConnectionFactory, DatabaseConnectionFactory>();

        return services;
    }
}
