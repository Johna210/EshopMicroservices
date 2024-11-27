using Ordering.Api;
using Ordering.Application;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the Contaniner.
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();

//--------------
// Infrastructure - EF Core
// Application - MediatR
// API - Carter, HealthChecks, ...
//----------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
