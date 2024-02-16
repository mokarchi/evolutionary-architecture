using EvolutionaryArchitecture.Fitnet.Common.ErrorHandling;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();

var app = builder.Build();

app.UseErrorHandling();
