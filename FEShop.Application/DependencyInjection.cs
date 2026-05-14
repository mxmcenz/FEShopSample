using FastEndpoints;
using FEShop.Application.Features.Products.Commands.Create;
using FEShop.Application.Features.Products.Commands.Delete;
using FEShop.Application.Features.Products.Commands.Get;
using FEShop.Application.Features.Products.Commands.GetAll;
using FEShop.Application.Features.Products.Commands.Update;
using FEShop.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FEShop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<CreateProductCommand, int>, CreateProductHandler>();
        services.AddScoped<ICommandHandler<GetProductByIdCommand, Product?>, GetProductByIdHandler>();
        services.AddScoped<ICommandHandler<GetAllProductsCommand, IEnumerable<Product>>, GetAllProductsHandler>();
        services.AddScoped<ICommandHandler<DeleteProductCommand, bool>, DeleteProductHandler>();
        services.AddScoped<ICommandHandler<UpdateProductCommand, bool>, UpdateProductHandler>();
        
        return services;
    }
}