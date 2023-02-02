using Application.DTOs.Request;
using Domain;

namespace Application.Interfaces;

public interface IFactionService
{
    public Faction ReadFaction(int id);

    public List<Faction> GetAllFactions();
}