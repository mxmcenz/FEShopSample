using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.GetAllProducts;

public class GetAllProductsHandler : ICommandHandler<GetAllProductsCommand, IEnumerable<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductsHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> ExecuteAsync(GetAllProductsCommand command, CancellationToken ct)
    {
        return await _productRepository.GetAllAsync(ct);
    }
}