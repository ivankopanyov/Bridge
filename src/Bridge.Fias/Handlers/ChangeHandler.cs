namespace Bridge.Fias.Handlers;

internal class ChangeHandler : EventHandler<FiasGuestChange, ReservationInfo>
{
    protected override string HandlerName => "CHANGE";

    public ChangeHandler(IFiasService fiasService, IEventBusService eventBusService) : base(eventBusService)
    {
        fiasService.FiasGuestChangeEvent += async message => await InputDataAsync("RESV", message);
    }

    protected override Task<ReservationInfo> HandleAsync(FiasGuestChange @in)
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
}
