using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.Create;

public class CreateProductHandler(IProductRepository productRepository) : ICommandHandler<CreateProductCommand, int>
{
    public async Task<int> ExecuteAsync(CreateProductCommand command, CancellationToken ct)
    {
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price,
            CreatedAt = DateTime.UtcNow
        };

        var id = await productRepository.CreateAsync(product, ct);

        return id;
    }
}