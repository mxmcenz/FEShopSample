namespace FEShop.WebApi.Features.Products.Update;

public sealed record Request(int Id, string Name, string Description, decimal Price);