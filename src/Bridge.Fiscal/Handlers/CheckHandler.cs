namespace Bridge.Fiscal.Handlers;

public class CheckHandler(IFiscalService fiscalService, ICacheService cacheService) : Handler<Check>
{
    private const string CHECK_NUMBER_KEY = "CheckNumber";

    private const int CHECK_NUMBER_MIN = 1;

    private const int CHECK_NUMBER_MAX = 9999;

    private static readonly SemaphoreSlim _semaphore = new(1);

    protected override async Task HandleAsync(Check @in, IEventContext context)
    {
        try
        {
            await _semaphore.WaitAsync();

            if (await cacheService.PopAsync<CheckNumber>(CHECK_NUMBER_KEY) is not CheckNumber checkNumber)
                checkNumber = new()
                {
                    Value = 1
                };

            var checkNumberValue = Math.Min(Math.Max(CHECK_NUMBER_MIN, checkNumber.Value), CHECK_NUMBER_MAX);
            checkNumber.Value = checkNumberValue == CHECK_NUMBER_MAX ? CHECK_NUMBER_MIN : (checkNumberValue + 1);
            await cacheService.PushAsync(CHECK_NUMBER_KEY, checkNumber);

            _semaphore.Release();

            var fiscalCheck = new FiscalCheck
            {
                uws = 1,
                rvc = (int)fiscalService.Environment.Rvc,
                cknum = checkNumberValue,
                open_time = @in.DateTime,
                close_time = @in.DateTime,
                total = @in.Total,
                tremp = 99,
                tremp_fname = "IFC",
                tremp_lname = "Sanatorium",
                cashier = 99,
                dtl = @in.Details.Select(item => new CheckItem
                {
                    type = 'M',
                    objnum = item.ObjectNumber,
                    name = item.Name,
                    qty = (int)item.Quantity,
                    qtf = item.Quantity,
                    ttl = item.Total.ToString(),
                    tax = item.Tax,
                    taxps = item.TaxPosting
                }).ToArray()
            };

            var response = await fiscalService.Exec<Task<SetCheckResponse>>(async checkDB => await checkDB.SetCheckAsync(fiscalCheck));

            context.Send(new PostResponseInfo
            {
                Headers = @in.Headers,
                CorrelationId = @in.CorrelationId,
                Succeeded = response.SetCheckResult.success,
                ErrorMessage = response.SetCheckResult.errtext
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

    protected override string? Message(Check @in) =>
        $"Correlation ID: {@in.CorrelationId}, Date: {@in.DateTime:dd.MM.yyyy HH:mm:ss}, Total: {@in.Total}";
}
