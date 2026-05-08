using TravellerAI.Core.Interfaces;

namespace TravellerAI.Core.Services;

public class JourneyService : IJourneyService
{
    public Task<string> GetJourneyData(Guid journeyId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetLocations(Guid journeyId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetTransport(Guid journeyId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetHotels(Guid journeyId)
    {
        throw new NotImplementedException();
    }

    public Task<string> SelectHotel(Guid hotelId)
    {
        throw new NotImplementedException();
    }

    public Task<string> SelectPlace(Guid placeId)
    {
        throw new NotImplementedException();
    }

    public Task Build(Guid hotelId, Guid placeId, Guid userId, Guid journeyId)
    {
        throw new NotImplementedException();
    }
}