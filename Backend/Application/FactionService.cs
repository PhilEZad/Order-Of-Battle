using Application.Interfaces;
using Domain;

namespace Application;

public class FactionService : IFactionService
{
    private IFactionRepository _factionRepository;
    
    public FactionService(IFactionRepository factionRepository)
    {
        _factionRepository = factionRepository;
    }

    public Faction ReadFaction(int id)
    {
        throw new NotImplementedException();
    }
}