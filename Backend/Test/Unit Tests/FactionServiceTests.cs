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

    [Fact]
    public void GetAllFactions_RespondingWithNull_ShouldThrowNullExceptionWithMessage()
    {
        var factionRepository = new Mock<IFactionRepository>();
        FactionService factionService = new FactionService(factionRepository.Object);

        factionRepository.Setup(x => x.GetAllFactions()).Returns((List<Faction>)null);
        
        Action test = () => factionService.GetAllFactions();

        test.Should().Throw<NullReferenceException>().WithMessage("Unable to fetch factions.");
    }

    [Fact]
    public void UpdateFaction_WithNullAsObject_ShouldThrowNullExpcetionWithMessage()
    {
        IFactionRepository factionRepository = new Mock<IFactionRepository>().Object;
        FactionService factionService = new FactionService(factionRepository);
        
        Action test = () => factionService.UpdateFaction(null);
        
        test.Should().Throw<NullReferenceException>().WithMessage("Faction object cannot be null.");
    }

    [Fact]
    public void UpdateFaction_WithValidParamater_ShouldReturnValidObject()
    {
        var factionRepository = new Mock<IFactionRepository>();
        FactionService factionService = new FactionService(factionRepository.Object);
        
        factionRepository.Setup(x => x.UpdateFaction(It.IsAny<Faction>())).Returns(new Faction());

        Faction faction = new Faction();
        
        faction.factionId = 1;
        faction.factionName = "Test Faction";
        faction.factionDescription = "Test Description";
        
        Action test = () => factionService.UpdateFaction(faction);

        test.Should().Equals(faction);
    }

    [Theory]
    [InlineData(0, "Test Faction", "Test Description", "Faction ID must be greater than 0.")]
    [InlineData(-1, "Test Faction", "Test Description", "Faction ID must be greater than 0.")]
    [InlineData(1, "", "Test Description", "Faction name cannot be empty.")]
    [InlineData(1, null, "Test Description", "Faction name cannot be null.")]
    [InlineData(1, "Test Faction", null, "Faction description cannot be null.")]
    public void UpdateFaction_WithInvalidProperties_ShouldThrowValidationExceptionWithCorrectMessage(int id, string name, string description, string message)
    {
        IFactionRepository factionRepository = new Mock<IFactionRepository>().Object;
        FactionValidator factionValidator = new FactionValidator();
        FactionService factionService = new FactionService(factionRepository, factionValidator);

        Faction faction = new Faction();
        faction.factionId = id;
        faction.factionName = name;
        faction.factionDescription = description;
        
        Action test = () => factionService.UpdateFaction(faction);
        
        test.Should().Throw<ValidationException>().WithMessage(message);
    }
}