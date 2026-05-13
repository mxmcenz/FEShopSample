using FastEndpoints;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.Delete;

public class DeleteProductHandler(IProductRepository productRepository) : ICommandHandler<DeleteProductCommand, bool>
{
    public async Task<bool> ExecuteAsync(DeleteProductCommand command, CancellationToken ct) => 
        await productRepository.DeleteAsync(command.Id, ct);
}