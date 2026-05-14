using FastEndpoints;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.Update;

public class UpdateProductHandler(IProductRepository productRepository) : ICommandHandler<UpdateProductCommand, bool>
{
    public async Task<bool> ExecuteAsync(UpdateProductCommand command, CancellationToken ct) => 
        await productRepository.UpdateAsync(command.Id, command.Name, command.Description, command.Price, ct);
}