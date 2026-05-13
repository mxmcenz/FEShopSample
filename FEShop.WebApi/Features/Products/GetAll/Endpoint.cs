using FastEndpoints;
using FEShop.Application.Features.Products.Commands.GetAllProducts;

namespace FEShop.WebApi.Features.Products.GetAll;

public class Endpoint : EndpointWithoutRequest<List<Response>>
{
    public override void Configure()
    {
        Get("/products");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var products = await new GetAllProductsCommand().ExecuteAsync(ct);
        var response = products.Select(p => new Response(p.Id, p.Name, p.Description, p.Price, p.CreatedAt)).ToList();
        
        await Send.OkAsync(response, ct);
    }
}