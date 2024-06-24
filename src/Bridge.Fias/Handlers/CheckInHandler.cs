namespace Bridge.Fias.Handlers;

public class CheckInHandler : Handler<FiasGuestCheckIn>
{
    protected override Task HandleAsync(FiasGuestCheckIn @in, IEventContext context)
    {
        DateTime? arrivalDate = null;
        if (@in.GuestArrivalDate is DateOnly _arrivalDate)
            arrivalDate = _arrivalDate.ToDateTime(default);

        DateTime? departureDate = null;
        if (@in.GuestDepartureDate is DateOnly _departureDate)
        {
            departureDate = _departureDate.ToDateTime(default);
            if (arrivalDate is DateTime date && date == departureDate)
                departureDate = date.AddDays(1).AddTicks(-1);
        }

        context.Send(new ReservationInfo
        {
            ReservationNumber = @in.ReservationNumber,
            Room = @in.RoomNumber,
            Status = "IN",
            ArrivalDate = arrivalDate,
            DepartureDate = departureDate
        });

        return Task.CompletedTask;
    }

    protected override string? Message(FiasGuestCheckIn @in)
    {
        var result = $"Reservation: {@in.ReservationNumber}";

        if (!string.IsNullOrWhiteSpace(@in.RoomNumber))
            result += $", Room: {@in.RoomNumber}";

        if (!string.IsNullOrWhiteSpace(@in.GuestName))
            result += $" {@in.GuestName}";

        return result;
    }
}
