using Domain;

namespace Application.Interfaces;

public interface IStratagemRepository
{
    public List<Stratagem> GetAllStratagems();
}