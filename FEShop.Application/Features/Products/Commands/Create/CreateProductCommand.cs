using FastEndpoints;

namespace FEShop.Application.Features.Products.Commands.Create;

public class CreateProductCommand : ICommand<int>
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public decimal Price { get; init; }
}