namespace TravellerAI.Core.Interfaces;

public interface IJourneyService
{
    public Task<string> GetJourneyData(Guid journeyId);
    public Task<string> GetLocations(Guid journeyId);
    public Task<string> GetTransport(Guid journeyId);
    public Task<string> GetHotels(Guid journeyId);
    public Task<string> SelectHotel(Guid hotelId);
    public Task<string> SelectPlace(Guid placeId);
    public Task Build(Guid hotelId, Guid placeId, Guid userId, Guid journeyId);
}