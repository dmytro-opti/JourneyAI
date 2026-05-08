using MediatR;
using TravellerAI.Core.Interfaces;

namespace TravellerAI.Core.Features.BuildJourneyCommand;

public class BuildJourneyCommandHandler : IRequestHandler<BuildJourneyCommand, Unit>
{
    private readonly IBudgetService _budgetService;
    private readonly IJourneyService _journeyService;
    private readonly IUserService _userService;
    
    public BuildJourneyCommandHandler(IUserService userService, IBudgetService budgetService, IJourneyService journeyService)
    {
        _userService = userService;
        _budgetService = budgetService;
        _journeyService = journeyService;
    }
    
    public async Task<Unit> Handle(BuildJourneyCommand command, CancellationToken cancellationToken)
    {
        var user = await _userService.GetUser(command.UserId);
        var journeyData = await _journeyService.GetJourneyData(command.JourneyId);
        var journeyHotels = await _journeyService.GetHotels(command.JourneyId);
        var journeyLocations = await _journeyService.GetLocations(command.JourneyId);
        var budget = await _budgetService.CalculateBudget(command.UserId, command.JourneyId);
        await _journeyService.Build(new Guid(), new Guid(), command.UserId, command.JourneyId);

        return Unit.Value;
    }
}