using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class DatabaseController
{
    private readonly DatabaseRepository _databaseRepository;
    
    public DatabaseController(DatabaseRepository databaseRepository)
    {
        _databaseRepository = databaseRepository ?? throw new NullReferenceException("DatabaseRepository can not be empty.");
    }

    [HttpGet]
    public void buildDB()
    {
        _databaseRepository.buildDB();
    }

}