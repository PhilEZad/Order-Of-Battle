using Application.Interfaces;

namespace Infrastructure;

public class StratagemRepository : IStratagemRepository
{
    private readonly DatabaseContext _context;
    
    public StratagemRepository(DatabaseContext context)
    {
        _context = context ?? throw new NullReferenceException("DatabaseContext can not be null.");;
    }
}