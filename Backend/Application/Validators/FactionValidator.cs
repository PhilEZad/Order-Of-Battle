using Domain;
using FluentValidation;

namespace Application.Validators;

public class FactionValidator : AbstractValidator<Faction>
{
    public FactionValidator()
    {
        RuleFor(x => x.factionId).NotNull().WithMessage("Faction ID can not be null.");
        RuleFor(x => x.factionName).NotNull().WithMessage("Faction name can not be null.");
        RuleFor(x => x.factionDescription).NotNull().WithMessage("Faction description can not be null.");
        
        RuleFor(x => x.factionName).NotEmpty().WithMessage("Faction name can not be empty.");
        
    }
}