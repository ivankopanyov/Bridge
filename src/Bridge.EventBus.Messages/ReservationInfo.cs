namespace Bridge.EventBus.Messages;

public class ReservationInfo
{
    public string Resort { get; set; }

    public decimal Id { get; set; }

    public string Status { get; set; }

    public string? Room { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? DepartureDate { get; set; }
}
