using DataModeling.Library;

namespace DataModels;

public class BookingData : CustomBaseModel
{
    public CustomUser Passenger { get; init; }
    public FlightData Flight { get; init; }
    public float Price { get; init; }
    public DateTime DepartureDate { get; init; }
    public Airport DepartureAirport { get; init; }
    public Airport ArrivalAirport { get; init; }
}