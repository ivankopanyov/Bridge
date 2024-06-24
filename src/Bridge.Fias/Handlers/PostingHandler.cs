namespace Bridge.Fias.Handlers;

public class PostingHandler(IFiasService fiasService) : Handler<PostRequestInfo>
{
    protected override async Task HandleAsync(PostRequestInfo @in, IEventContext context)
    {
        try
        {
            long profileNumber = default;
            int reservationNumber = default;

            if (@in.ReservationGuestId?.Split('/') is string[] reservationGuestIdSplit && reservationGuestIdSplit.Length == 2)
            {
                if (long.TryParse(reservationGuestIdSplit[0], out long profileId))
                    profileNumber = profileId;

                if (int.TryParse(reservationGuestIdSplit[1], out int reservationId))
                    reservationNumber = reservationId;
            }

            var roomNumber = @in.FolioGenericNo ?? string.Empty;

            if (@in.FolioGenericNo?.Split('/') is string[] folioGenericNoSplit && folioGenericNoSplit.Length == 2)
            {
                if (int.TryParse(folioGenericNoSplit[0], out int reservationId))
                    reservationNumber = reservationId;

                roomNumber = folioGenericNoSplit[1];
            }

            var description = @in.Transactions.LastOrDefault()?.Name;
            var number = 0;
            var checks = fiasService.TaxCodes
                .Select(item => @in.Transactions
                    .SelectMany(t => t.Items)
                    .Where(i => i.ServiceItemCode == item.Key)
                    .Select(i => new FiscalCheckItem
                    {
                        ObjectNumber = int.TryParse(i.TransactionCode, out int objectNumber) && objectNumber > 0 ? objectNumber : ++number,
                        Name = i.Name,
                        Quantity = (double)i.Count,
                        Total = i.Amount,
                        Tax = (byte)(item.Value ? 128 : 0),
                        TaxPosting = i.ItemKind
                    }));

            var subtotals = checks.Select(c => c.Select(i => i.Total).Sum()).ToArray();

            var payments = @in.Transactions
                .Where(t => t.Items.Count > 0 && t.Items.Any(i => string.IsNullOrEmpty(i.ServiceItemCode)))
                .GroupBy(t => t.TransactionCode);

            var dateTime = DateTime.Now;
            decimal total;
            FiasPostingAnswer answer;

            if (payments.LastOrDefault() is { } payment)
            {
                total = payment
                    .SelectMany(t => t.Items.Where(i => string.IsNullOrEmpty(i.ServiceItemCode)))
                    .Select(i => -i.Amount * 100).Sum();

                answer = await fiasService.SendPostingAsync(new FiasPostingSimple
                {
                    RoomNumber = string.Empty,
                    PostingType = FiasPostingTypes.DirectCharge,
                    SalesOutlet = 100,
                    TotalPostingAmount = total,
                    DateTime = dateTime,
                    PostingSequenceNumber = reservationNumber,
                    PmsPaymentMethod = payment.Key,
                    CheckNumber = @in.InvoiceGenericNo,
                    Subtotals = subtotals.Select(s => (decimal?)s).ToArray()
                });
            }
            else
            {
                total = subtotals.Sum();

                answer = await fiasService.SendPostingAsync(new FiasPostingRequest
                {
                    DateTime = dateTime,
                    ReservationNumber = reservationNumber,
                    PostingSequenceNumber = reservationNumber,
                    TotalPostingAmount = total,
                    ProfileNumber = profileNumber,
                    CheckNumber = @in.InvoiceGenericNo,
                    RoomNumber = roomNumber,
                    Subtotals = subtotals.Select(s => (decimal?)s).ToArray()
                });
            }

            var success = answer.AnswerStatus == FiasAnswerStatuses.Successfully;

            if (!success || !fiasService.UseCheckDatabase)
                context.Send(new PostResponseInfo
                {
                    Headers = @in.Headers,
                    CorrelationId = @in.CorrelationId,
                    Succeeded = success,
                    ErrorMessage = !success ? answer.ClearText : null
                });
            else
                context.Send(new Check
                {
                    Headers = @in.Headers,
                    CorrelationId = @in.CorrelationId,
                    DateTime = dateTime,
                    Total = total.ToString(),
                    Details = checks.SelectMany(c => c)
                });
        }
        catch (Exception ex)
        {
            context.Send(new PostResponseInfo
            {
                Headers = @in.Headers,
                CorrelationId = @in.CorrelationId,
                Succeeded = false,
                ErrorMessage = ex.Message
            });
        }
    }

    protected override string? Message(PostRequestInfo @in)
    {
        string? result = null;

        if (!string.IsNullOrWhiteSpace(@in.ReservationGuestId))
            result = $"Reservation: {@in.ReservationGuestId}";

        if (!string.IsNullOrWhiteSpace(@in.InvoiceGenericNo))
        {
            if (result == null)
                result = $"Invoice: {@in.InvoiceGenericNo}";
            else
                result += $", Invoice: {@in.InvoiceGenericNo}";
        }

        if (!string.IsNullOrWhiteSpace(@in.FolioGenericNo))
        {
            if (result == null)
                result = $"Folio: {@in.FolioGenericNo}";
            else
                result += $", Folio: {@in.FolioGenericNo}";
        }

        return result;
    }
}
