namespace Bridge.Sanatorium.Handlers;

public class PostRequestHandler(IEventBusService eventBusService)
    : EventHandler<PostTransactionsRequest, PostRequestInfo>(eventBusService), IHandleMessages<PostTransactionsRequest>
{
    protected override string HandlerName => "N_SERVICE_BUS";

    public async Task Handle(PostTransactionsRequest message, IMessageHandlerContext context) =>  await InputDataAsync("POST", message);

    protected override Task<PostRequestInfo> HandleAsync(PostTransactionsRequest @in) => Task.FromResult(new PostRequestInfo()
    {
        ReservationGuestId = @in.ReservationGuestId,
        InvoiceGenericNo = @in.InvoiceGenericNo,
        FolioGenericNo = @in.FolioGenericNo,
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
