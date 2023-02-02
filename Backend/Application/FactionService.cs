using Application.DTOs.Request;
using Application.Interfaces;
using Domain;
using FluentValidation;

namespace Application;

public class FactionService : IFactionService
{
    private readonly IFactionRepository _factionRepository;

    public FactionService(IFactionRepository factionRepository)
    {
        _factionRepository = factionRepository ?? throw new NullReferenceException("IFactionRepository cannot be null.");
    }
    
    public List<Faction> GetAllFactions()
    {
        throw new NotImplementedException();
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
}