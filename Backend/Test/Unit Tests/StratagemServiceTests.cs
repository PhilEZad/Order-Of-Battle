using Application;
using FluentAssertions;

namespace Test;

public class StratagemServiceTests
{
    [Fact]
    public void StratagemService_WithNullStratagemRepository_ThrowsNullExceptionWithMessage()
    {
        Action test = () => new StratagemService(null);

        test.Should().Throw<NullReferenceException>().WithMessage("IStratagemService cannot be null.");
    }
}
    