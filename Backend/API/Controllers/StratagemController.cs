using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class StratagemController
{
    private readonly IStratagemService _stratagemService;

    public StratagemController(IStratagemService stratagemService)
    {
        _stratagemService = stratagemService ?? throw new NullReferenceException("Stratagem Service can not be null.");
    }
    
    [HttpGet]
    public List<Stratagem> GetAllStratagems()
    {
        return _stratagemService.GetAllStratagems();
    }   
}