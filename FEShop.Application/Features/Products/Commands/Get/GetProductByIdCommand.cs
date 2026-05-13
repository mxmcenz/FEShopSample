using FastEndpoints;
using FEShop.Domain.Entities;

namespace FEShop.Application.Features.Products.Commands.Get;

public class GetProductByIdCommand : ICommand<Product?>
{
    public int Id { get; init; }
}