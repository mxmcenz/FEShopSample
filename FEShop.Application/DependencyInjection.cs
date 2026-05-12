using FastEndpoints;
using FEShop.Application.Features.Products.Commands.CreateProduct;
using Microsoft.Extensions.DependencyInjection;

namespace FEShop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<CreateProductCommand, int>, CreateProductHandler>();

        return services;
    }
}