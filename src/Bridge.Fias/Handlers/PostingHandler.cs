namespace Bridge.Fias.Handlers;

public class PostingHandler : EventBus.EventHandler<PostRequestInfo>
{
    private readonly ICache _cache;

    private readonly IFias _fiasService;

    private readonly IEventBusService _eventBusService;

    protected override string HandlerName => "NEW_POST";

    public PostingHandler(ICache cache, IFias fiasService, IEventBusService eventBusService)
        : base(eventBusService)
    {
        _cache = cache;
        _fiasService = fiasService;
        _eventBusService = eventBusService;
    }

    protected override async Task HandleAsync(PostRequestInfo @in, string? taskId)
    {
        await _eventBusService.PublishAsync("POST", taskId, new PostResponseInfo
        {
            Succeeded = false,
            ErrorMessage = "The process of accrual to the external system is in progress."
        });

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
        var checks = _fiasService.TaxCodes
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
        string message;

        if (payments.LastOrDefault() is { } payment)
        {
            total = payment
                .SelectMany(t => t.Items.Where(i => string.IsNullOrEmpty(i.ServiceItemCode)))
                .Select(i => -i.Amount * 100).Sum();

            message = new FiasPostingRequest
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
            }.ToString();
        }
        else
        {
            total = subtotals.Sum();

            message = new FiasPostingRequest
            {
                DateTime = dateTime,
                ReservationNumber = reservationNumber,
                PostingSequenceNumber = reservationNumber,
                TotalPostingAmount = total,
                ProfileNumber = profileNumber,
                CheckNumber = @in.InvoiceGenericNo,
                RoomNumber = roomNumber,
                Subtotals = subtotals.Select(s => (decimal?)s).ToArray()
            }.ToString();
        }

        await _cache.PushAsync(@in.InvoiceGenericNo, new Check
        {
            Rvc = @in.Rvc,
            CheckNumber = int.TryParse(dateTime.DayOfYear.ToString("000") + dateTime.ToString("hhmmss"), out int checkNumber)
                && checkNumber > 0 ? checkNumber : 1,
            DateTime = dateTime,
            Total = total.ToString(),
            Details = checks.SelectMany(c => c)
        });

        _fiasService.Send(message);
    }
}
