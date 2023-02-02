using Infrastructure.Interfaces;

namespace Infrastructure;

public class DatabaseRepository : IDatabaseRepository
{
    private readonly DatabaseContext _dbContext;
    
    public DatabaseRepository(DatabaseContext databaseContext)
    {
        _dbContext = databaseContext ?? throw new NullReferenceException("DatabaseContext can not be null.");
    }

    public void buildDB()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
    }
}