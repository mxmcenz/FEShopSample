using FastEndpoints;
using FEShop.Domain.Entities;

namespace FEShop.Application.Features.Products.Commands.GetAllProducts;

public class GetAllProductsCommand : ICommand<IEnumerable<Product>>;