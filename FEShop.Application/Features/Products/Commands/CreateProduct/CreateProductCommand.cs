using FastEndpoints;

namespace FEShop.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : ICommand<int>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}