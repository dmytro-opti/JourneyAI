namespace TravellerAI.Domain.Models;

public class FinalJourneyModel
{
    public Guid JourneyId { get; set; }
    public Guid UserId { get; set; }
    public Guid HotelId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    
    public FinalJourneyModel()
    {}
}