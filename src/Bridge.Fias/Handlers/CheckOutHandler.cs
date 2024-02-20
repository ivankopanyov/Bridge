namespace Bridge.Fias.Handlers;

internal class CheckOutHandler : EventHandler<FiasGuestCheckOut, ReservationInfo>
{
    protected override string HandlerName => "CHECKOUT";

    public CheckOutHandler(IFiasService fiasService, IEventBusService eventBusService) : base(eventBusService)
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
}
