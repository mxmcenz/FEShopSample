using FastEndpoints;

namespace FEShop.Application.Features.Products.Commands.Update;

public class UpdateProductCommand : ICommand<bool>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}