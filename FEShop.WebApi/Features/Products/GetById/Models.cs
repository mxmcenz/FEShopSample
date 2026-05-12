namespace FEShop.WebApi.Features.Products.GetById;

public sealed record Request
{
    public int Id { get; init; }
}

public sealed record Response
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public DateTime CreatedAt { get; init; }
}

