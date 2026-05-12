using FastEndpoints;
using FEShop.Application.Features.Products.Commands.CreateProduct;
using FEShop.Application.Features.Products.Commands.GetProduct;
using FEShop.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FEShop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<CreateProductCommand, int>, CreateProductHandler>();
        services.AddScoped<ICommandHandler<GetProductByIdCommand, Product?>, GetProductByIdHandler>();

        return services;
    }
}