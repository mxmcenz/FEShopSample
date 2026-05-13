using FastEndpoints;
using FEShop.Application.Features.Products.Commands.Delete;

namespace FEShop.WebApi.Features.Products.Delete;

public class Endpoint : Endpoint<Request>
{
    public override void Configure()
    {
        Delete("/products/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var deleted = await new DeleteProductCommand { Id = req.Id }.ExecuteAsync(ct);

        if (!deleted)
        {
            await Send.NotFoundAsync(ct);
            return;
        }

        await Send.NoContentAsync(ct);
    }
}