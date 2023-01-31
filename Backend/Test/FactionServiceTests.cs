using Application;
using Application.Interfaces;
using FluentValidation;
using Moq;
using Xunit.Sdk;

namespace Test;

public class FactionServiceTests
{
    [Fact]
    public void CreateFactionServiceOfTypeIFactionRepository_WithIFactoryRepositoryAsNull_ThrowsNullExceptionWithMessage()
    {
        Assert.Throws<NullException>(() => new FactionService(null));
    }
    
    [Fact]
    public void ReadFaction_WithObjectAsNull_ShouldThrowNullExceptionWithMessage()
    {
    }

    [Fact]
    public void ReadFaction_ReturningFactionAsNull_ShouldThrowNullExceptionWithMessage()
    {
        var factionRepository = new Mock<IFactionRepository>().Object;
        var factionService = new FactionService(factionRepository);

        Assert.Throws<NullException>(() => factionService.ReadFaction(1));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void ReadFaction_WithNegativeID_ShouldThrowValidationExceptionWithMessage(int id)
    {
        var factionRepository = new Mock<IFactionRepository>().Object;
        var factionService = new FactionService(factionRepository);

        Assert.Throws<ValidationException>(() => factionService.ReadFaction(id));
    }
}