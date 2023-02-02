using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class FactionController
{
    private readonly IFactionService _factionService;

    public FactionController(IFactionService factionService)
    {
        _factionService = factionService ?? throw new NullReferenceException("Faction Service can not be null.");
    }

    [HttpGet]
    public List<Faction> GetAllFactions()
    {
        return _factionService.GetAllFactions();
    }

    [HttpGet]
    [Route("{id}")]
    public Faction GetFactionById([FromRoute] int id)
    {
        return _factionService.ReadFaction(id);
    }
}