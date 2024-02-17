using EvolutionaryArchitecture.Fitnet.Common.ErrorHandling;
using EvolutionaryArchitecture.Fitnet.Common.Validation.Requests;
using EvolutionaryArchitecture.Fitnet.Contracts;
using EvolutionaryArchitecture.Fitnet.Offers;
using EvolutionaryArchitecture.Fitnet.Passes;
using JetBrains.Annotations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();
builder.Services.AddRequestsValidations();

builder.Services.AddPasses(builder.Configuration);
builder.Services.AddContracts(builder.Configuration);
builder.Services.AddOffers(builder.Configuration);

var app = builder.Build();

app.UseErrorHandling();

app.UsePasses();
app.UseContracts();
app.UseOffers();

app.MapPasses();
app.MapContracts();

namespace EvolutionaryArchitecture.Fitnet
{
    [UsedImplicitly]
    public sealed class Program;
}
