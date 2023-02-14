using Application.Interfaces;
using Domain;

namespace Application;

public class StratagemService : IStratagemService
{
    private readonly IStratagemRepository _stratagemRepository;
    
    public StratagemService(IStratagemRepository stratagemRepository)
    {
        _stratagemRepository = stratagemRepository ?? throw new NullReferenceException("IStratagemService cannot be null.");;
    }

    public List<Stratagem> GetAllStratagems()
    {
        return _stratagemRepository.GetAllStratagems();
    }
}