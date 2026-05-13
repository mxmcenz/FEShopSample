using FastEndpoints;

namespace FEShop.Application.Features.Products.Commands.Delete;

public class DeleteProductCommand : ICommand<bool>
{
    public int Id { get; init; }
}