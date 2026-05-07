using TravellerAI.Domain.Enums;

namespace TravellerAI.Domain.Models;

public class BookingModel
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid EstablishmentId { get; set; }
    public DateTime BookingDateTime { get; set; }
    public int GuestCount { get; set; } 
    public BookingStatus Status { get; set; } 
    public DateTime CreatedAt { get; set; }
}