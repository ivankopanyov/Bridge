namespace Bridge.Fias.Handlers;

public class PostingAnswerHandler : EventHandler<FiasPostingAnswer, Check>
{
    private readonly IFias _fiasService;

    private readonly ICache _cache;

    private readonly IEventBusService _eventBusService;

    public PostingAnswerHandler(IFias fiasService, ICache cache, IEventBusService eventBusService) : base(eventBusService)
    {
        _fiasService = fiasService;
        _cache = cache;
        _eventBusService = eventBusService; 

        _fiasService.FiasPostingAnswerEvent += async (message) => await InputDataAsync("POST", message, message.CheckNumber);
    }

    protected override async Task<Check> HandleAsync(FiasPostingAnswer @in, string? taskId)
    {
        if (@in.AnswerStatus != FiasAnswerStatuses.Successfully)
        {
            await _eventBusService.PublishAsync("POST", taskId, new PostResponseInfo
            {
                Succeeded = false,
                ErrorMessage = @in.ClearText
            });

            return null!;
        }

        return (await _cache.PopAsync<Check>(@in.CheckNumber!))!;
    }
}
