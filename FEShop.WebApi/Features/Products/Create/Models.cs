namespace FEShop.WebApi.Features.Products.Create;

public sealed record Request
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public decimal Price { get; init; }
}

public sealed record Response
{
    public int Id { get; init; }
    public string Message { get; init; } = string.Empty;
}