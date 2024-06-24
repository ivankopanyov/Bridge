namespace Bridge.Sanatorium.Handlers;

public class PostingRequestHandler(ISanatoriumService sanatoriumService) : Handler<PostingRequest>
{
    protected override Task HandleAsync(PostingRequest @in, IEventContext context)
    {
        try
        {
            var invoiceGenericNo = @in.PostTransactionsRequest.Transactions.SelectMany(t => t.Items).Any(i => !string.IsNullOrWhiteSpace(i.ServiceItemCode))
                ? sanatoriumService.Environment.Rvc.ToString("000.##") + @in.PostTransactionsRequest.InvoiceGenericNo
                : DateTime.Now.ToString("yyyyMMddhhmmssfffffff");

            context.Send(new PostRequestInfo()
            {
                Headers = @in.Headers,
                CorrelationId = @in.PostTransactionsRequest.CorrelationId,
                ReservationGuestId = @in.PostTransactionsRequest.ReservationGuestId,
                InvoiceGenericNo = invoiceGenericNo,
                FolioGenericNo = @in.PostTransactionsRequest.FolioGenericNo,
                Transactions = @in.PostTransactionsRequest.Transactions?.Select(t => new TransactionInfo()
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
        catch (Exception ex)
        {
            context.Break(ex.Message, ex);
        }

        return Task.CompletedTask;
    }

    protected override string? Message(PostingRequest @in)
    {
        string result = $"Correlation ID: {@in.PostTransactionsRequest?.CorrelationId}";

        if (!string.IsNullOrWhiteSpace(@in.PostTransactionsRequest?.ReservationGuestId))
            result += $", Reservation: {@in.PostTransactionsRequest?.ReservationGuestId}";

        if (!string.IsNullOrWhiteSpace(@in.PostTransactionsRequest?.FolioGenericNo))
            result = $", FolioGenericNo: {@in.PostTransactionsRequest?.FolioGenericNo}";

        return result;
    }
}
