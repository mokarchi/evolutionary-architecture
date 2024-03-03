namespace EvolutionaryArchitecture.Fitnet.Common.Infrastructure.Mediator;
using System.Reflection;

public static class MediatorModule
{
    public static IServiceCollection AddMediator(this IServiceCollection services, Assembly assembly)
    {
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

        return services;
    }
}

