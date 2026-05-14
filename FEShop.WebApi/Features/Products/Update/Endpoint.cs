using FastEndpoints;
using FEShop.Application.Features.Products.Commands.Update;

namespace FEShop.WebApi.Features.Products.Update;

public class Endpoint : Endpoint<Request>
{
    public override void Configure()
    {
        Put("/products/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var command = new UpdateProductCommand
        {
            Id = req.Id,
            Name = req.Name,
            Description = req.Description,
            Price = req.Price
        };

        var updated = await command.ExecuteAsync(ct);

        if (!updated)
        {
            await Send.NotFoundAsync(ct);
            return;
        }

        await Send.OkAsync(ct);
    }
}