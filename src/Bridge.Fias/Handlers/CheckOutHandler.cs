namespace Bridge.Fias.Handlers;

internal class CheckOutHandler : EventHandler<FiasGuestCheckOut, ReservationInfo>
{
    protected override string HandlerName => "CHECKOUT";

    public CheckOutHandler(IFiasService fiasService, IEventBusService eventBusService, ILogger<CheckOutHandler> logger)
        : base(eventBusService, logger)
    {
        fiasService.FiasGuestCheckOutEvent += async message => await InputDataAsync("RESV", message);
    }

    protected override Task<ReservationInfo> HandleAsync(FiasGuestCheckOut @in)
    {
        return Task.FromResult(new ReservationInfo
        {
            Resort = "RSS",
            Id = @in.ReservationNumber,
            Room = @in.RoomNumber,
            Status = "OUT"
        });
    }

    protected override string InputLog(FiasGuestCheckOut @in) => @in.Source ?? @in.ReservationNumber.ToString();

    protected override string OutputLog(ReservationInfo @out) =>
        $"GUEST CHECKIN: {string.Format("{0:0}", @out.Id)}  {@out.Room ?? "ROOM"}";
}
