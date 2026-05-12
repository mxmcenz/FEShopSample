using FastEndpoints;
using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Application.Features.Products.Commands.CreateProduct;

public class CreateProductHandler : ICommandHandler<CreateProductCommand, int>
{
    private readonly IProductRepository _productRepository;

    public CreateProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<int> ExecuteAsync(CreateProductCommand command, CancellationToken ct)
    {
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price,
            CreatedAt = DateTime.UtcNow
        };

        var id = await _productRepository.CreateAsync(product, ct);

        return id;
    }
}