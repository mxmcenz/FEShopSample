using FastEndpoints;
using FEShop.Application.Features.Products.Commands.Get;

namespace FEShop.WebApi.Features.Products.GetById;

public class Endpoint : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Get("/products/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var command = new GetProductByIdCommand { Id = req.Id };
        var product = await command.ExecuteAsync(ct);
        if (product is null)
        {
            await Send.NotFoundAsync(ct);
            return;
        }

        await Send.OkAsync(
            new Response
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CreatedAt = product.CreatedAt
            }, ct);
    }
}