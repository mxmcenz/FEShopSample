using FastEndpoints;
using FastEndpoints.Swagger;
using FEShop.Application;
using FEShop.Infrastructure;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints().SwaggerDocument();
bld.Services.AddInfrastructure();
bld.Services.AddApplication();

var app = bld.Build();
app.UseFastEndpoints();
if (app.Environment.IsDevelopment()) 
    app.UseSwaggerGen();

app.Run();