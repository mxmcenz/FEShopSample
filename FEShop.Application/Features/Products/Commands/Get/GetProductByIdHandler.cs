using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.Get;

public class GetProductByIdHandler(IProductRepository productRepository)
    : ICommandHandler<GetProductByIdCommand, Product?>
{
    public async Task<Product?> ExecuteAsync(GetProductByIdCommand command, CancellationToken ct) => 
        await productRepository.GetByIdAsync(command.Id, ct);
}