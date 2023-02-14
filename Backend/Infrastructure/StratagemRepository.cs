using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class StratagemRepository : IStratagemRepository
{
    private readonly DatabaseContext _context;
    
    public StratagemRepository(DatabaseContext context)
    {
        _context = context ?? throw new NullReferenceException("DatabaseContext can not be null.");;
    }

    public List<Stratagem> GetAllStratagems()
    {
        return _context.StratagemsTable.ToList();
    }
}