namespace Bridge.Sanatorium.Handlers;

public class PostResponseHandler(ISanatoriumService sanatoriumService, IEventBusService eventBusService)
    : EventBus.EventHandler<PostResponseInfo>(eventBusService)
{
    private readonly ISanatoriumService _sanatoriumService = sanatoriumService;

    protected override string HandlerName => "N_SERVICE_BUS";

    protected override async Task HandleAsync(PostResponseInfo @in)
    {
        PostTransactionsResponse message = new(@in.CorrelationId)
        {
            Succeeded = @in.Succeeded,
            ErrorCode = @in.ErrorCode!,
            ErrorMessage = @in.ErrorMessage!
        };

        await _sanatoriumService.PublishAsync(message);
    }
}
