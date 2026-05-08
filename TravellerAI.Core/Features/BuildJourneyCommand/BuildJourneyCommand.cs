using MediatR;

namespace TravellerAI.Core.Features.BuildJourneyCommand;

public class BuildJourneyCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid JourneyId { get; set; }
}