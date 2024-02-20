namespace Bridge.Sanatorium.Handlers;

internal class ReservationHandler(IEventBusService eventBusService) 
    : EventBus.EventHandler<ReservationUpdatedMessage>(eventBusService)
{
    protected override string HandlerName => "N_SERVICE_BUS";

    protected override Task HandleAsync(ReservationUpdatedMessage @in)
    {
        return Task.CompletedTask;
    }
}
