using Infrastructure;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class DatabaseController
{
    private readonly IDatabaseRepository _databaseRepository;
    
    public DatabaseController(IDatabaseRepository databaseRepository)
    {
        _databaseRepository = databaseRepository ?? throw new NullReferenceException("DatabaseRepository can not be empty.");
    }

    [HttpGet]
    [Route("buildDB")]
    public void buildDB()
    {
        _databaseRepository.buildDB();
    }

}