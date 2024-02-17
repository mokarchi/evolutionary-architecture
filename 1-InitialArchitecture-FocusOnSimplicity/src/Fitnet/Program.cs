using EvolutionaryArchitecture.Fitnet.Common.ErrorHandling;
using EvolutionaryArchitecture.Fitnet.Offers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();
builder.Services.AddOffers(builder.Configuration);

var app = builder.Build();

app.UseErrorHandling();
app.UseOffers();
