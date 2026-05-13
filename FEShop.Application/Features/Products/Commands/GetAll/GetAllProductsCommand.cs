using FastEndpoints;
using FEShop.Domain.Entities;

namespace FEShop.Application.Features.Products.Commands.GetAll;

public class GetAllProductsCommand : ICommand<IEnumerable<Product>>;