using Application;
using Application.Interfaces;
using Application.Validators;
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
        FactionValidator factionValidator = new Mock<FactionValidator>().Object;

        Action test = () => new FactionService(null, factionValidator);

        test.Should().Throw<NullReferenceException>().WithMessage("IFactionRepository cannot be null.");
    }
    
    [Fact]
    public void CreateFactionServiceOfTypeFactionValidator_WithFactionValidationAsNull_ThrowsNullExceptionWithMessage()
    {
        IFactionRepository factionRepository = new Mock<IFactionRepository>().Object;
        
        Action test = () => new FactionService(factionRepository, null);

        test.Should().Throw<NullReferenceException>().WithMessage("FactionValidator cannot be null.");
    }
    
    [Fact]
    public void ReadFaction_ReturningFactionAsNull_ShouldThrowNullExceptionWithMessage()
    {
        var factionRepository = new Mock<IFactionRepository>();
        FactionValidator factionValidator = new Mock<FactionValidator>().Object;
        IFactionService factionService = new FactionService(factionRepository.Object, factionValidator);

        factionRepository.Setup(x => x.GetFactionById(It.IsAny<int>())).Returns((Faction)null);
        
        Action test = () => factionService.ReadFaction(1);

        test.Should().Throw<NullReferenceException>().WithMessage("Faction does not exist.");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void ReadFaction_WithInvalidID_ShouldArgumentOutOfRangeExceptionWithMessage(int id)
    {
        var factionRepository = new Mock<IFactionRepository>().Object;
        FactionValidator factionValidator = new Mock<FactionValidator>().Object;
        var factionService = new FactionService(factionRepository, factionValidator);

        Action test = () => factionService.ReadFaction(id);
        
        test.Should().Throw<ValidationException>().WithMessage("Faction ID must be greater than 0.");
    }
}