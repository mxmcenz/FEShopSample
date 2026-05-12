using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.GetProduct;

public class GetProductByIdHandler : ICommandHandler<GetProductByIdCommand, Product?>
{
    private readonly IProductRepository _productRepository;

    public GetProductByIdHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product?> ExecuteAsync(GetProductByIdCommand command, CancellationToken ct)
    {
        return await _productRepository.GetByIdAsync(command.Id, ct);
    }
}