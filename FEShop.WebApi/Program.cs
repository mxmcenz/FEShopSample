using FastEndpoints;
using FastEndpoints.Swagger;
using FEShop.Application;
using FEShop.Infrastructure;
using FEShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints().SwaggerDocument();
bld.Services.AddInfrastructure(bld.Configuration);
bld.Services.AddApplication();

var app = bld.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FEShopDbContext>();
    context.Database.Migrate();
}
app.UseFastEndpoints();
if (app.Environment.IsDevelopment()) 
    app.UseSwaggerGen();

app.Run();