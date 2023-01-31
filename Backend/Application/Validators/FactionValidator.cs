using Domain;
using FluentValidation;

namespace Application.Validators;

public class FactionValidator : AbstractValidator<Faction>
{
    public FactionValidator()
    {
        RuleFor(x => x.factionId).GreaterThan(0).WithMessage("Faction ID must be greater than 0.");
    }
}