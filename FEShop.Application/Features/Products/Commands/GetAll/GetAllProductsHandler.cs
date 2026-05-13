using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.GetAll;

public class GetAllProductsHandler(IProductRepository productRepository)
    : ICommandHandler<GetAllProductsCommand, IEnumerable<Product>>
{
    public async Task<IEnumerable<Product>> ExecuteAsync(GetAllProductsCommand command, CancellationToken ct) => 
        await productRepository.GetAllAsync(ct);
}