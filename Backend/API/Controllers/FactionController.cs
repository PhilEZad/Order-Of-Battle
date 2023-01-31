using Application;
using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class FactionController
{
    private readonly IFactionService _factionService;
    
    public FactionController(FactionService factionService)
    {
        _factionService = factionService ?? throw new NullReferenceException("Faction Service can not be null.");
    }

    [HttpGet]
    [Route("id")]
    public Faction GetFactionById(int id)
    {
        return _factionService.ReadFaction(id);
    }
}