namespace Bridge.Sanatorium.Handlers;

internal class ReservationHandler(IEventBusService eventBusService, ILogger<ReservationHandler> logger) 
    : EventBus.EventHandler<ReservationUpdatedMessage>(eventBusService, logger)
{
    protected override string HandlerName => "N_SERVICE_BUS";

    protected override Task HandleAsync(ReservationUpdatedMessage @in)
    {
        return Task.CompletedTask;
    }

    protected override string? InputLog(ReservationUpdatedMessage @in) => @in.Id;
}
