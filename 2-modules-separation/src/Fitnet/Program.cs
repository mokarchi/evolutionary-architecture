﻿var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();

namespace EvolutionaryArchitecture.Fitnet
{
    using JetBrains.Annotations;

    [UsedImplicitly]
    public sealed class Program;
}
