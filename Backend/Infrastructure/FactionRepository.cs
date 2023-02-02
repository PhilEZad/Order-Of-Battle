using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class FactionRepository : IFactionRepository
{
    private readonly DatabaseContext _context;
    
    public FactionRepository(DatabaseContext context)
    {
        _context = context ?? throw new NullReferenceException("DatabaseContext can not be null.");;
    }
    
    public List<Faction> GetAllFactions()
    {
        return _context.FactionsTable.ToList();
    }
    public Faction GetFactionById(int id)
    {
        return _context.FactionsTable.Find(id);
    }
}