using Application;
using Application.Interfaces;
using Domain;
using FluentAssertions;
using FluentValidation;
using Moq;

namespace Test;

public class FactionServiceTests
{
    [Fact]
    public void CreateFactionServiceOfTypeIFactionRepository_WithIFactoryRepositoryAsNull_ThrowsNullExceptionWithMessage()
    {
        Action test = () => new FactionService(null);

        test.Should().Throw<NullReferenceException>().WithMessage("IFactionRepository cannot be null.");
    }

    [Fact]
    public void ReadFaction_ReturningFactionAsNull_ShouldThrowNullExceptionWithMessage()
    {
        var factionRepository = new Mock<IFactionRepository>();
        IFactionService factionService = new FactionService(factionRepository.Object);

        factionRepository.Setup(x => x.GetFactionById(It.IsAny<int>())).Returns((Faction)null);
        
        Action test = () => factionService.ReadFaction(1);

        test.Should().Throw<NullReferenceException>().WithMessage("Faction does not exist.");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void ReadFaction_WithInvalidID_ShouldArgumentOutOfRangeExceptionWithMessage(int id)
    {
        IFactionRepository factionRepository = new Mock<IFactionRepository>().Object;
        FactionService factionService = new FactionService(factionRepository);

        Action test = () => factionService.ReadFaction(id);
        
        test.Should().Throw<ValidationException>().WithMessage("Faction ID must be greater than 0.");
    }
}