namespace Application;

public class StratagemService : IStratagemService
{
    private readonly IStratagemService _stratagemService;
    
    public StratagemService(IStratagemService stratagemService)
    {
        _stratagemService = stratagemService ?? throw new NullReferenceException("IStratagemService cannot be null.");;
    }
}