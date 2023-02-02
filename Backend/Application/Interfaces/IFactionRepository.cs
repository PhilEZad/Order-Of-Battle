using Domain;

namespace Application.Interfaces;

public interface IFactionRepository
{
    public List<Faction> GetAllFactions();
    public Faction GetFactionById(int id);
}