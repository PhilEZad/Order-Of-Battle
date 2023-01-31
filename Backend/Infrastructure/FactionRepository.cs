using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class FactionRepository : IFactionRepository
{
    private readonly DatabaseContext _context;
    
    public FactionRepository(DatabaseContext context)
    {
        if (context == null)
            throw new ArgumentNullException("DatbaseContext can not be null");
        
        _context = context;
    }
    public Faction GetFactionById(int id)
    {
        return _context.FactionsTable.Find(id);
    }
}