namespace Infrastructure;

public class DatabaseRepository
{
    private readonly DatabaseContext _dbContext;
    
    public DatabaseRepository(DatabaseContext databaseContext)
    {
        _dbContext = databaseContext ?? throw new NullReferenceException();
    }

    public void buildDB()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
    }
}