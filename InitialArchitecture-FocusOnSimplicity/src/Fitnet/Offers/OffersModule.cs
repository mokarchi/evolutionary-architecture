﻿namespace EvolutionaryArchitecture.Fitnet.Offers;

using Data.Database;
using Microsoft.AspNetCore.Builder;

internal static class OffersModule
{
    internal static IServiceCollection AddOffers(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);

        return services;
    }

    internal static IApplicationBuilder UseOffers(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseDatabase();

        return applicationBuilder;
    }
}
