namespace EvolutionaryArchitecture.Fitnet.Common.Infrastructure;

using Events.EventBus;

public static class CommonInfrastructureModule
{
    public static IServiceCollection AddCommonInfrastructure(this IServiceCollection services)
    {
        services.AddEventBus();
        services.AddFeatureManagement();

        return services;
    }
}
