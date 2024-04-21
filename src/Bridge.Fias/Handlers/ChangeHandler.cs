namespace Bridge.Fias.Handlers;

internal class ChangeHandler : EventHandler<FiasGuestChange, ReservationInfo>
{
    protected override string HandlerName => "CHANGE";

    public ChangeHandler(IFias fiasService, IEventBusService eventBusService) : base(eventBusService)
    {
        fiasService.FiasGuestChangeEvent += async message => await InputDataAsync("RESV", message);
    }

    protected override Task<ReservationInfo> HandleAsync(FiasGuestChange @in, string? taskId)
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

        return Task.FromResult(new ReservationInfo
        {
            Resort = "RSS",
            Id = @in.ReservationNumber,
            Room = @in.RoomNumber,
            Status = "IN",
            ArrivalDate = arrivalDate,
            DepartureDate = departureDate
        });
    }

    protected override string? SuccessfulLog(FiasGuestChange @in, ReservationInfo @out)
        => $"{@out.Id} {@out.Room} {@out.ArrivalDate} - {@out.DepartureDate}";

    protected override string? ErrorLog(FiasGuestChange @in, Exception ex)
        => $"{@in.ReservationNumber} {@in.RoomNumber} {@in.GuestArrivalDate} - {@in.GuestDepartureDate}";
}
