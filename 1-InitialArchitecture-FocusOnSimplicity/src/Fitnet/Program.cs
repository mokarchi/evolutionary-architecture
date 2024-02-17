﻿using EvolutionaryArchitecture.Fitnet.Common.ErrorHandling;
using EvolutionaryArchitecture.Fitnet.Offers;
using EvolutionaryArchitecture.Fitnet.Passes;
using JetBrains.Annotations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();
builder.Services.AddOffers(builder.Configuration);
builder.Services.AddPasses(builder.Configuration);

var app = builder.Build();

app.UseErrorHandling();
app.MapPasses();
app.UseOffers();


namespace EvolutionaryArchitecture.Fitnet
{
    [UsedImplicitly]
    public sealed class Program;
}
