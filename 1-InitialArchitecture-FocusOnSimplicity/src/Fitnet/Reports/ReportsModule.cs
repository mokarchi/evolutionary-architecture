namespace EvolutionaryArchitecture.Fitnet.Reports;

using GenerateNewPassesRegistrationsPerMonthReport;
using GenerateNewPassesRegistrationsPerMonthReport.DataAccess;

internal static class ReportsModule
{
    internal static IServiceCollection AddReports(this IServiceCollection services)
    {
        services.AddDataAccess();
        services.AddNewPassesRegistrationsPerMonthReport();

        return services;
    }

    internal static IApplicationBuilder UseReports(this IApplicationBuilder applicationBuilder) =>
        applicationBuilder;
}
