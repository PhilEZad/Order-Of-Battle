using Application.Interfaces;
using Application.Validators;
using Domain;
using FluentValidation;

namespace Application;

public class FactionService : IFactionService
{
    private readonly IFactionRepository _factionRepository;
    private readonly FactionValidator _factionValidator;

    public FactionService(IFactionRepository factionRepository, FactionValidator factionValidator)
    {
        _factionRepository = factionRepository ?? throw new NullReferenceException("IFactionRepository cannot be null.");
        _factionValidator = factionValidator ?? throw new NullReferenceException("FactionValidator cannot be null.");
    }
    
    public List<Faction> GetAllFactions()
    {
        List<Faction> factionList = _factionRepository.GetAllFactions();

        if (factionList == null || factionList.Count == 0)
        {
            throw new NullReferenceException("Unable to fetch factions.");
        }

        return factionList;
    }
    
    public Faction ReadFaction(int id)
    {
        if (id <= 0)
        {
            throw new ValidationException( "Faction ID must be greater than 0.");
        }

        Faction faction = _factionRepository.GetFactionById(id);
        
        if (faction == null)
        {
            throw new NullReferenceException("Faction does not exist.");
        }

        return faction;
    }

    public Faction UpdateFaction(Faction faction)
    {
        if (faction == null)
        {
            throw new NullReferenceException("Faction cannot be null.");
        }

        var validation = _factionValidator.Validate(faction);
        
        if (!validation.IsValid)
        {
            throw new ValidationException(validation.ToString());
        }

        return _factionRepository.UpdateFaction(faction);
    }
}