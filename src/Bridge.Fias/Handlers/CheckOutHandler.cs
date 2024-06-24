namespace Bridge.Fias.Handlers;

public class CheckOutHandler : Handler<FiasGuestCheckOut>
{
    protected override Task HandleAsync(FiasGuestCheckOut @in, IEventContext context)
    {
        context.Send(new ReservationInfo
        {
            ReservationNumber = @in.ReservationNumber,
            Room = @in.RoomNumber,
            Status = "OUT"
        });

        return Task.CompletedTask;
    }

    protected override string? Message(FiasGuestCheckOut @in)
    {
        var result = $"Reservation: {@in.ReservationNumber}";

        if (!string.IsNullOrWhiteSpace(@in.RoomNumber))
            result += $", Room: {@in.RoomNumber}";

        return result;
    }
}
