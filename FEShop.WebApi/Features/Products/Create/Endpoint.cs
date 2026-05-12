using FastEndpoints;
using FEShop.Application.Features.Products.Commands.CreateProduct;

namespace FEShop.WebApi.Features.Products.Create;

public class Endpoint : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Post("/products");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var command = new CreateProductCommand
        {
            Name = req.Name,
            Description = req.Description,
            Price = req.Price
        };

        int productId = await command.ExecuteAsync(ct);

        var response = new Response
        {
            Id = productId,
            Message = "Product successfully created!"
        };

        await Send.CreatedAtAsync<Endpoint>(
            routeValues: new { id = productId }, 
            responseBody: response,
            cancellation: ct);
    }
}