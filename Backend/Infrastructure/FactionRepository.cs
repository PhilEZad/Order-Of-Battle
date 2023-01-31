using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class FactionRepository : IFactionRepository
{
    private readonly DatabaseContext _context;
    
    public FactionRepository(DatabaseContext context)
    {
        _context = context ?? throw new NullReferenceException("DatbaseContext can not be null.");;
    }
    public Faction GetFactionById(int id)
    {
        return _context.FactionsTable.Find(id);
    }
}