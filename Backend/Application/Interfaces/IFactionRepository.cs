using Domain;

namespace Application.Interfaces;

public interface IFactionRepository
{
    public Faction GetFactionById(int id);
}