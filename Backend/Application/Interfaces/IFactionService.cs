using Application.DTOs.Request;
using Domain;

namespace Application.Interfaces;

public interface IFactionService
{
    public Faction CreateFaction(FactionRequest faction);
    public Faction ReadFaction(int id);
}