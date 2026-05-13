namespace FEShop.WebApi.Features.Products.GetAll;

public sealed record Response(int Id, string Name, string Description, decimal Price, DateTime CreatedAt);