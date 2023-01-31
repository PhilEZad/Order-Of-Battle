using Domain;

namespace Application.Interfaces;

public interface IFactionService
{
    public Faction ReadFaction(int id);
}