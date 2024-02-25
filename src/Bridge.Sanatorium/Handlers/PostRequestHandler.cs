namespace Bridge.Sanatorium.Handlers;

public class PostRequestHandler(ISanatoriumService sanatoriumService, IEventBusService eventBusService)
    : EventHandler<PostTransactionsRequest, PostRequestInfo>(eventBusService), IHandleMessages<PostTransactionsRequest>
{
    private readonly ISanatoriumService _sanatoriumService = sanatoriumService;

    protected override string HandlerName => "N_SERVICE_BUS";

    public async Task Handle(PostTransactionsRequest message, IMessageHandlerContext context)
    {
        var taskId = message.Transactions.SelectMany(t => t.Items).Any(i => !string.IsNullOrWhiteSpace(i.ServiceItemCode))
            ? _sanatoriumService.Rvc.ToString("000.##") + message.InvoiceGenericNo
            : DateTime.Now.ToString("yyyyMMddhhmmssfffffff");

        await InputDataAsync("POST", message, taskId);
    }

    protected override Task<PostRequestInfo> HandleAsync(PostTransactionsRequest @in, string? taskId) => Task.FromResult(new PostRequestInfo()
    {
        ReservationGuestId = @in.ReservationGuestId,
        InvoiceGenericNo = taskId ?? @in.InvoiceGenericNo,
        FolioGenericNo = @in.FolioGenericNo,
        Rvc = (int)_sanatoriumService.Rvc,
        Transactions = @in.Transactions?.Select(t => new TransactionInfo()
        {
            ScheduleDate = t.ScheduleDate,
            TransactionCode = t.TransactionCode,
            Name = t.Name,
            Items = t.Items?.Select(d => new TransactionDetailsInfo()
            {
                ItemKind = (int)d.ItemKind,
                Name = d.Name,
                Amount = d.Amount,
                ServiceItemCode = d.ServiceItemCode,
                Count = d.Count,
                TransactionCode = d.TransactionCode
            }).ToHashSet() ?? []
        }).ToHashSet() ?? []
    });
}
