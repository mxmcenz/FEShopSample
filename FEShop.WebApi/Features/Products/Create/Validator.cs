using FastEndpoints;
using FluentValidation;

namespace FEShop.WebApi.Features.Products.Create;

public class Validator : Validator<Request>
{
    public Validator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name cannot be empty")
            .MaximumLength(20)
            .WithMessage("Name length cannot be greater than 20 symbols");
        
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Description cannot be empty")
            .MaximumLength(200)
            .WithMessage("Description length cannot be greater than 200 symbols");

        RuleFor(x => x.Price)
            .NotEmpty()
            .WithMessage("Price cannot be empty")
            .GreaterThan(0)
            .WithMessage("Price has to be greater than zero");
    }
}