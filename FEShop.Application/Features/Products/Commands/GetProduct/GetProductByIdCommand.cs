using FastEndpoints;
using FEShop.Domain.Entities;

namespace FEShop.Application.Features.Products.Commands.GetProduct;

public class GetProductByIdCommand : ICommand<Product?>
{
    public int Id { get; set; }
}