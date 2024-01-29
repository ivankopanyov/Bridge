namespace Bridge.Fias.Handlers;

internal class ChangeHandler : StartEventHandler<FiasGuestChange, ReservationInfo>
{
    protected override string HandlerName => "CHANGE";

    public ChangeHandler(IFiasService fiasService, IEventBusService eventBusService, ILogger<ChangeHandler> logger)
        : base(eventBusService, logger)
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

    protected override string InputLog(FiasGuestChange @in) => @in.Source ?? @in.ReservationNumber.ToString();

    protected override string OutputLog(ReservationInfo @out) =>
        $"GUEST CHECKIN: {string.Format("{0:0}", @out.Id)}  {@out.Room ?? "ROOM"}  {@out.ArrivalDate?.ToString("dd.MM.yyyy") ?? "ARRIVAL"} - {@out.DepartureDate?.ToString("dd.MM.yyyy") ?? "DEPARTURE"}";
}
